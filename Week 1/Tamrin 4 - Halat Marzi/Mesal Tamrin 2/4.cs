int[] A = { 1, 4, 8, 3 };
int x = 3;
int count = 0;

for (int i = 0; i < A.Length; i++)
{
    if (A[i] == x)
    {
        count++;
    }
}

Console.WriteLine("Count = " + count);