using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAula06_AppStreaming
{

    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string titulo = "Breaking Bad";
            string descricao = "    Velho drogado que vende droga pra dar a condição pra familia, mas acaba morrendo no processo";
            Form2 telaDescricao = new Form2();

            telaDescricao.descricao = descricao;
            telaDescricao.titulo = titulo;
            telaDescricao.Show();

        }

        private void lblSerie2_Click(object sender, EventArgs e)
        {
            string titulo = "How to sell drugs online (fast)";
            string descricao = "Garoto nerd gado vai atrás de vender droga pra impressionar mulher, mais um curioso caso do topa tudo por buceta!";

            Form2 telaDescricao = new Form2();
            telaDescricao.descricao = descricao;
            telaDescricao.titulo = titulo;
            telaDescricao.Show();

        }

        private void lblSerie3_Click(object sender, EventArgs e)
        {
            string titulo = "Pelé";
            string descricao = "Era melhor ter ido ver o filme do pelé!";

            Form2 telaDescricao = new Form2();
            telaDescricao.descricao = descricao;
            telaDescricao.titulo = titulo;
            telaDescricao.Show();
        }
    }
}
