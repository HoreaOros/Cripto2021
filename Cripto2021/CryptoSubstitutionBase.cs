using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto2021
{
    class CryptoSubstitutionBase : ICipher
    {
        protected string key;
        protected string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public CryptoSubstitutionBase()
        {
            plainText = cipherText = "";
        }

        public void Decrypt()
        {
            throw new NotImplementedException();
        }

        public void Encrypt()
        {
            int offset = 0;
            StringBuilder sb = new StringBuilder();
            foreach (char item in plainText)
            {
                if (char.IsLower(item))
                    offset = item - 'a';
                else if(char.IsUpper(item))
                    offset = item - 'A';

                if (char.IsLetter(item))
                {
                    if (char.IsUpper(item))
                        sb.Append(key[offset]);
                    else
                        sb.Append(char.ToLower(key[offset]));
                }
                else
                    sb.Append(item);
            }
            cipherText = sb.ToString();
        }



        private string plainText;

        public string PlainText
        {
            get 
            {
                //Decrypt();
                return plainText; 
            }
            set { plainText = value; }
        }

        private string cipherText;

        public string CipherText
        {
            get 
            {
                //Encrypt();
                return cipherText; 
            }
            set { cipherText = value; }
        }


    }
}
