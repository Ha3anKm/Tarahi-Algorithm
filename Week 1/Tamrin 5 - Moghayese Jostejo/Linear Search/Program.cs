int[] A = { 2, 5, 8, 12, 16, 23, 38, 56 };
int x = 23;
int index = -1;

for (int i = 0; i < A.Length; i++)
{
    if (A[i] == x)
    {
        index = i;
        break;
    }
}

Console.WriteLine("Index = " + index);