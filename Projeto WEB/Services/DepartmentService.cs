using Microsoft.EntityFrameworkCore;
using Projeto_WEB.Data;
using Projeto_WEB.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_WEB.Services
{
    public class DepartmentService
    {
        private readonly Projeto_WEBContext _context;

        public DepartmentService(Projeto_WEBContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
