Console.WriteLine("## Repetição Do While ##\n");

int i = 1;
do
{
    Console.WriteLine($"i = {i}");
    i++;
    if (i > 7)
    {
        break;
    }
}
while (true); 

Console.ReadLine();
