using System.Globalization;
using ConsoleProject1;

Produto p = new Produto();

Console.WriteLine("Entre com os dados do produto");
Console.Write("nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do Produto: " + p);
