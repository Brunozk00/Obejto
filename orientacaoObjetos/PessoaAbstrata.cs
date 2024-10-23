using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoObjetos
{
    public abstract class PessoaAbstrata
    {
        //Propriedades privadas
        private string _nome;
        private int _idade;

        //Propriedades public
        public string Nome
        {
            get { return _nome.ToUpper(); }
            set { _nome = value; }
        }
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }

        }

        //Construtor
        public PessoaAbstrata (string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        //vitural => Permitindo que esse método seja sobrescrito


        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome {Nome}, Idade, {Idade} anos");
        }
    }
}
