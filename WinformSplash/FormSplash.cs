using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformSplash
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();
            FormPrincipal Form1 = new FormPrincipal();
            Form1.Show();
            this.Hide();

        }

        private void FormSplash_Shown(object sender, EventArgs e)
        {
            Temporizador.Start();
        }
    }
}
