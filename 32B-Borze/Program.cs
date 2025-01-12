string s = Console.ReadLine();
string res = "";

for (int i = 0; i <= s.Length-1; i++)
{
    if (s[i] == '.')
    {
        res += "0";
    }
    if (s[i] == '-')
    {
        if (s[i+1] == '.')
        {
            res += "1";
        }
        if (s[i+1] == '-')
        {
            res += "2";
        }
        i += 1;
    }
}

Console.WriteLine(res);