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
    public partial class Form1 : Form
    {
        




        public Form1()
        {
         


            InitializeComponent();
          

            label2.Text = "0";
            Pergunta Pergunta1 =
            new Pergunta(
            "(USP) A preocupação em isolar a França e obter o maior número possível de aliados caracterizou a política de um chefe de governo europeu no período de 1871 e 1890. Estamos no referindo a:",
            "Lloyd George",
            "Bismarck", // certa
            "Guilherme II",
            "Cavour");

            label1.Text = Pergunta1.Desc;
            radioButton1.Text = Pergunta1.AltA;
            radioButton2.Text = Pergunta1.AltB;
            radioButton3.Text = Pergunta1.AltC;
            radioButton4.Text = Pergunta1.AltD;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       


       
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
      
      

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        

    private void FinalizarTema1_Click(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

        private void Proximo2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
            }
            Pergunta Pergunta2 =
           new Pergunta(
           "(OSEC) Presidente dos Estados Unidos durante a Guerra de 1914 - 1918:",
           "Franklin Roosevelt",
            "Churchill",
           "Wilson", //certa
           "Theodore Roosevelt");
            label1.Text = Pergunta2.Desc;
            radioButton1.Text = Pergunta2.AltA;
            radioButton2.Text = Pergunta2.AltB;
            radioButton3.Text = Pergunta2.AltC;
            radioButton4.Text = Pergunta2.AltD;
            Proximo2.Visible = false;
            Proximo3.Visible = true;

        }
        private void Proximo3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
            }
            Pergunta Pergunta3 =
            new Pergunta(
            "(USP) O assassinato do herdeiro do Império Austro-Húngaro em Sarajevo veio complicar a situação européia e ocasionou a eclosão da I Guerra Mundial. O personagem em questão era:",
            "O Kaiser Guilherme",
            "Francisco Fernando", // certa
            "Floyd George",
            "Nicolau Romanov");
            label1.Text = Pergunta3.Desc;
            radioButton1.Text = Pergunta3.AltA;
            radioButton2.Text = Pergunta3.AltB;
            radioButton3.Text = Pergunta3.AltC;
            radioButton4.Text = Pergunta3.AltD;
            Proximo3.Visible = false;
            Proximo4.Visible = true;

        }
        private void Proximo4_Click_1(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
            }
            Pergunta Pergunta4 =
            new Pergunta(
            "(PUC) O fim da I Guerra Mundial trouxe, entre outras conseqüências:",
            "A unificação política do Oriente Médio, sob a liderança do Egito.",
            "A dominação da Alemanha pelas forças de ocupação aliadas.",
            "A ampliação do território alemão, em detrimento com a Polônia.",
            "O aparecimento de numerosos novos Estados, em virtude da desintegração dos Impérios Otomano, Austro- Húngaro e Russo"); // certa
            label1.Text = Pergunta4.Desc;
            radioButton1.Text = Pergunta4.AltA;
            radioButton2.Text = Pergunta4.AltB;
            radioButton3.Text = Pergunta4.AltC;
            radioButton4.Text = Pergunta4.AltD;
            Proximo4.Visible = false;
            Proximo5.Visible = true;
        }

        private void Proximo5_Click_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
            }
            Pergunta Pergunta5 =
            new Pergunta(
            "Qual dos itens abaixo NÃO está ligado à 1ª Guerra Mundial enquanto causa?",
            "O Tratado de Frankfurt",
            "A crescente procura de mercados e matérias-primas",
            "A política agressiva de Bismarck.", // certa
            "A Crise Balcânica.");
            label1.Text = Pergunta5.Desc;
            radioButton1.Text = Pergunta5.AltA;
            radioButton2.Text = Pergunta5.AltB;
            radioButton3.Text = Pergunta5.AltC;
            radioButton4.Text = Pergunta5.AltD;
            Proximo5.Visible = false;
            Proximo6.Visible = true;

        }

        private void Proximo6_Click_1(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
            }
            Pergunta Pergunta6 =
            new Pergunta(
            "A Primeira Guerra Mundial foi centrada em qual continente?",
            "Europa", //certa
            "América do Sul",
            "América do Norte",
            "Ásia");
            label1.Text = Pergunta6.Desc;
            radioButton1.Text = Pergunta6.AltA;
            radioButton2.Text = Pergunta6.AltB;
            radioButton3.Text = Pergunta6.AltC;
            radioButton4.Text = Pergunta6.AltD;
            Proximo6.Visible = false;
            Proximo7.Visible = true;
        }

        private void Proximo7_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 10);
            }
            Pergunta Pergunta7 =
            new Pergunta(
            "Qual foi o primeiro conflito da Primeira Guerra Mundial?",
            "Guerra dos sete anos",
            "Invasão franco-canadense à Alemanha",
            "A Guerra dos sete dias",
            "Invasão austro-húngara à Sérvia"); //certa
            label1.Text = Pergunta7.Desc;
            radioButton1.Text = Pergunta7.AltA;
            radioButton2.Text = Pergunta7.AltB;
            radioButton3.Text = Pergunta7.AltC;
            radioButton4.Text = Pergunta7.AltD;
            Proximo7.Visible = false;
            FinalizarTema1.Visible = true;

        }

        private void FinalizarTema1_Click_1(object sender, EventArgs e)
        {
            temas tela_temas = new temas();
            this.Visible = false;
            tela_temas.ShowDialog();
            this.Visible = true;
        }
    }
}
    
