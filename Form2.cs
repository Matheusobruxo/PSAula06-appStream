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
    public partial class Form2 : Form
    {
        public string descricao, titulo ;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wvVideo.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbltitulo.Text = titulo;
            lblDescricao.Text = descricao;
        }
    }
}
