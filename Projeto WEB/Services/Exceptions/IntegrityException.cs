using System;


namespace Projeto_WEB.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base (message)
        {
        }
    }
}
