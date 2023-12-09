namespace CryptorRSA {
    public partial class Form1 : Form {
        private string fileLocation;
        private string keyParametersString;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Encoder_Click(object sender, EventArgs e) {

        }

        private void Decoder_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    fileLocation = filePath;
                    textBoxFileLocationEncoder.Text = fileLocation;
                }
            }
        }

        private void buttonKeyParametersSaveEncoder_Click(object sender, EventArgs e) {
            keyParametersString = textBoxKeyParametersEncoder.Text;
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

            MessageBox.Show(Encoder.GetFinalMessage());
        }
    }
}