using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto2021
{
    class MonoalphabeticSubsitution : CryptoSubstitutionBase
    {
        public MonoalphabeticSubsitution()
        {
            key = alphabet;
            char[] keyChars = key.ToCharArray();

            // amestecam aleator literele din keyChars (shuffle)
            //for i from n−1 downto 1 do
            //        j ← random integer such that 0 ≤ j ≤ i
            //        exchange a[j] and a[i]
            int j;
            Random rnd = new Random();
            char aux;
            for (int i  = keyChars.Length - 1; i  >= 1; i--)
            {
                j = rnd.Next(i + 1);
                aux = keyChars[i];
                keyChars[i] = keyChars[j];
                keyChars[j] = aux;
            }

            key = new string(keyChars);
        }
    }
}
