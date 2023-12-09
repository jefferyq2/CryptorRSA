using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CryptorRSA
{
    public class Couple
    {
        public string _stringValue = "";
        public int _intValue = 0;

        public Couple(string stringValue, int intValue)
        {
            _stringValue = stringValue;
            _intValue = intValue;
        }
    }
}
