# Ohjelmistosuunnittelu-palautus

List<int> numerot = new List<int> {1, 2, 3, 4, 5};
List<int> evenNumbers = new List<int>();

foreach (int luku in numerot)
{
    if (luku %2 == 0)
    {
        evenNumbers.Add(luku);
    }
}
