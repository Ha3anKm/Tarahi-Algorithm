int[] A = { 1, 5, 3, 7 };
int sum = 0;

for (int i = 0; i < A.Length; i++)
{
    if (A[i] % 2 == 0)
    {
        sum = sum + A[i];
    }
}

Console.WriteLine("Sum = " + sum);