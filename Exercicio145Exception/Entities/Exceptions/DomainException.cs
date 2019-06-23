using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio145Exception.Entities.Exceptions
{
    // cria uma classe própria de exceção, derivando da classe ApplicationException
    class DomainException: ApplicationException
    {
        public DomainException(string message): base(message)
        {

        }

    }
}
