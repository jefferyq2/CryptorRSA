using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptorRSA {
    public class Decoder : Cryptor {
        protected override RSAkeygen PRS { get; set; }
        protected override List<char> MessageInitial { get; set; } = new List<char>();
        protected override string MessageConverted { get; set; } = "";
        protected override string MessageCrypted { get; set; } = "";
        protected override int LetterBinarySize { get; set; } = 0;

        protected override void Cryption() {
            for (int i = 0; i < MessageInitial.Count; i++) {
                if ((MessageInitial[i] == '1' && PRS.GetPRS()[i] == '0') || (MessageInitial[i] == '0' && PRS.GetPRS()[i] == '1')) {
                    MessageCrypted += '1';
                }
                else {
                    MessageCrypted += '0';
                }
            }
        }

        protected override void Convert() {
            int index = 0;
            while (index <= MessageCrypted.Length - LetterBinarySize) {
                MessageConverted += FindLetter(index);
                index += LetterBinarySize;
            }
        }

        public override void Menu() {
            string stringPath = "";
            string key = "";
            List<string> keyList = new List<string>();

            Console.WriteLine("Введите путь к сообщению: ");
            stringPath = Console.ReadLine();

            Console.WriteLine("Введите ключ (четыре числа через пробел): ");
            key = Console.ReadLine();
            keyList.AddRange(key.Split(' '));

            InputMessage(stringPath);
            InitializeParameters(int.Parse(keyList[0]), int.Parse(keyList[1]), int.Parse(keyList[2]), int.Parse(keyList[3]), keyList[4]);
            Cryption();
            Convert();
        }

        public override string GetFinalMessage() {
            return MessageConverted;
        }

        public override void SetFinalMessage() {
            this.Cryption();
            this.Convert();
        }
    }
}