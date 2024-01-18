using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.Utils
{
    interface IValidateInput
    {
        bool IsNull(string input);
        bool IsEmpty(string input);
    }
}
