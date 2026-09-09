double Exchange(Enum currency, double azn)
{
    if(currency is not Currency)
        return 0;
    if(currency is Currency.Eur)
        return azn* 0.59;
    if(currency is Currency.Try)
        return azn*0.2;
    if(currency is Currency.Usd)
        return azn*0.7;
    return 0;
}
Console.WriteLine(Exchange(Currency.Eur, 23));