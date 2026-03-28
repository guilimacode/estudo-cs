using Indexadores;

Console.WriteLine("## Indexadores ##\n");

Time time = new();

//atribui valores set

time[1] = "Palmeiras";
time[2] = "Flamengo";
time[3] = "Fortaleza";
time[7] = "Ceará";
time[29] = "Bahia";

//obtendo os valores get
string valor1 = time[1];
string valor2 = time[2];
string valor3 = time[3];
string valor7 = time[7];
string valor29 = time[29];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor7);
Console.WriteLine(valor29);

Console.ReadKey();
