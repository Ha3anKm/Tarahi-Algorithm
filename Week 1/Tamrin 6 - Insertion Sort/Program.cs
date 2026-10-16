int[] A = { 9, 5, 1, 4, 3 };

for (int i = 1; i < A.Length; i++)
{
    int key = A[i];
    int j;

    for (j = i - 1; j >= 0 && A[j] > key; j--)
    {
        A[j + 1] = A[j];
    }

    A[j + 1] = key;
}

for (int i = 0; i < A.Length; i++)
{
    Console.Write(A[i] + " ");
}