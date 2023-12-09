using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptorRSA
{
    public class CoupleString
    {
        public char _letterChar = ' ';
        public string _binaryValue = "";


        public CoupleString(char letterChar, string binaryValue)
        {
            _letterChar = letterChar;
            _binaryValue = binaryValue;
        }
    }
}
