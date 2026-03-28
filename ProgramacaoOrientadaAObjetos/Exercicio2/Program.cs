using Exercicio2;

Console.WriteLine("## POO - Exercicio 2 ##\n");

LivroFotos livro1 = new LivroFotos();
LivroFotos livro2 = new LivroFotos(24);
SuperLivroFotos livroGrande = new SuperLivroFotos();

livro1.ExibirNumPaginas();
livro2.ExibirNumPaginas();
livroGrande.ExibirNumPaginas();

Console.ReadKey();
