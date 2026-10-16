int[] A = { 2, 5, 8, 12, 16, 23, 38, 56 };
int x = 23;
int low = 0;
int high = A.Length - 1;
int index = -1;

for (int i = 0; low <= high; i++)
{
    int mid = (low + high) / 2;

    if (A[mid] == x)
    {
        index = mid;
        break;
    }
    else if (A[mid] < x)
    {
        low = mid + 1;
    }
    else
    {
        high = mid - 1;
    }
}

Console.WriteLine("Index = " + index);