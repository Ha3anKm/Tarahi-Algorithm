int Tarkib(int n, int k)
{
    if (k == 0 || k == n)
        return 1;
    return Tarkib(n - 1, k - 1) + Tarkib(n - 1, k);
}