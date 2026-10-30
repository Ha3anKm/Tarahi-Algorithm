int Tavan(int a, int b)
{
    if (b == 0)
        return 1;
    return a * Tavan(a, b - 1);
}