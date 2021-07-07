using Microsoft.EntityFrameworkCore;
using Projeto_WEB.Data;
using Projeto_WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_WEB.Services
{
    public class SalesRecordService
    {
        private readonly Projeto_WEBContext _context;

        public SalesRecordService(Projeto_WEBContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? masxDate)
        {
            var result = from obj in _context.SalesRecords select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }

            if (masxDate.HasValue)
            {
                result = result.Where(x => x.Date <= masxDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();

        }

        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? masxDate)
        {
            var result = from obj in _context.SalesRecords select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }

            if (masxDate.HasValue)
            {
                result = result.Where(x => x.Date <= masxDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Seller.Department)
                .ToListAsync();
        }

    }
}
