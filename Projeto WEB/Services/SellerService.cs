﻿using Projeto_WEB.Data;
using Projeto_WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_WEB.Services.Exceptions;

namespace Projeto_WEB.Services
{
    public class SellerService
    {
        private readonly Projeto_WEBContext _context;
        
        public SellerService(Projeto_WEBContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
             return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task <Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {

                throw new IntegrityException(e.Message);
            }
           
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
