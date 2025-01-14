//exists a better way to solve this problem using an array of prime numbers

string input = Console.ReadLine();

string[] numbers = input.Split(' ');

int num1 = int.Parse(numbers[0]);

int num2 = int.Parse(numbers[1]);

bool find = false;

string res = "NO";

while(!find)
{
    bool isPrime = true;
    num1 += 1;

    for (int i = num1-1; i > 1; i--)
    {
        if(num1%i==0)
        {
            isPrime = false;
        }
    }

    if (isPrime)
    {
        if (num1 == num2)
        {
            res = "YES";
            find = true;
        } else
        {
            break;
        }
    }

    if (num1 == num2)
        find = true;
}

Console.WriteLine(res);