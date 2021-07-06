using System;


namespace Projeto_WEB.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base (message)
        {
        }
    }
}
