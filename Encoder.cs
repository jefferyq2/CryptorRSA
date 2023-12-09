using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptorRSA {
    public class Encoder : Cryptor {
        protected override RSAkeygen PRS { get; set; }
        protected override List<char> MessageInitial { get; set; } = new List<char>();
        protected override string MessageConverted { get; set; } = "";
        protected override string MessageCrypted { get; set; } = "";
        protected override int LetterBinarySize { get; set; } = 0;

        protected override void Convert() {
            ReplaceLetters();
            for (int i = 0; i < MessageInitial.Count; i++) {
                for (int j = 0; j < LettersDictionary.Count; j++) {
                    if (MessageInitial[i] == LettersDictionary[j]._letterChar) {
                        MessageConverted += LettersDictionary[j]._binaryValue;
                        break;
                    }
                }
            }
        }

        protected override void Cryption() {
            int messageConvertedLength = MessageConverted.Length;
            int messageInitialLength = MessageInitial.Count;
            int messageToCryptLength = MessageInitial.Count * 5;
            int gammaLength = PRS.GetPRS().Length;

            for (int i = 0; i < MessageConverted.Length; i++) {
                if ((PRS.GetPRS()[i] == '0' && MessageConverted[i] == '1') || (PRS.GetPRS()[i] == '1' && MessageConverted[i] == '0')) {
                    MessageCrypted += '1';
                }
                else {
                    MessageCrypted += '0';
                }
            }
        }

        public override void SetFinalMessage() {
            this.Convert();
            this.Cryption();
        }
    }
}
