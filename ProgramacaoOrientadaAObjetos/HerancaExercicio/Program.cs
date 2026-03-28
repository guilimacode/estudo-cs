Console.WriteLine("## Herança - Exercícios ##\n");

ContaCorrente cc = new(1788, "Antonio Silva");
ContaPoupanca pp = new(4799, "Julio Costa");
ContaInvestimento ci = new(9876, "Amanda Lopes");

cc.ExibirDados();
pp.ExibirDados();
cc.ExibirDados();

cc.Depositar(1000);
pp.Depositar(1000);
ci.Depositar(1000);

cc.Sacar(100);
pp.Sacar(100);
ci.Sacar(100);

Console.ReadKey();
