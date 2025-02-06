using System.Globalization;
using ConsoleProject1;

Console.WriteLine("Entre com os dados do produto");
Console.Write("nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto(nome, preco, quantidade);

Console.WriteLine();
Console.WriteLine("Dados do Produto: " + p);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int quantidadeAdd = int.Parse(Console.ReadLine());
p.AdicionarProdutos(quantidadeAdd);

Console.WriteLine();
Console.WriteLine("Dados do Produto: " + p);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser removido do estoque: ");
int quantidadeRemove = int.Parse(Console.ReadLine());
p.RemoverProdutos(quantidadeRemove);

Console.WriteLine();
Console.WriteLine("Dados do Produto: " + p);
