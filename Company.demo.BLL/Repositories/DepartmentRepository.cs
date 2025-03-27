using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.demo.BLL.Interfaces;
using Company.demo.DAL.Data.Contexts;
using Company.demo.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.demo.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly CompanyDpContext _dpContext;// NULL
        public DepartmentRepository(CompanyDpContext companyDpContext)
        {
            _dpContext = companyDpContext;
        }
        public IEnumerable<Department> GetAll()
        {
            return _dpContext.Departments.ToList();
        }
        public Department? Get(int id)
        {
            return _dpContext.Departments.Find();
        }
        public int Add(Department model)
        {
            _dpContext.Departments.Add(model);
            return _dpContext.SaveChanges();
        }
        public int Update(Department model)
        {
            _dpContext.Departments.Update(model);
            return _dpContext.SaveChanges();
        }
        public int Delete(Department model)
        {
            _dpContext.Departments.Remove(model);
            return _dpContext.SaveChanges();
        }
    }
}
