using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchEx.Entites.Exceptions {
    class DomainExceptions : ApplicationException{

        public DomainExceptions(string message): base(message) {
        }
    }
}
