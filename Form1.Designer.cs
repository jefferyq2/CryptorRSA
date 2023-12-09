namespace CryptorRSA {
    partial class Form1 {
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
            StartButtonEncoder = new Button();
            buttonKeyParametersSaveEncoder = new Button();
            textBoxFileLocationEncoder = new TextBox();
            buttonFileChoosingEncoder = new Button();
            textBoxKeyParametersEncoder = new TextBox();
            Decoder = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            Encoder.SuspendLayout();
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
            // StartButtonEncoder
            // 
            StartButtonEncoder.Location = new Point(6, 369);
            StartButtonEncoder.Name = "StartButtonEncoder";
            StartButtonEncoder.Size = new Size(147, 23);
            StartButtonEncoder.TabIndex = 4;
            StartButtonEncoder.Text = "Start";
            StartButtonEncoder.UseVisualStyleBackColor = true;
            StartButtonEncoder.Click += StartButtonEncoder_Click;
            // 
            // buttonKeyParametersSaveEncoder
            // 
            buttonKeyParametersSaveEncoder.Location = new Point(6, 172);
            buttonKeyParametersSaveEncoder.Name = "buttonKeyParametersSaveEncoder";
            buttonKeyParametersSaveEncoder.Size = new Size(147, 23);
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
            buttonFileChoosingEncoder.Location = new Point(6, 63);
            buttonFileChoosingEncoder.Name = "buttonFileChoosingEncoder";
            buttonFileChoosingEncoder.Size = new Size(147, 23);
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
            Decoder.Location = new Point(4, 24);
            Decoder.Name = "Decoder";
            Decoder.Padding = new Padding(3);
            Decoder.Size = new Size(768, 398);
            Decoder.TabIndex = 1;
            Decoder.Text = "Decoder";
            Decoder.UseVisualStyleBackColor = true;
            Decoder.Click += Decoder_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 146);
            label3.Name = "label3";
            label3.Size = new Size(175, 15);
            label3.TabIndex = 7;
            label3.Text = "Recommended: 273 623 7 10 RU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "RSAcryptor";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            Encoder.ResumeLayout(false);
            Encoder.PerformLayout();
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
    }
}