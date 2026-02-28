//ensimmäinen esimerkki
//listan luominen
List<int> numerot = new List<int> {1, 2, 3, 4, 5};
//luodaan tyhjä lista
List<int> evenNumbers = new List<int>();

//käydään numerot läpi ja tallennetaan muuttujan luku, jos ehto täyttyy
foreach (int luku in numerot)
{
    if (luku %2 == 0)
    {
        evenNumbers.Add(luku);
    }
}
