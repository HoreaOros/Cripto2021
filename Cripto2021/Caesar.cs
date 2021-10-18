using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto2021
{
    class Caesar : CryptoSubstitutionBase
    {
        public Caesar()
        {
            key = alphabet.Substring(3) + alphabet.Substring(0, 3);   
        }
    }
}
