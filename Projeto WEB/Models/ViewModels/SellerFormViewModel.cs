
using System.Collections.Generic;


namespace Projeto_WEB.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public  Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
