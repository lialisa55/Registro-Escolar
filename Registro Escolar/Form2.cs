using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Escolar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno objAluno = new Aluno();

            objAluno.nome = nomeIn.Text;
            objAluno.idade = Convert.ToInt32(idadeIn.Text);
            objAluno.nro_matricula = Convert.ToInt32(matriculaIn.Text);
            objAluno.curso = cursoIn.Text;
            objAluno.exibir();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
