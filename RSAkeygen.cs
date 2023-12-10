using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptorRSA
{
    public class RSAkeygen
    {
        private int numP = 2735;
        private int numQ = 6235;
        private int numE = 7;
        private BinaryConvert convert = new BinaryConvert();
        private string PRSFinalOut = "";
        private int firstNumber = 10;
        private int range = 1500;

        public RSAkeygen(int numP, int numQ, int numE, int firstNumber, int range)
        {
            this.numP = numP;
            this.numQ = numQ;
            this.numE = numE;
            this.firstNumber = firstNumber;
            this.range = range;
        }

        public RSAkeygen(int firstNumber, int range)
        {
            this.firstNumber = firstNumber;
            this.range = range;
        }

        public void CreateNextNumber()
        {
            int index = 0;
            long nextNumber = firstNumber;
            string stringOut = "";
            char charCord = ' ';
            string tempStringConvert = "";


            for (int i = 0; i < range; i++)
            {
                nextNumber = Math.Abs(convert.Pow(nextNumber, numE) % (numP * numQ));
                tempStringConvert = convert.Convert(10, nextNumber, 2);

                try
                {
                    charCord = tempStringConvert[tempStringConvert.Length - 1];
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Error: RSA failed to create Gamma from this key, try other numbers");
                    break;
                }
                finally
                {
                    stringOut += charCord;
                    index++;
                }
            }
            PRSFinalOut = stringOut;
        }

        public string GetPRS()
        {
            return PRSFinalOut;
        }

        public void CheckPRS()
        {
            Console.Write("PSQ String: ");
            Console.WriteLine(GetPRS());

            List<Couple> nGramList = new List<Couple>();
            List<int> nGramListOut = new List<int>();
            int numZero = 0;
            int numOne = 0;
            int currentSize = 3;
            bool compareFlag = true;


            for (int i = 0; i < PRSFinalOut.Length; i++)
            {
                if (PRSFinalOut[i] == '0') { numZero++; }
                else if (PRSFinalOut[i] == '1') { numOne++; }
            }

            for (int i = 4; i <= 1023; i++)
            {
                nGramList.Add(new Couple(convert.Convert(10, i, 2), 0));
            }

            for (int i = 0; i < nGramList.Count; i++)
            {
                for (int j = 0; j < PRSFinalOut.Length - 9; j++)
                {
                    compareFlag = true;
                    for (int k = 0; k < nGramList[i]._stringValue.Length; k++)
                    {
                        if (nGramList[i]._stringValue[k] != PRSFinalOut[j + k])
                        {
                            compareFlag = false;
                            break;
                        }
                    }
                    if (compareFlag)
                    {
                        nGramList[i]._intValue += 1;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < nGramList.Count; i++)
            {
                if (currentSize == nGramList[i]._stringValue.Length)
                {
                    nGramListOut.Add(nGramList[i]._intValue);
                }
                else
                {
                    Console.Write($"{currentSize}: ");
                    for (int j = 0; j < nGramListOut.Count; j++)
                    {
                        Console.Write(nGramListOut[j]);
                        Console.Write(", ");
                    }
                    nGramListOut.Clear();
                    currentSize += 1;
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"Number of 0's: {numZero}");
            Console.WriteLine($"Number of 1's: {numOne}");
        }
    }

}
