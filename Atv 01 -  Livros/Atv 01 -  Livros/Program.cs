
using Atv_01____Livros;

Livros livro1 = new Livros("O Diário de Anne Frank", "Anne Frank", "BestBolso", 1947);
Console.WriteLine("O nome do seu livro é: " + livro1.Titulo + "\nA autora do seu livro é: " + livro1.Autor + "\nA editora do seu livro é: " + livro1.Editora + "\nO ano de lançamento do seu livro é: " + livro1.Ano);

Livros livro2 = new Livros("A culpa é das estrelas", "John Green", "Intrínseca", 2012);
Console.WriteLine("\nO nome do seu livro é: " + livro2.Titulo + "\nA autora do seu livro é: " + livro2.Autor + "\nA editora do seu livro é: " + livro2.Editora + "\nO ano de lançamento do seu livro é: " + livro2.Ano);

Livros livro3 = new Livros("Heartstopper", "Alice Oseman", "Seguinte", 2021);
Console.WriteLine("\nO nome do seu livro é: " + livro3.Titulo + "\nA autora do seu livro é: " + livro3.Autor + "\nA editora do seu livro é: " + livro3.Editora + "\nO ano de lançamento do seu livro é: " + livro3.Ano);

