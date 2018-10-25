using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_quiz
{
    public partial class Avancado : Form
    {
        public Avancado()
        {
            InitializeComponent();
        }

        private void FinalizarTema3_Click(object sender, EventArgs e)
        {
            temas tela_temas = new temas();
            this.Visible = false;
            tela_temas.ShowDialog();
            this.Visible = true;
        }
    }
}
