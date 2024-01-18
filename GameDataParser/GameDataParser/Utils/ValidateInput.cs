using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.Utils
{
    class ValidateInput : IValidateInput
    {
        public bool IsEmpty(string input) => input.Equals(string.Empty);
        public bool IsNull(string input) => input == null;
    }
}
