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
    public partial class Medio : Form
    {
        public Medio()
        {
            InitializeComponent();
        }
        public void PuxarResposta()
        {
            string resposta = "SELECT resposta FROM resposta ";
            resposta += "WHERE id_resp = " + id_resp;
            DataSet resultado = _database.Search(resposta);
            resposta = resultado.Tables["tbl_resultado"].Rows[0]["resposta"].ToString();
            Btn_alternativa1.Text = resposta;
            id_resp++;
            resposta = "SELECT resposta FROM resposta ";
            resposta += "WHERE id_resp = " + id_resp;
            resultado = _database.Search(resposta);
            resposta = resultado.Tables["tbl_resultado"].Rows[0]["resposta"].ToString();
            Btn_alternativa2.Text = resposta;
            id_resp++;
            resposta = "SELECT resposta FROM resposta ";
            resposta += "WHERE id_resp = " + id_resp;
            resultado = _database.Search(resposta);
            resposta = resultado.Tables["tbl_resultado"].Rows[0]["resposta"].ToString();
            Btn_alternativa3.Text = resposta;
            id_resp++;
            resposta = "SELECT resposta FROM resposta ";
            resposta += "WHERE id_resp = " + id_resp;
            resultado = _database.Search(resposta);
            resposta = resultado.Tables["tbl_resultado"].Rows[0]["resposta"].ToString();
            Btn_alternativa4.Text = resposta;
            id_resp++;
        }

        public void PrepararPergunta(string Topico, int Categoria)
        {
            AtivarBotoes(false);
            Lbl_topico.Text = Topico;
            categoriaatual = Categoria;

            // PUXA A PERGUNTA DO BANCO DE DADOS
            string perg = "SELECT id_perg, pergunta FROM pergunta ";
            perg += "WHERE id_perg = (SELECT MIN(id_perg) FROM pergunta WHERE categoria = " + Categoria + ")";
            DataSet resultado = _database.Search(perg);
            id_pergatual = Convert.ToInt32(resultado.Tables["tbl_resultado"].Rows[0]["id_perg"]);
            string pergunta = resultado.Tables["tbl_resultado"].Rows[0]["pergunta"].ToString();
            Lbl_pergunta.Text = pergunta;

            // PUXA AS RESPOSTAS DO BANCO DE DADOS
            string resp = "SELECT id_resp FROM resposta ";
            resp += "WHERE fk_perg = (SELECT MIN(id_perg) FROM pergunta WHERE categoria = " + Categoria + ")";
            resultado = _database.Search(resp);
            resp = resultado.Tables["tbl_resultado"].Rows[0]["id_resp"].ToString();
            id_resp = Convert.ToInt32(resp);
            PuxarResposta();

            Pn_perguntas.Visible = true;
        }
        private void Proximo2_F2_Click(object sender, EventArgs e)
        {
        }

        private void proximo3_F2_Click(object sender, EventArgs e)
        {

        }

        private void Proximo4_F2_Click(object sender, EventArgs e)
        {


        }

        private void Proximo5_F2_Click(object sender, EventArgs e)
        {

        }

        private void Proximo6_F2_Click(object sender, EventArgs e)
        {

        }

        private void Proximo7_F2_Click(object sender, EventArgs e)
        {
        }



     

        private void FinalizarTema2_Click(object sender, EventArgs e)
        {
            temas tela_temas = new temas();
            this.Visible = false;
            tela_temas.ShowDialog();
            this.Visible = true;
        }

        private void Medio_Load(object sender, EventArgs e)
        {

        }
    }
}
