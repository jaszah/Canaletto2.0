﻿using UnityEngine;

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

    private string[] exHeaders =
    {
        "Kościół św. Krzyża",
        "Kościół św. Krzyża",
        "Kamienica Księży Misjonarzy",
        "Brama Szkoły Rycerskiej",
        "nop",
        "nop",
        "Targ",
    };

    private string[] exMessages =
    {
        "Pierwszy kościół ble ble ble",
        "Pierwszy kościół św. Krzyża stanął w roku 1525. W roku 1653 przekazany on został Zgromadzeniu Księży Misjonarzy. Podczas potopu szwedzkiego, w roku 1656, został on splądrowany i spalony. Jego odbudowa trwała 16 lat (od roku 1679 do 1696). Projektantem kościoła w stylu barokowym był nadworny architekt królewski, Włoch Józef Szymon Bellotti. W kolejnych latach trwały prace nad rozbudową kościoła. Najpierw wzniesiono dwie wieże które zaprojektował Antoni Fontanna. Pierwszą, w latach 1726 – 1730, wzniesiono wieżę po prawej stronie kościoła. Druga po stronie lewej zbudowana została w latach od 1753 - 1754. W roku 1756 na prawej wieży umieszczono zegar oraz cztery dzwony i sygnaturkę. W tym samym roku zakończono też prace nad fasadą kościoła, która została ozdobiona rzeźbami. Pracami nad fasadą kościoła kierował syn Antoniego Fontany – Jakub. Przed kościołem znajdował się wybrukowany podjazd dla powozów, pozwalający podjechać „ważnym wiernym”, z obu stron, pod same drzwi kościoła. W dni powszednie podjazd zamykany był łańcuchem. Na szczycie podjazdu zbudowano galerię z ciosanych kamieni. Zwieńczeniem galerii stanowiły rzeźby czterech ewangelistów oraz dziesięć kamiennych wazonów. W roku 1818 podjazd został zlikwidowany, galeria natomiast została przesunięta w stronę kościoła, zniknęły wówczas wazony i ewangeliści. Co ciekawe to właśnie od tego kościoła wzięła swoją nazwę jedna z ważniejszych ulic Warszawy, leżąca nieopodal, ulica Świętokrzyska.",
        "Kamienica Księży Misjonarzy jako jednopiętrowy, murowany dom został wybudowany przed 1740 rokiem. Posiadał mansardowy, łamany dach, asymetryczną facjatkę nakrytą trójkątnym przyczółkiem. W 1701 roku, po ucieczce z więzienia wiedeńskiego, znalazł tutaj schronienie Franciszek II Rakoczy, książę Węgier i Siedmiogrodu, przywódca powstania węgierskiego 1703-1711.  W połowie XIX wieku kamienica została rozbudowana i posiadała 14-osiowy trakt. Na początku XX wieku została podwyższona o trzecie piętro.",
        "Brama zaprojektowana przez Jana Zygmunta Deybla i Joachima Daniela Jaucha, którą około 1732 polecił zbudować August II Mocny. Była ona zwieńczona charakterystycznym wielkim blaszanym globem.  W roku malowania obrazu (1778) brama prowadziła do założonej przez króla, Stanisława Augusta Poniatowskiego, Szkoły Rycerskiej. Powstała ona w roku 1765. Jej zadaniem było  przygotowywanie młodzieży do służby wojskowej i cywilnych zadań publicznych. Idea przyświecająca jej powstaniu to „edukacja społeczeństwa poprzez edukację jednostki”. W 1816 na terenach Szkoły Rycerskiej, powołany został na mocy dekretu imperatora Aleksandra I - Królewski Uniwersytet Warszawski. W roku 1823 bramę Augusta Mocnego zastąpiła skromniejsza brama, położona nie na linii ulicy lecz bardziej cofnięta w głąb terenu uniwersyteckiego.",
        "nop",
        "nop",
        "Naprzeciw kościoła św. Krzyża znajdował się targ, na którym sprzedawano przede wszystkim żywność z lichych kramów, a nawet niskich stołów. Zazwyczaj targowano tu nielegalnie. Jedynie raz do roku w dniu 3 maja targ miał charakter oficjalny albowiem był dniem tzw. odpustu. Kościół św. Krzyża obchodził wówczas święto na pamiątkę  dnia 3 maja 326 roku czyli dnia 'odnalezienia' w Jerozolimie Krzyża Świętego przez św. Helenę (matkę cesarza  Konstantyna)."

    };

    public void GetNewMessage()
    {
        ModalManager.instance.ShowModal(headers[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr], messages[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr]);
    }

    public void GetNewMessageExplore(int goNumber)
    {
        ModalManager.instance.ShowModal(exHeaders[goNumber], exMessages[goNumber]);
    }

}
