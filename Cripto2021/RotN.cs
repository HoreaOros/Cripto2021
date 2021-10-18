using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto2021
{
    class RotN : CryptoSubstitutionBase
    {
        public RotN(int n)
        {
            key = alphabet.Substring(n % 26) + alphabet.Substring(0, n % 26);
        }
    }
}
