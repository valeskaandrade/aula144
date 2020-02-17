using System;

namespace aula144TratExcecaoParte3.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        { }
    }
}
