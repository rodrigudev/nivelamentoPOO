using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleProject1
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
       
        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + "  Unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
