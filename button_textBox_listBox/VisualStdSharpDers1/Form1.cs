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
            textBoxMesaj.Text = "Ders 1: GUI Tasar�m�";
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

        private void buttonOgrenci�simEkle_Click(object sender, EventArgs e)
        {
            comboBox�simler.Items.Add(textBoxMesaj.Text);
            listBoxDersler.Items.Add(textBoxMesaj.Text);
        }

        private void buttonLabelDe�i�tir_Click(object sender, EventArgs e)
        {
            labelYaz�lan�sim.Text = textBoxMesaj.Text;
        }
    }
}