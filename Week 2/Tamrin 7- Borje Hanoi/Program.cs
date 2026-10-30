void Hanoi(int n, char mabda, char maghsad, char komaki)
{
    if (n == 1)
    {
        Console.WriteLine(mabda + " -> " + maghsad);
        return;
    }
    Hanoi(n - 1, mabda, komaki, maghsad);
    Console.WriteLine(mabda + " -> " + maghsad);
    Hanoi(n - 1, komaki, maghsad, mabda);
}