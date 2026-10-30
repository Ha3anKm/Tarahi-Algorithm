int Sum(int n)
{
    if (n <= 1)
        return n;
    return n + Sum(n - 1);
}