using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProvidenceFund.Data;
using ProvidenceFund.Models;
using ProvidenceFund.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProvidenceFund.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProvidenceFundContext _context;

        public HomeController(ProvidenceFundContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Employee> emp = await _context.Employee.ToListAsync();
            List<PvdFund> pvd = await _context.PvdFund.ToListAsync();

            var rvm = (from e in emp
                       join p in pvd on e.Id equals p.Id
                       select new ResultViewModel()
                       {
                           FullName = e.FullName,
                           StartWorkDate = p.StartWorkDate,
                           Salary = p.Salary,
                           Rate = p.Rate,
                           TotalPvdFund = CalculateTotalPvdFund(p.StartWorkDate, p.Salary, p.Rate)
                       }).ToList();

            return View(rvm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private float CalculateTotalPvdFund(DateTime dateTime, int salary, float rate)
        {
            TimeSpan timeSpan = DateTime.UtcNow - dateTime;
            int DiffYear = new DateTime(timeSpan.Ticks).Year - 1;
            int DiffMonth = new DateTime(timeSpan.Ticks).Month - 1;

            float Total = 0f;

            if (DiffMonth <= 3) DiffYear -= 1;

            for (int i=0; i <= DiffYear; i++)
            {
                float DiffRate = rate - i;
                if (DiffRate < 0) DiffRate = 0; // Min diff rate is zero
                Total += (salary * GetPaid(i) / 100) * DiffRate + (salary * rate / 100) * DiffRate;
            }
            return Total;
        }

        private int GetPaid(int year)
        {
            if (year < 1) return 10;
            else if (year < 3) return 30;
            else if (year < 5) return 50;
            else return 80;
        }
    }
}
