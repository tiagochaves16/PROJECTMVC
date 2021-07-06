using System;


namespace Projeto_WEB.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public  NotFoundException(string message) : base(message) 
        {
        }
    }
}
