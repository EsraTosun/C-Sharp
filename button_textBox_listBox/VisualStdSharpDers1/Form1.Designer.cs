namespace VisualStdSharpDers1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonMesajGonder = new Button();
            textBoxMesaj = new TextBox();
            buttonMetniSil = new Button();
            comboBoxİsimler = new ComboBox();
            buttonOgrenciİsimEkle = new Button();
            labelYazılanİsim = new Label();
            buttonLabelDeğiştir = new Button();
            listBoxDersler = new ListBox();
            SuspendLayout();
            // 
            // buttonMesajGonder
            // 
            buttonMesajGonder.ForeColor = SystemColors.ActiveCaptionText;
            buttonMesajGonder.Location = new Point(37, 37);
            buttonMesajGonder.Name = "buttonMesajGonder";
            buttonMesajGonder.Size = new Size(112, 34);
            buttonMesajGonder.TabIndex = 0;
            buttonMesajGonder.Text = "Mesaj Yaz";
            buttonMesajGonder.UseVisualStyleBackColor = true;
            buttonMesajGonder.Click += buttonMesajGonder_Click;
            // 
            // textBoxMesaj
            // 
            textBoxMesaj.BackColor = SystemColors.HotTrack;
            textBoxMesaj.Location = new Point(178, 70);
            textBoxMesaj.Name = "textBoxMesaj";
            textBoxMesaj.Size = new Size(439, 31);
            textBoxMesaj.TabIndex = 1;
            textBoxMesaj.TextChanged += textBoxMesaj_TextChanged;
            // 
            // buttonMetniSil
            // 
            buttonMetniSil.Location = new Point(37, 101);
            buttonMetniSil.Name = "buttonMetniSil";
            buttonMetniSil.Size = new Size(112, 40);
            buttonMetniSil.TabIndex = 2;
            buttonMetniSil.Text = "Metni Sil";
            buttonMetniSil.UseVisualStyleBackColor = true;
            buttonMetniSil.Click += buttonMetniSil_Click;
            // 
            // comboBoxİsimler
            // 
            comboBoxİsimler.FormattingEnabled = true;
            comboBoxİsimler.Items.AddRange(new object[] { "Ali Deniz", "Veli Dursun", "Ayşe", "Zeki", "Anıl" });
            comboBoxİsimler.Location = new Point(178, 244);
            comboBoxİsimler.Name = "comboBoxİsimler";
            comboBoxİsimler.Size = new Size(324, 33);
            comboBoxİsimler.TabIndex = 3;
            comboBoxİsimler.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonOgrenciİsimEkle
            // 
            buttonOgrenciİsimEkle.ForeColor = SystemColors.ActiveCaptionText;
            buttonOgrenciİsimEkle.Location = new Point(244, 134);
            buttonOgrenciİsimEkle.Name = "buttonOgrenciİsimEkle";
            buttonOgrenciİsimEkle.Size = new Size(225, 34);
            buttonOgrenciİsimEkle.TabIndex = 4;
            buttonOgrenciİsimEkle.Text = "İsmi Comboya Ekle";
            buttonOgrenciİsimEkle.UseVisualStyleBackColor = true;
            buttonOgrenciİsimEkle.Click += buttonOgrenciİsimEkle_Click;
            // 
            // labelYazılanİsim
            // 
            labelYazılanİsim.AutoSize = true;
            labelYazılanİsim.BackColor = Color.Red;
            labelYazılanİsim.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelYazılanİsim.Location = new Point(600, 171);
            labelYazılanİsim.Name = "labelYazılanİsim";
            labelYazılanİsim.Size = new Size(70, 23);
            labelYazılanİsim.TabIndex = 5;
            labelYazılanİsim.Text = "label1";
            // 
            // buttonLabelDeğiştir
            // 
            buttonLabelDeğiştir.ForeColor = SystemColors.ActiveCaptionText;
            buttonLabelDeğiştir.Location = new Point(574, 223);
            buttonLabelDeğiştir.Name = "buttonLabelDeğiştir";
            buttonLabelDeğiştir.Size = new Size(198, 34);
            buttonLabelDeğiştir.TabIndex = 6;
            buttonLabelDeğiştir.Text = "Label Değiştir";
            buttonLabelDeğiştir.UseVisualStyleBackColor = true;
            buttonLabelDeğiştir.Click += buttonLabelDeğiştir_Click;
            // 
            // listBoxDersler
            // 
            listBoxDersler.FormattingEnabled = true;
            listBoxDersler.ItemHeight = 25;
            listBoxDersler.Items.AddRange(new object[] { "Matematik", "Fizik", "Kimya", "Türkçe" });
            listBoxDersler.Location = new Point(574, 279);
            listBoxDersler.Name = "listBoxDersler";
            listBoxDersler.Size = new Size(180, 129);
            listBoxDersler.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxDersler);
            Controls.Add(buttonLabelDeğiştir);
            Controls.Add(labelYazılanİsim);
            Controls.Add(buttonOgrenciİsimEkle);
            Controls.Add(comboBoxİsimler);
            Controls.Add(buttonMetniSil);
            Controls.Add(textBoxMesaj);
            Controls.Add(buttonMesajGonder);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMesajGonder;
        private TextBox textBoxMesaj;
        private Button buttonMetniSil;
        private ComboBox comboBoxİsimler;
        private Button buttonOgrenciİsimEkle;
        private Label labelYazılanİsim;
        private Button buttonLabelDeğiştir;
        private ListBox listBoxDersler;
    }
}