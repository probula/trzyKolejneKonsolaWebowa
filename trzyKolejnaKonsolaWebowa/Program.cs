
public class Klasa
{
    private int[] tablica = [];
    private int liczbaElementow;

    /*
     *****************
    nazwa metody: Klasa
    opis metody: Konstruktor wypelniajacy tablice liczbami
    parametry: rozmiar - argument liczbowy przyjmujacy rozmiar tablicy
    zwracany typ i opis: brak
    autor: XYZ
    ******************
    */
     
    public Klasa(int rozmiar)
    {
        liczbaElementow = rozmiar;
        tablica = new int[rozmiar];
        
        for (int i = 0; i < liczbaElementow; i++)
        {
            var rand = new Random().Next(1, 1001);
            tablica[i] = rand;
        }
    }
    
    /*
   *****************
  nazwa metody: Wyswietl
  opis metody: wypisuje indeks i wartosc tablicy
  parametry: brak
  zwracany typ i opis: brak
  autor: XYZ
  ******************
  */

    public void Wyswietl()
    {
        for (int i = 0; i < liczbaElementow; i++)
        {
            Console.WriteLine($"{i}: {tablica[i]}");
        }
    }

    /*
   *****************
  nazwa metody: Szukaj
  opis metody: znajduje wartosc podaną w argumencie
  parametry: wartoscSzukana - liczba calkowita którą chcemy znalezc
  zwracany typ i opis: brak
  autor: XYZ
  ******************
  */
    
    public void Szukaj(int wartoscSzukana)
    {
        for (int i = 0; i < liczbaElementow; i++)
        {

            if (tablica.IndexOf(i) == wartoscSzukana)
            {
                Console.WriteLine($"pierwsze wystąpienie liczby: {i}:  {tablica[i]}");
            }
        }
    }
    
    /*
       *****************
      nazwa metody: WyswietlNieparzyste
      opis metody: Wyswietla nieparzyste liczby z tablicy
      parametry: brak
      zwracany typ i opis: int, zwraca sumaNieparzystych liczb z  tablicy
      autor: XYZ
      ******************
      */
    
    public int WyswietlNieparzyste()
    {
        int sumaNieparzystych = 0;
        for (int i = 0; i < liczbaElementow; i++)
        {
            if (tablica[i] % 2 != 0)
            {
                Console.WriteLine(tablica[i]);
                sumaNieparzystych+=tablica[i];
            }
        }
        return sumaNieparzystych;
    }
    /*
       *****************
      nazwa metody: SredniaArytmetyczna
      opis metody: liczy srednia arytmetyczna elementow tablicy
      parametry: brak
      zwracany typ i opis: brak
      autor: XYZ
      ******************
      */
    public void SredniaArytmetyczna()
    {
        int sumaElementow = 0;
        int srednia = 0;
        for (int i = 0; i < liczbaElementow; i++)
        {
            sumaElementow += tablica[i];
        }
        Console.WriteLine($"srednia to: {sumaElementow /  liczbaElementow}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Klasa klasa = new Klasa(300);
            klasa.Wyswietl();
            klasa.WyswietlNieparzyste();
            klasa.SredniaArytmetyczna();
            klasa.Szukaj(1);

    }
}