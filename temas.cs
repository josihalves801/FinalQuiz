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
    public partial class temas : Form
    {
        public temas()
        {
            InitializeComponent();
        }

        private void btn_facil_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form1 tela_facil = new Form1();
            this.Visible = false;
            tela_facil.ShowDialog();
            this.Visible = true;
        }

        private void btn_medio_Click(object sender, EventArgs e)
        {
            Medio tela_medio = new Medio();
            this.Visible = false;
            tela_medio.ShowDialog();
            this.Visible = true;
        }

        private void btn_avac_Click(object sender, EventArgs e)
        {
            Avancado tela_avancado = new Avancado();
            this.Visible = false;
            tela_avancado.ShowDialog();
            this.Visible = true;

        }
    }
}
