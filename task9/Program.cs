string ОбратнаяСтрока(string входнаяСтрока)
{
    char[] символы = входнаяСтрока.ToCharArray();
    Array.Reverse(символы);
    return new string(символы);
}
