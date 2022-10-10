using System.Security.Cryptography.X509Certificates;

namespace WinformSplash
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            SystemTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void opcion1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAcuerdo fa = new FormAcuerdo();
            fa.Owner = this;
            fa.ShowDialog();
        }

        private void opcion3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        pictureBox1.Image = ListaImagenes.Images[0];
                        break;
                    case 1:
                        pictureBox1.Image = ListaImagenes.Images[1];
                        break;
                    case 2:
                        pictureBox1.Image = ListaImagenes.Images[2];
                        break;
                    case 3:
                        pictureBox1.Image = ListaImagenes.Images[3];
                        break;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);   
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SystemTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String textoDestino = "";
            if (listBox1 != null) {
                switch (listBox1.SelectedIndex) {
                    case 0:
                        textoDestino = "";
                        break;
                    case 1:
                        textoDestino = "";
                        break;
                    case 2:
                        textoDestino = "";
                        break;
                    case 3:
                        textoDestino = "";
                        break;
                }
            }
            CuadroTexto.Text = textoDestino + System.Environment.NewLine;

        }
    }
}