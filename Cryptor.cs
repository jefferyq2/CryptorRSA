using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptorRSA {
    public abstract class Cryptor {
        protected abstract RSAkeygen PRS { get; set; }
        protected abstract List<char> MessageInitial { get; set; } // Original message
        protected char[] AlphabetRussian = { ' ', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        protected char[] AlphabetEnglish = { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        protected char[] Alphabet;
        protected BinaryConvert BinaryConvert = new BinaryConvert();
        protected abstract string MessageConverted { get; set; } // Message converted to binary state
        protected abstract string MessageCrypted { get; set; } // Final message
        protected abstract int LetterBinarySize { get; set; } // Max size of binary value of letter in alphabet, used for dictionary filling

        protected List<CoupleString> LettersDictionary = new List<CoupleString>();

        protected char FindLetter(int index) {
            string substringLetter = MessageCrypted.Substring(index, LetterBinarySize);
            char finalLetter = ' ';
            foreach (var couple in LettersDictionary) {
                if (substringLetter == couple._binaryValue) {
                    finalLetter = couple._letterChar;
                    return finalLetter;
                }
                else {
                    finalLetter = ' ';
                }
            }
            return finalLetter;
        }

        protected string FillLeft(string text, int length) {
            string stringOut = "";
            for (int i = 0; i < length - text.Length; i++) {
                stringOut += "0";
            }
            stringOut += text;
            return stringOut;
        }

        protected void ReplaceLetters() {
            for (int i = 0; i < MessageInitial.Count; i++) {
                if (MessageInitial[i] == 'Й') {
                    MessageInitial[i] = 'И';
                }
            }
        }

        protected void SetLetterBinarySize() {
            foreach (var letter in Alphabet) {
                LetterBinarySize = BinaryConvert.Convert(10, Array.IndexOf(Alphabet, letter), 2).Length;
            }
        }

        public void InitializeParameters(int numP, int numQ, int numE, int firstNumber, string language) {
            string binaryValueOut = "";
            string binaryValueTemp = "";

            switch (language) // Defining of what language will be used for message
            {
                case "RU":
                    Alphabet = AlphabetRussian;
                    break;
                case "EN":
                    Alphabet = AlphabetEnglish;
                    break;
            }

            SetLetterBinarySize();
            PRS = new RSAkeygen(numP, numQ, numE, firstNumber, MessageInitial.Count * LetterBinarySize);
            PRS.CreateNextNumber();

            for (int i = 0; i < Alphabet.Length; i++) {
                binaryValueTemp = BinaryConvert.Convert(10, i, 2);
                binaryValueOut = FillLeft(binaryValueTemp, LetterBinarySize);
                LettersDictionary.Add(new CoupleString(Alphabet[i], binaryValueOut));
            }
        }

        public void InputMessage(string path) {
            string[] lines = File.ReadAllLines(path);
            string tempMessage = "";

            foreach (var line in lines) {
                tempMessage += line;
            }

            foreach (char character in tempMessage) {
                MessageInitial.Add(character);
            }
        }

        protected abstract void Convert();
        protected abstract void Cryption();

        public void PrintDictionary() {
            foreach (var couple in LettersDictionary) {
                Console.WriteLine();
                Console.Write(couple._letterChar);
                Console.Write(" ");
                Console.Write(couple._binaryValue);
            }
            Console.WriteLine();
        }

        public virtual void Menu() {
            string stringPath;
            string key;
            List<string> keyList = new List<string>();

            Console.WriteLine("Введите путь к сообщению: ");
            stringPath = Console.ReadLine();

            Console.WriteLine("Введите ключ (четыре числа через пробел): ");
            key = Console.ReadLine();
            keyList.AddRange(key.Split(' '));

            InputMessage(stringPath);
            InitializeParameters(int.Parse(keyList[0]), int.Parse(keyList[1]), int.Parse(keyList[2]), int.Parse(keyList[3]), keyList[4]);
            Convert();
            Cryption();
        }

        public abstract void SetFinalMessage();

        public virtual string GetFinalMessage() {
            return MessageCrypted;
        }

        public string GetConvertedMessage() {
            return MessageConverted;
        }

        public string GetGamma() {
            return PRS.GetPRS();
        }
    }
}
