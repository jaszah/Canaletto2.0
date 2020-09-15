using UnityEngine;

public class Tester : MonoBehaviour
{
    private string[] headers =
    {
        "Hotel Bristol",
        "Dom bez Kantów",
        "Neon",
        "Serce Chopina",
        "Autobus",
        "Pastorał Warszawski",
        "Kamienica Księży Misjonarzy",
        "Rowerzysta",
        "Pracownik MPO",
        "Straż Miejska",
        "Bankomat",
        "Kiosk „Ruch”"
    };

    private string[] messages =
    {
        "Hotel Bristol, otwarty 19 listopada 1901 roku, został wybudowany na miejscu pałacu Tarczyńskich. Jednym z  inicjatorów jego budowy był Ignacy Jan Paderewski.",
        "„Dom bez kantów” z mieszkaniami dla oficerów i żonatych podoficerów zawodowych stanął na miejscu tzw. kuźni saskich – stajni, kuźni i budynku z kwaterami oficerskimi. Wybudowany  w latach 1933-1935 przez Ministerstwo Spraw Wojskowych.",
        "Pierwszy neon w Warszawie rozbłysnął w 1926 roku – była to reklama browaru „Haberbusch i Schiele” na dachu willi Marconiego przy skrzyżowaniu Marszałkowskiej i Alej Jerozolimskich. Choć neon przedstawiał  butelkę z napisem „Porter”, warszawiacy nazywali go neonem „Philipsa”.",
        "Fortepian Fryderyka Chopina stał w mieszkaniu jego siostry, Izabeli Barcińskiej w pałacu Zamoyskich do 19 września 1963 roku. Tego dnia został wyrzucony przez okno na ulicę przez rosyjskich żołnierzy w ramach działań odwetowych podczas trwającego powstania styczniowego. Kilkanaście  lat wcześniej urna z sercem Fryderyka Chopina trafiła do Warszawy. W 1880 roku urnę z sercem kompozytora umieszczono w filarze kościoła Św. Krzyża.",
        "Pierwsze autobusy pojawiły się w Warszawie w roku 1920. Były to pojazdy szwajcarskiej marki Saurer. Przed wybuchem II wojny światowej po Warszawie jeździło 180 autobusów.",
        "Latarnia elektryczna typu „pastorał warszawski” miała kilka wzorów wprowadzanych kolejno w latach – 1904, 1907, 1923 i 1928. Wprawdzie pierwsze latarnie elektryczne  pojawiły się w Warszawie już w 1878 roku, lecz były to lampy łukowe stawiane jedynie czasowo m.in. w Ogrodzie Saskim. Dopiero od roku 1904 rozpoczęto iluminację ulic Warszawy za pomocą „pastorałów”.",
        "W kamienicy Księży Misjonarzy na Krakowskim Przedmieściu 1.  Jan Karski, w 1939 roku, rozpoczął tu swoją działalność konspiracyjną. To dzięki niemu świat dowiedział się o zbrodni Holocaustu. Później  w kamienicy mieściła się komenda policji.",
        "Pierwsze  sprowadzone z Anglii bicykle „z gumowymi obręczami” pojawiły się w Warszawie około 1872 roku. Dwadzieścia lat później poniżej skarpy wiślanej na Dynasach, sąsiadujących z Krakowskim Przedmieściem, zbudowano pierwszy tor kolarski.",
        "Śmieci, określane jako nieczystości stałe, wywożone były w XVIII-wiecznej Warszawie na wozach dwukołowych nazywanych karami. Zjeżdżały one w stronę Wisły ulicą sąsiadującą z Kościołem Wizytek. Od roku 1770  ulica ta nosi nazwę Karowej od karów – nazwy tych osiemnastowiecznych śmieciarek.",
        "Policja municypalna powstała w Warszawie w 1817 roku i dzieliła się na  policję śledczą, sądowo-policyjną, urząd targowo-tandetny oraz służbę rogatkową. W 1991 roku została utworzona Straż Miejska nadzorowana przez samorząd i niepodlegająca policji.",
        "Pierwszy bankomat w historii został uruchomiony w 1967 w Londynie. Wzorowany był na urządzeniach sprzedających słodycze. Pierwszy bankomat w Polsce pojawił się 20 lat później, w 1987 roku w III oddziale Banku PKO w Warszawie.",
        "Pierwszy kiosk „Ruchu” otwarto 1919 na dawnym dworcu kolei warszawsko-wiedeńskiej;"
    };

    public void GetNewMessage()
    {
        ModalManager.instance.ShowModal(headers[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr], messages[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr]);
    }

    public void GetNewMessageExplore(int goNumber)
    {
        ModalManager.instance.ShowModal(headers[goNumber], messages[goNumber]);
    }

}
