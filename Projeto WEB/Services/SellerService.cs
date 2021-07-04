using Projeto_WEB.Data;
using Projeto_WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_WEB.Services
{
    public class SellerService
    {
        private readonly Projeto_WEBContext _context;
        
        public SellerService(Projeto_WEBContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
