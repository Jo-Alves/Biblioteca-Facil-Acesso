using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_livros
{
    abstract class Livros
    {
        //atributos da classe
        private int Registro;
        private string Autor;

        public int registro
        {
            get { return Registro; }
            set { Registro = value; }
        }
        public string autor
        {
            get { return Autor; }
            set { Autor = value; }
        }
      
      
        public abstract bool Cadastrar();
        public abstract bool Alterar();
        public abstract bool Deletar();
    }
}
