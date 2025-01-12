string word;
int u = 0, l = 0;

word = Console.ReadLine();

for (int i = 0; i <= word.Length - 1; i++)
{
    if (Char.IsUpper(word[i]))
    {
        u++;
    }
    else
    {
        l++;
    }
}

Console.WriteLine((u > l) ? word.ToUpper() : word.ToLower());
