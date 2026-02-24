# Ohjelmistosuunnittelu-palautus

#ensimmäinen esimerkki
List<int> numerot = new List<int> {1, 2, 3, 4, 5};
List<int> evenNumbers = new List<int>();

foreach (int luku in numerot)
{
    if (luku %2 == 0)
    {
        evenNumbers.Add(luku);
    }
}

#toinen esimerkki
int summa = 0;

for (int i = 1; i <= 5; i++)
{
    summa += i;
}

Console.WriteLine(summa);
