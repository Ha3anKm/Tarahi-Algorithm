int[] A = { 3, 8, 3, 1, 5 };
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