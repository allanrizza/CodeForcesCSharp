string num = Console.ReadLine();
string stones = Console.ReadLine();

int qtd = 0;

for (int i = 0; i < stones.Length-1; i++)
{
    if (stones[i] == stones[i+1])
    {
        qtd++;
    }
}

Console.WriteLine(qtd);