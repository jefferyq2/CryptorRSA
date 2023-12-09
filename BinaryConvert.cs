using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptorRSA
{
    public class BinaryConvert
    {
        public long Pow(long number, int pow)
        {
            long _number = number;

            if (pow == 0)
            {
                _number = 1;
            }
            else
            {
                for (int i = 0; i < pow - 1; i++)
                {
                    _number *= number;
                }
            }

            return _number;
        }

        private long ConvertToTen(long numberBase, long number)
        {
            long finalSumm = 0;

            for (int i = 0; i < number.ToString().Length; i++)
            {
                finalSumm += (number.ToString()[i] - '0') * this.Pow(numberBase, number.ToString().Length - 1 - i);

            }

            return finalSumm;
        }

        private string ConvertToAny(long number, long finalNumberBase)
        {
            long _number = number;
            int tempInt = 0;
            string numberStringOut = "";
            List<int> numberArrayList = new List<int>();

            while (_number != 0)
            {
                numberArrayList.Add((int)(_number % finalNumberBase));
                _number /= finalNumberBase;
            }

            for (int i = 0; i < numberArrayList.Count / 2; i++)
            {
                tempInt = numberArrayList[numberArrayList.Count - i - 1];
                numberArrayList[numberArrayList.Count - i - 1] = numberArrayList[i];
                numberArrayList[i] = tempInt;
            }

            foreach (int digit in numberArrayList)
            {
                numberStringOut += digit.ToString();
            }

            return numberStringOut;
        }

        public string Convert(long numberBase, long number, long finalNumberBase)
        {
            long tempInt = 0;

            if ((int)numberBase == 10)
            {
                return ConvertToAny(number, finalNumberBase);
            }
            else
            {
                tempInt = ConvertToTen(numberBase, number);
                return ConvertToAny(tempInt, finalNumberBase);
            }
        }
    }
}
