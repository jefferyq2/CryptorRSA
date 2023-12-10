namespace CryptorRSA {
    partial class mainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tabControl1 = new TabControl();
            Encoder = new TabPage();
            buttonFinalMessageLocationSaveEncoder = new Button();
            buttonFileLocarionSaveEncoder = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            StartButtonEncoder = new Button();
            buttonKeyParametersSaveEncoder = new Button();
            textBoxFileLocationEncoder = new TextBox();
            buttonFileChoosingEncoder = new Button();
            textBoxKeyParametersEncoder = new TextBox();
            Decoder = new TabPage();
            buttonFinalMessageLocationSaveDecoder = new Button();
            buttonFileLocationSaveDecoder = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonStartDecoder = new Button();
            buttonKeyParametersSaveDecoder = new Button();
            textBoxFileLocationDecoder = new TextBox();
            buttonFileLocationDecoder = new Button();
            textBoxKeyParametersDecoder = new TextBox();
            tabControl1.SuspendLayout();
            Encoder.SuspendLayout();
            Decoder.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Encoder);
            tabControl1.Controls.Add(Decoder);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // Encoder
            // 
            Encoder.Controls.Add(buttonFinalMessageLocationSaveEncoder);
            Encoder.Controls.Add(buttonFileLocarionSaveEncoder);
            Encoder.Controls.Add(label3);
            Encoder.Controls.Add(label2);
            Encoder.Controls.Add(label1);
            Encoder.Controls.Add(StartButtonEncoder);
            Encoder.Controls.Add(buttonKeyParametersSaveEncoder);
            Encoder.Controls.Add(textBoxFileLocationEncoder);
            Encoder.Controls.Add(buttonFileChoosingEncoder);
            Encoder.Controls.Add(textBoxKeyParametersEncoder);
            Encoder.Location = new Point(4, 24);
            Encoder.Name = "Encoder";
            Encoder.Padding = new Padding(3);
            Encoder.Size = new Size(768, 398);
            Encoder.TabIndex = 0;
            Encoder.Text = "Encoder";
            Encoder.UseVisualStyleBackColor = true;
            Encoder.Click += Encoder_Click;
            // 
            // buttonFinalMessageLocationSaveEncoder
            // 
            buttonFinalMessageLocationSaveEncoder.Location = new Point(87, 369);
            buttonFinalMessageLocationSaveEncoder.Name = "buttonFinalMessageLocationSaveEncoder";
            buttonFinalMessageLocationSaveEncoder.Size = new Size(75, 23);
            buttonFinalMessageLocationSaveEncoder.TabIndex = 11;
            buttonFinalMessageLocationSaveEncoder.Text = "Save";
            buttonFinalMessageLocationSaveEncoder.UseVisualStyleBackColor = true;
            buttonFinalMessageLocationSaveEncoder.Click += buttonFinalMessageLocationSaveEncoder_Click;
            // 
            // buttonFileLocarionSaveEncoder
            // 
            buttonFileLocarionSaveEncoder.Location = new Point(6, 63);
            buttonFileLocarionSaveEncoder.Name = "buttonFileLocarionSaveEncoder";
            buttonFileLocarionSaveEncoder.Size = new Size(75, 23);
            buttonFileLocarionSaveEncoder.TabIndex = 8;
            buttonFileLocarionSaveEncoder.Text = "Save";
            buttonFileLocarionSaveEncoder.UseVisualStyleBackColor = true;
            buttonFileLocarionSaveEncoder.Click += buttonFileLocarionSaveEncoder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 146);
            label3.Name = "label3";
            label3.Size = new Size(175, 15);
            label3.TabIndex = 7;
            label3.Text = "Recommended: 273 623 7 10 RU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(281, 25);
            label2.TabIndex = 6;
            label2.Text = "Fill this box with key parameters";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(307, 25);
            label1.TabIndex = 5;
            label1.Text = "Fill this box with your file's location";
            // 
            // StartButtonEncoder
            // 
            StartButtonEncoder.Location = new Point(6, 369);
            StartButtonEncoder.Name = "StartButtonEncoder";
            StartButtonEncoder.Size = new Size(75, 23);
            StartButtonEncoder.TabIndex = 4;
            StartButtonEncoder.Text = "Start";
            StartButtonEncoder.UseVisualStyleBackColor = true;
            StartButtonEncoder.Click += StartButtonEncoder_Click;
            // 
            // buttonKeyParametersSaveEncoder
            // 
            buttonKeyParametersSaveEncoder.Location = new Point(6, 172);
            buttonKeyParametersSaveEncoder.Name = "buttonKeyParametersSaveEncoder";
            buttonKeyParametersSaveEncoder.Size = new Size(75, 23);
            buttonKeyParametersSaveEncoder.TabIndex = 3;
            buttonKeyParametersSaveEncoder.Text = "Save";
            buttonKeyParametersSaveEncoder.UseVisualStyleBackColor = true;
            buttonKeyParametersSaveEncoder.Click += buttonKeyParametersSaveEncoder_Click;
            // 
            // textBoxFileLocationEncoder
            // 
            textBoxFileLocationEncoder.Location = new Point(6, 34);
            textBoxFileLocationEncoder.Name = "textBoxFileLocationEncoder";
            textBoxFileLocationEncoder.Size = new Size(378, 23);
            textBoxFileLocationEncoder.TabIndex = 2;
            // 
            // buttonFileChoosingEncoder
            // 
            buttonFileChoosingEncoder.Location = new Point(390, 34);
            buttonFileChoosingEncoder.Name = "buttonFileChoosingEncoder";
            buttonFileChoosingEncoder.Size = new Size(20, 23);
            buttonFileChoosingEncoder.TabIndex = 1;
            buttonFileChoosingEncoder.Text = "Click to choose a file";
            buttonFileChoosingEncoder.UseVisualStyleBackColor = true;
            buttonFileChoosingEncoder.Click += button1_Click;
            // 
            // textBoxKeyParametersEncoder
            // 
            textBoxKeyParametersEncoder.Location = new Point(6, 143);
            textBoxKeyParametersEncoder.Name = "textBoxKeyParametersEncoder";
            textBoxKeyParametersEncoder.Size = new Size(378, 23);
            textBoxKeyParametersEncoder.TabIndex = 0;
            // 
            // Decoder
            // 
            Decoder.Controls.Add(buttonFinalMessageLocationSaveDecoder);
            Decoder.Controls.Add(buttonFileLocationSaveDecoder);
            Decoder.Controls.Add(label4);
            Decoder.Controls.Add(label5);
            Decoder.Controls.Add(label6);
            Decoder.Controls.Add(buttonStartDecoder);
            Decoder.Controls.Add(buttonKeyParametersSaveDecoder);
            Decoder.Controls.Add(textBoxFileLocationDecoder);
            Decoder.Controls.Add(buttonFileLocationDecoder);
            Decoder.Controls.Add(textBoxKeyParametersDecoder);
            Decoder.Location = new Point(4, 24);
            Decoder.Name = "Decoder";
            Decoder.Padding = new Padding(3);
            Decoder.Size = new Size(768, 398);
            Decoder.TabIndex = 1;
            Decoder.Text = "Decoder";
            Decoder.UseVisualStyleBackColor = true;
            Decoder.Click += Decoder_Click;
            // 
            // buttonFinalMessageLocationSaveDecoder
            // 
            buttonFinalMessageLocationSaveDecoder.Location = new Point(87, 369);
            buttonFinalMessageLocationSaveDecoder.Name = "buttonFinalMessageLocationSaveDecoder";
            buttonFinalMessageLocationSaveDecoder.Size = new Size(75, 23);
            buttonFinalMessageLocationSaveDecoder.TabIndex = 18;
            buttonFinalMessageLocationSaveDecoder.Text = "Save";
            buttonFinalMessageLocationSaveDecoder.UseVisualStyleBackColor = true;
            buttonFinalMessageLocationSaveDecoder.Click += buttonFinalMessageLocationSaveDecoder_Click;
            // 
            // buttonFileLocationSaveDecoder
            // 
            buttonFileLocationSaveDecoder.Location = new Point(6, 63);
            buttonFileLocationSaveDecoder.Name = "buttonFileLocationSaveDecoder";
            buttonFileLocationSaveDecoder.Size = new Size(75, 23);
            buttonFileLocationSaveDecoder.TabIndex = 17;
            buttonFileLocationSaveDecoder.Text = "Save";
            buttonFileLocationSaveDecoder.UseVisualStyleBackColor = true;
            buttonFileLocationSaveDecoder.Click += buttonFileLocationSaveDecoder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 146);
            label4.Name = "label4";
            label4.Size = new Size(175, 15);
            label4.TabIndex = 16;
            label4.Text = "Recommended: 273 623 7 10 RU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 115);
            label5.Name = "label5";
            label5.Size = new Size(281, 25);
            label5.TabIndex = 15;
            label5.Text = "Fill this box with key parameters";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(307, 25);
            label6.TabIndex = 14;
            label6.Text = "Fill this box with your file's location";
            // 
            // buttonStartDecoder
            // 
            buttonStartDecoder.Location = new Point(6, 369);
            buttonStartDecoder.Name = "buttonStartDecoder";
            buttonStartDecoder.Size = new Size(75, 23);
            buttonStartDecoder.TabIndex = 13;
            buttonStartDecoder.Text = "Start";
            buttonStartDecoder.UseVisualStyleBackColor = true;
            buttonStartDecoder.Click += buttonStartDecoder_Click;
            // 
            // buttonKeyParametersSaveDecoder
            // 
            buttonKeyParametersSaveDecoder.Location = new Point(6, 172);
            buttonKeyParametersSaveDecoder.Name = "buttonKeyParametersSaveDecoder";
            buttonKeyParametersSaveDecoder.Size = new Size(75, 23);
            buttonKeyParametersSaveDecoder.TabIndex = 12;
            buttonKeyParametersSaveDecoder.Text = "Save";
            buttonKeyParametersSaveDecoder.UseVisualStyleBackColor = true;
            buttonKeyParametersSaveDecoder.Click += buttonKeyParametersSaveDecoder_Click;
            // 
            // textBoxFileLocationDecoder
            // 
            textBoxFileLocationDecoder.Location = new Point(6, 34);
            textBoxFileLocationDecoder.Name = "textBoxFileLocationDecoder";
            textBoxFileLocationDecoder.Size = new Size(378, 23);
            textBoxFileLocationDecoder.TabIndex = 11;
            // 
            // buttonFileLocationDecoder
            // 
            buttonFileLocationDecoder.Location = new Point(390, 34);
            buttonFileLocationDecoder.Name = "buttonFileLocationDecoder";
            buttonFileLocationDecoder.Size = new Size(20, 23);
            buttonFileLocationDecoder.TabIndex = 10;
            buttonFileLocationDecoder.Text = "Click to choose a file";
            buttonFileLocationDecoder.UseVisualStyleBackColor = true;
            buttonFileLocationDecoder.Click += buttonFileLocationDecoder_Click;
            // 
            // textBoxKeyParametersDecoder
            // 
            textBoxKeyParametersDecoder.Location = new Point(6, 143);
            textBoxKeyParametersDecoder.Name = "textBoxKeyParametersDecoder";
            textBoxKeyParametersDecoder.Size = new Size(378, 23);
            textBoxKeyParametersDecoder.TabIndex = 9;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 450);
            Controls.Add(tabControl1);
            Name = "mainForm";
            Text = "RSAcryptor";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            Encoder.ResumeLayout(false);
            Encoder.PerformLayout();
            Decoder.ResumeLayout(false);
            Decoder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Encoder;
        private TabPage Decoder;
        private TextBox textBoxKeyParametersEncoder;
        private Button buttonFileChoosingEncoder;
        private TextBox textBoxFileLocationEncoder;
        private Button buttonKeyParametersSaveEncoder;
        private Button StartButtonEncoder;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonFileLocarionSaveEncoder;
        private Button buttonFileLocationSaveDecoder;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonStartDecoder;
        private Button buttonKeyParametersSaveDecoder;
        private TextBox textBoxFileLocationDecoder;
        private Button buttonFileLocationDecoder;
        private TextBox textBoxKeyParametersDecoder;
        private Button buttonFinalMessageLocationSaveEncoder;
        private Button buttonFinalMessageLocationSaveDecoder;
    }
}