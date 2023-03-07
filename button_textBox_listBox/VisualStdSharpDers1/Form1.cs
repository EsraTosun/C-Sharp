namespace VisualStdSharpDers1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMesajGonder_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "Ders 1: GUI Tasarýmý";
        }

        private void textBoxMesaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMetniSil_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOgrenciÝsimEkle_Click(object sender, EventArgs e)
        {
            comboBoxÝsimler.Items.Add(textBoxMesaj.Text);
            listBoxDersler.Items.Add(textBoxMesaj.Text);
        }

        private void buttonLabelDeðiþtir_Click(object sender, EventArgs e)
        {
            labelYazýlanÝsim.Text = textBoxMesaj.Text;
        }
    }
}