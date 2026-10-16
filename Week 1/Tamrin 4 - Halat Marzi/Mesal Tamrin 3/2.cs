int[] A = { 2, 4, 6, 8 };
int sum = 0;

for (int i = 0; i < A.Length; i++)
{
    if (A[i] % 2 == 0)
    {
        sum = sum + A[i];
    }
}

Console.WriteLine("Sum = " + sum);