using Projeto_WEB.Data;
using Projeto_WEB.Models;
using System.Collections.Generic;
using System.Linq;


namespace Projeto_WEB.Services
{
    public class DepartmentService
    {
        private readonly Projeto_WEBContext _context;

        public DepartmentService(Projeto_WEBContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
