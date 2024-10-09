using Atv_03___Produto;

Produtos produto1 = new Produtos(65498, "Balinhas Fini", 7.99, 315);
Console.WriteLine("O código do produto é:" + produto1.Codigo + "\nO nome do produto é: " + produto1.Nome + "\nO preço do produto é: " + produto1.Preco + "\nA quantidade no estoque é: " + produto1.Estoque);
produto1.ValorEstoque();

Produtos produto2 = new Produtos(83354, "Salgadinho Cheetos", 14.98, 214);
Console.WriteLine("\nO código do produto é:" + produto2.Codigo + "\nO nome do produto é: " + produto2.Nome + "\nO preço do produto é: " + produto2.Preco + "\nA quantidade no estoque é: " + produto2.Estoque);
produto2.ValorEstoque();

Produtos produto3 = new Produtos(09832, "Nutella", 21.99, 100);
Console.WriteLine("\nO código do produto é:" + produto3.Codigo + "\nO nome do produto é: " + produto3.Nome + "\nO preço do produto é: " + produto3.Preco + "\nA quantidade no estoque é: " + produto3.Estoque);
produto3.ValorEstoque();