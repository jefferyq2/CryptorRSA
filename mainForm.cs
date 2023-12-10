using System.Windows.Forms;

namespace CryptorRSA {
    public partial class mainForm : Form {
        private string fileLocation;
        private string keyParametersString;
        private string finalMessage;

        public mainForm() {
            InitializeComponent();
        }

        private void FileDialogChoose(TextBox textBox) {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    textBox.Text = filePath;
                }
            }
        }

        private void FileDialogSave() {
            string finalMessageFilename = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    finalMessageFilename = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(finalMessageFilename, this.finalMessage);
                    MessageBox.Show("File saved");
                }
            }
        }

        private bool KeyCheck(string[] keyList) {
            if (keyList.Length == 5) {
                return true;
            }
            else {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void Encoder_Click(object sender, EventArgs e) { }

        private void Decoder_Click(object sender, EventArgs e) { }

        private void buttonFileLocarionSaveEncoder_Click(object sender, EventArgs e) {
            this.fileLocation = textBoxFileLocationEncoder.Text;
        }

        private void buttonFileLocationSaveDecoder_Click(object sender, EventArgs e) {
            this.fileLocation = textBoxFileLocationDecoder.Text;
        }

        private void button1_Click(object sender, EventArgs e) {
            FileDialogChoose(textBoxFileLocationEncoder);
        }

        private void buttonFileLocationDecoder_Click(object sender, EventArgs e) {
            FileDialogChoose(textBoxFileLocationDecoder);
        }

        private void buttonKeyParametersSaveEncoder_Click(object sender, EventArgs e) {
            string[] keyList = textBoxKeyParametersEncoder.Text.Split(' ');
            if (this.KeyCheck(keyList)) {
                keyParametersString = textBoxKeyParametersEncoder.Text;
            }
            else {
                MessageBox.Show("Wrong key type, try again");
            }
        }
        private void buttonKeyParametersSaveDecoder_Click(object sender, EventArgs e) {
            string[] keyList = textBoxKeyParametersDecoder.Text.Split(' ');
            if (this.KeyCheck(keyList)) {
                keyParametersString = textBoxKeyParametersDecoder.Text;
            }
            else {
                MessageBox.Show("Wrong key type, try again");
            }
        }

        private void StartButtonEncoder_Click(object sender, EventArgs e) {
            Encoder Encoder = new Encoder();

            string[] keyList = this.keyParametersString.Split(' ');

            Encoder.InputMessage(this.fileLocation);
            Encoder.InitializeParameters(int.Parse(keyList[0]), int.Parse(keyList[1]), int.Parse(keyList[2]), int.Parse(keyList[3]), keyList[4]);

            Encoder.PrintDictionary();
            Encoder.GetConvertedMessage();
            Encoder.GetGamma();

            Encoder.SetFinalMessage();

            this.finalMessage = Encoder.GetFinalMessage();
            MessageBox.Show(Encoder.GetFinalMessage());
        }

        private void buttonStartDecoder_Click(object sender, EventArgs e) {
            Decoder Decoder = new Decoder();

            string[] keyList = this.keyParametersString.Split(' ');

            Decoder.InputMessage(this.fileLocation);
            Decoder.InitializeParameters(int.Parse(keyList[0]), int.Parse(keyList[1]), int.Parse(keyList[2]), int.Parse(keyList[3]), keyList[4]);

            Decoder.PrintDictionary();
            Decoder.GetConvertedMessage();
            Decoder.GetGamma();

            Decoder.SetFinalMessage();

            MessageBox.Show(Decoder.GetFinalMessage());
        }

        

        private void buttonFinalMessageLocationSaveEncoder_Click(object sender, EventArgs e) {
            FileDialogSave();
        }

        private void buttonFinalMessageLocationSaveDecoder_Click(object sender, EventArgs e) {
            FileDialogSave();
        }
    }
}