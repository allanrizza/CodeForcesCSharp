int[] input;

int[,] arr = new int[5, 5];

int posi = 0;

int posj = 0;

bool keepRunning = true;

for (int i = 0; i < 5 && keepRunning; i++)
{
    input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    for (int j = 0; j < 5; j++)
    {
        arr[i, j] = input[j];
        if (input[j] == 1)
        {
            posi = i;
            posj = j;
            keepRunning = false;
            break;
        }
    }
}

int desi = Math.Abs(2 - posi);
int desj = Math.Abs(2 - posj);

Console.WriteLine(desi + desj);