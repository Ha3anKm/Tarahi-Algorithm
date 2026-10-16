int[] A = { 7, 7, 7, 7 };
int min = A[0];

for (int i = 1; i < A.Length; i++)
{
    if (A[i] < min)
    {
        min = A[i];
    }
}

Console.WriteLine("Min = " + min);