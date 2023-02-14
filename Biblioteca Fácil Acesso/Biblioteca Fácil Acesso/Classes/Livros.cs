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
        private string DataRegistro;
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
      
        public string dataRegistro
        {
            get { return DataRegistro; }
            set { DataRegistro = value; }
        }
      
        public abstract bool Cadastrar();
        public abstract bool Atualizar();
        public abstract bool Deletar();
    }
}
