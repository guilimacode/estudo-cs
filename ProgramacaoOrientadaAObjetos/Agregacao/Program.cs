using Agregacao;

Console.WriteLine("## Agregação ##\n");

//Partes existem sem o todo

Professor prof1 = new Professor("Francis", "Química");
Professor prof2 = new Professor("Renato", "Matemática");
Professor prof3 = new Professor("Leandro", "Geografia");
Professor prof4 = new Professor("Andreia", "Filosofia");

Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof2);

Departamento dep2 = new Departamento("Humanas");
dep2.IncluirProfessor(prof3);
dep2.IncluirProfessor(prof4);

dep1.ExibirProfessores();
dep2.ExibirProfessores();

Console.ReadKey();


