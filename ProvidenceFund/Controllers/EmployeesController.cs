using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProvidenceFund.Data;
using ProvidenceFund.Models;
using ProvidenceFund.ViewModel;

namespace ProvidenceFund.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ProvidenceFundContext _context;

        public EmployeesController(ProvidenceFundContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            List<Employee> emp = await _context.Employee.ToListAsync();
            List<PvdFund> pvd = await _context.PvdFund.ToListAsync();

            var rvm = (from e in emp
                       join p in pvd on e.Id equals p.Id
                       select new EmployeeViewModel()
                       {
                           Id = e.Id,
                           FirstName = e.FirstName,
                           LastName = e.LastName,
                           DateOfBirth = e.DateOfBirth,
                           StartWorkDate = p.StartWorkDate,
                           Salary = p.Salary,
                           Rate = p.Rate,
                       }).ToList();

            return View(rvm);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.Id == id);
            var pvdFund = await _context.PvdFund
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null || pvdFund == null)
            {
                return NotFound();
            }

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();

            employeeViewModel.Id = employee.Id;
            employeeViewModel.FirstName = employee.FirstName;
            employeeViewModel.LastName = employee.LastName;
            employeeViewModel.Address = employee.Address;
            employeeViewModel.DateOfBirth = employee.DateOfBirth;
            employeeViewModel.Age = employee.Age;

            employeeViewModel.StartWorkDate = pvdFund.StartWorkDate;
            employeeViewModel.Salary = pvdFund.Salary;
            employeeViewModel.Rate = pvdFund.Rate;

            return View(employeeViewModel);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,DateOfBirth,Address,StartWorkDate,Salary,Rate")] EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                Employee emp = new Employee();
                emp.Id = employeeViewModel.Id;
                emp.FirstName = employeeViewModel.FirstName;
                emp.LastName = employeeViewModel.LastName;
                emp.Address = employeeViewModel.Address;
                emp.DateOfBirth = employeeViewModel.DateOfBirth;
                emp.Age = DateTime.UtcNow.Year - emp.DateOfBirth.AddYears(543).Year; // Convert Datetime input to UTC Now.

                PvdFund pvd = new PvdFund();
                pvd.Id = emp.Id;
                pvd.StartWorkDate = employeeViewModel.StartWorkDate;
                pvd.Salary = employeeViewModel.Salary;
                pvd.Rate = employeeViewModel.Rate;

                _context.Employee.Add(emp);
                _context.PvdFund.Add(pvd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeViewModel);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            var pvdFund = await _context.PvdFund.FindAsync(id);
            if (employee == null || pvdFund == null)
            {
                return NotFound();
            }
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();

            employeeViewModel.Id = employee.Id;
            employeeViewModel.FirstName = employee.FirstName;
            employeeViewModel.LastName = employee.LastName;
            employeeViewModel.Address = employee.Address;
            employeeViewModel.DateOfBirth = employee.DateOfBirth;

            employeeViewModel.StartWorkDate = pvdFund.StartWorkDate;
            employeeViewModel.Salary = pvdFund.Salary;
            employeeViewModel.Rate = pvdFund.Rate;

            return View(employeeViewModel);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,DateOfBirth,Address,StartWorkDate,Salary,Rate")] EmployeeViewModel employeeViewModel)
        {
            if (id != employeeViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Employee emp = new Employee();
                    emp.Id = employeeViewModel.Id;
                    emp.FirstName = employeeViewModel.FirstName;
                    emp.LastName = employeeViewModel.LastName;
                    emp.Address = employeeViewModel.Address;
                    emp.DateOfBirth = employeeViewModel.DateOfBirth;
                    emp.Age = DateTime.UtcNow.Year - emp.DateOfBirth.AddYears(543).Year; // Convert Datetime input to UTC Now.

                    PvdFund pvd = new PvdFund();
                    pvd.Id = emp.Id;
                    pvd.StartWorkDate = employeeViewModel.StartWorkDate;
                    pvd.Salary = employeeViewModel.Salary;
                    pvd.Rate = employeeViewModel.Rate;

                    _context.Employee.Update(emp);
                    _context.PvdFund.Update(pvd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employeeViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employeeViewModel);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.Id == id);
            var pvdFund = await _context.PvdFund
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null || pvdFund == null)
            {
                return NotFound();
            }

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();

            employeeViewModel.Id = employee.Id;
            employeeViewModel.FirstName = employee.FirstName;
            employeeViewModel.LastName = employee.LastName;

            employeeViewModel.StartWorkDate = pvdFund.StartWorkDate;
            employeeViewModel.Salary = pvdFund.Salary;

            return View(employeeViewModel);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            var pvd = await _context.PvdFund.FindAsync(id);
            _context.Employee.Remove(employee);
            _context.PvdFund.Remove(pvd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }
    }
}
