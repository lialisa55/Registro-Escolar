using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Escolar
{
    class Pessoa
    {
        public string nome;
        public int idade;
    }

    class Aluno: Pessoa
    {
        public int nro_matricula;
        public string curso;

        public void exibir()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + nome + " Idade: " + idade + " Curso: " + curso + " Número de matrícula: " + nro_matricula);
        }
    }
    class Professor: Pessoa
    {
        public string disciplina;
        public int salario;
        public void exibir()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + nome + " Idade: " + idade + " Disciplina: " + disciplina + " Salário: " + salario);
        }
    }
}
