Imperative paradigm 

Tässä käsitellään imperatiivista ohjelmointiparadigmaa, sen keskeisiä periaatteita, rakennetta, alamuotoja sekä havainnoidaan hieman verrattaen deklaratiiviseen ohjelmointiin. 
Imperatiivinen ohjelmointi on yksi ohjelmoinnin paradigma. 
Käsitellään käskyjä järjestyksessä haluttua lopputulosta varten. 

Keskeistä on:
- Suoritusjärjestys on tarkasti määritelty
- Ohjelman tila muuttuu suorituksen aikana
- Muuttujia käytetään arvojen tallentamiseen ja päivittämiseen
- Ohjausrakenteet määrittävät ohjelman etenemisen

Keskeisiä käskyjen muodostamisessa on:
- if / else
- switch
- for
- while
- do-while
- funktiokutsuilla

Ohjelmistosuunnittelu-palautuksen alta löydät 2 esimerkkiä C# kirjoitettuna. 

KOODI1:
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

KOODI2:
//toinen esimerkki
//luodaan muuttuja, jonka arvo on 0 alussa
int summa = 0;

//kasvatetaan lukua aina +i, kunnes i <=5
for (int i = 1; i <= 5; i++)
{
    summa += i;
}

//tulostetaan summa
Console.WriteLine(summa);
