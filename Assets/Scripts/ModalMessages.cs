using UnityEngine;

public class ModalMessages : MonoBehaviour
{
    private string[] headers0 =
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

    private string[] messages0 =
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

    private string[] exHeaders0 =
    {
        "Kościół św. Krzyża",
        "Kamienica Księży Misjonarzy",
        "Targ",
        "Brama Szkoły Rycerskiej",
        "Pałac Tyszkiewiczów (nazywany także pałacem Tyszkiewiczów-Potockich)",
        "Pałac Lubomirskich",
        "Pałac Radziwiłłów",
        "Kościół Karmelitów (w budowie)",
        "Ratusz jurydyki Dziekanii",
        "Karety (dwukonne)",
        "Drążnik miejski (ówczesny strażnik)",
        "Zakonnicy",
        "Księża",
        "Para z wyższych sfer",
        "Szlachcice",
        "Zamożny chłop"
    };

    private string[] exMessages0 =
    {
        "Pierwszy kościół św. Krzyża stanął w roku 1525. W roku 1653 przekazany on został Zgromadzeniu Księży Misjonarzy. Podczas potopu szwedzkiego, w roku 1656, został on splądrowany i spalony. Jego odbudowa trwała 16 lat (od roku 1679 do 1696). Projektantem kościoła w stylu barokowym był nadworny architekt królewski, Włoch Józef Szymon Bellotti. W kolejnych latach trwały prace nad rozbudową kościoła. Najpierw wzniesiono dwie wieże które zaprojektował Antoni Fontanna. Pierwszą, w latach 1726 – 1730, wzniesiono wieżę po prawej stronie kościoła. Druga po stronie lewej zbudowana została w latach od 1753 - 1754. W roku 1756 na prawej wieży umieszczono zegar oraz cztery dzwony i sygnaturkę. W tym samym roku zakończono też prace nad fasadą kościoła, która została ozdobiona rzeźbami. Pracami nad fasadą kościoła kierował syn Antoniego Fontany – Jakub. Przed kościołem znajdował się wybrukowany podjazd dla powozów, pozwalający podjechać „ważnym wiernym”, z obu stron, pod same drzwi kościoła. W dni powszednie podjazd zamykany był łańcuchem. Na szczycie podjazdu zbudowano galerię z ciosanych kamieni. Zwieńczeniem galerii stanowiły rzeźby czterech ewangelistów oraz dziesięć kamiennych wazonów. W roku 1818 podjazd został zlikwidowany, galeria natomiast została przesunięta w stronę kościoła, zniknęły wówczas wazony i ewangeliści. Co ciekawe to właśnie od tego kościoła wzięła swoją nazwę jedna z ważniejszych ulic Warszawy, leżąca nieopodal, ulica Świętokrzyska.",
        "Kamienica Księży Misjonarzy jako jednopiętrowy, murowany dom został wybudowany przed 1740 rokiem. Posiadał mansardowy, łamany dach, asymetryczną facjatkę nakrytą trójkątnym przyczółkiem. W 1701 roku, po ucieczce z więzienia wiedeńskiego, znalazł tutaj schronienie Franciszek II Rakoczy, książę Węgier i Siedmiogrodu, przywódca powstania węgierskiego 1703-1711.  W połowie XIX wieku kamienica została rozbudowana i posiadała 14-osiowy trakt. Na początku XX wieku została podwyższona o trzecie piętro.",
        "Naprzeciw kościoła św. Krzyża znajdował się targ, na którym sprzedawano przede wszystkim żywność z lichych kramów, a nawet niskich stołów. Zazwyczaj targowano tu nielegalnie. Jedynie raz do roku w dniu 3 maja targ miał charakter oficjalny albowiem był dniem tzw. odpustu. Kościół św. Krzyża obchodził wówczas święto na pamiątkę  dnia 3 maja 326 roku czyli dnia „odnalezienia”  w Jerozolimie Krzyża Świętego przez św. Helenę (matkę cesarza  Konstantyna).",
        "Brama zaprojektowana przez Jana Zygmunta Deybla i Joachima Daniela Jaucha, którą około 1732 polecił zbudować August II Mocny. Była ona zwieńczona charakterystycznym wielkim blaszanym globem.  W roku malowania obrazu (1778) brama prowadziła do założonej przez króla, Stanisława Augusta Poniatowskiego, Szkoły Rycerskiej. Powstała ona w roku 1765. Jej zadaniem było  przygotowywanie młodzieży do służby wojskowej i cywilnych zadań publicznych. Idea przyświecająca jej powstaniu to „edukacja społeczeństwa poprzez edukację jednostki”. W 1816 na terenach Szkoły Rycerskiej, powołany został na mocy dekretu imperatora Aleksandra I - Królewski Uniwersytet Warszawski. W roku 1823 bramę Augusta Mocnego zastąpiła skromniejsza brama, położona nie na linii ulicy lecz bardziej cofnięta w głąb terenu uniwersyteckiego.",
        "Został zbudowany w XVIII wieku dla Ludwika Tyszkiewicza, hetmana polnego litewskiego ożenionego z Konstancją Poniatowską, bratanicą króla Stanisława Augusta. Należał do najpiękniejszych klasycystycznych pałaców Warszawy. Budowę pałacu rozpoczął w 1785 Stanisław Zawadzki. Prace kontynuował w latach 1786-92 Jan Chrystian Kamsetzer, który uczestniczył przy przebudowie Pałacu w Łazienkach. Architektami byli również: Henryk Marconi i Fryderyk A. Lessel. Na przełomie XVIII i XIX w. pałac był w zarządzaniu Tyszkiewiczów, którzy przebywając poza granicami wynajmowali go dygnitarzom i wojskowym. W 1820 pałac stał się siedzibą i wyłączną własnością Anny z Tyszkiewiczów po jej rozwodzie z Aleksandrem Potockim. W 1840 pałac zakupił od matki syn z pierwszego małżeństwa, August Potocki, i odtąd w ręku Potockich pozostawał on do 1923. W 1923 pałac zakupił Bank Gospodarstwa Krajowego, a ulokowano tu Polską Akademię Literatury oraz zbiory starodruków Biblioteki Narodowej. W czasie Powstania Warszawskiego został on celowo zbombardowany przez wojska niemieckie pociskami zapalającymi. Pałac jest klasycystyczną budowlą z dwiema elewacjami od strony Krakowskiego Przedmieścia i placyku przy kościele Wizytek. Pałac należy do typu pierzejowego (przyulicznego) - zbudowanego w linii zabudowy ulicy - co stanowi rozwiązanie unikatowe dla XVIII-wiecznej Warszawy, w której dominował typ pałacu dziedzińcowego. Projekt pałacu nie przewidywał budowy sali balowej, co związane było z osobą fundatora, Ludwika Tyszkiewicza, który nie przepadał za hucznymi i głośnymi rozrywkami. W miejscu sali balowej zaprojektowana została obszerna bawialnia (dziś błędnie nazywana „salą balową”), nieposiadająca typowej dla sal balowych niszy, lub balkonu dla orkiestry.",
        "Pałac został wzniesiony dla starosty tczewskiego Franciszka Andraulta w roku 1655. Później przeszedł w ręce księcia Kazimierza Czartoryskiego, od 1758 stanowił własność Stanisława Lubomirskiego, następnie Ignacego Potockiego i ostatecznie od 1802 własność Tarnowskich. Na jego miejscu stoi obecnie Hotel Bristol",
        "Budowę korpusu głównego w miejscu znajdującego się w tym miejscu dworu rozpoczął ok. 1643 hetman wielki koronny Stanisław Koniecpolski. Pierwotnie był to barokowy pałac, z pierwszym w Warszawie ogrodem typu włoskiego, schodzącym aż do Wisły, płynącej w tamtych czasach u podnóża skarpy.  Po śmierci Koniecpolskiego pałac został sprzedany  w roku 1659 sprzedał pałac hetmanowi polnemu i marszałkowi wielkiemu koronnemu Jerzemu Sebastianowi Lubomirskiemu. W 1674 pałac przeszedł w ręce Radziwiłłów z linii nieświeskiej, którzy ostatecznie odkupili go w 1685. W latach 1694–1705 gmach został przebudowany pod kierunkiem Augustyna Locciego, .   Jednym z najbardziej znanych mieszkańców pałacu był książę Karol Stanisław II Radziwiłł zwany Panie Kochanku, najzamożniejszy polski magnat II połowy XVIII wieku i jeden z najbogatszych ludzi ówczesnej Europy. Poróżniony z Czartoryskimi i królem Stanisławem Augustem Poniatowskim Radziwiłł przestał bywać w stolicy, a pałac wynajmowano, co przynosiło spory dochód. W  1773 wynajęty został na cele teatralne przez austriackiego przedsiębiorcę i aktora Józefa von Kurza-Bernardona  W 1778 w pałacu odbyła się premiera polskiej opery Nędza uszczęśliwiona.   (c.d. przy Kościele Wizytek))",
        "Kościół zbudowany w latach 1661–1681 na planie krzyża z dwiema bocznymi nawami w stylu barokowym według projektu Isidoro Affaita starszego dla karmelitów bosych. W latach 1762–1780 fasada przebudowana według projektu Efraima Szregera w stylu klasycyzmu. To pierwsza kamienna fasada w stylu klasycyzmu w Rzeczypospolitej. W chwili kiedy Canaletto malował swój obraz trwał ostatni etap prac budowlanych o czym świadczy wysokość rusztowań przy fasadzie kościoła.",
        "Jurydyka był to obszar przyległy do Starej Warszawy, wyłączony spod miejskiej jurysdykcji. Był to prywatny  teren  w obrębie miasta i na gruntach podmiejskich wydzielonym spod działania sądownictwa i administracji miejskiej, dała ustawa sejmowa z 1559 roku. W przypadku Warszawy jurydyki powstawały wokół Starego i Nowego Miasta, ograniczając rozwój miasta. Niektóre z nich tworzyły małe miasteczka, inne zajmowały jedną ulicę czy kilka posesji[Posiadający swoich rajców, burmistrza i sąd. W Warszawie XVIII wieku Starą i Nową Warszawę (obecnie Stare i Nowe Miasto) otaczało ponad 20 jurydyk.",
        "Bogato zdobiony czterokołowy pojazd zaprzęgowy w kształcie prostopadłościanu, żartobliwie zwany „arką”. Rozpowszechnił się wśród polskich wyższych warstw społecznych w XVII wieku. Karety dwukonne były zazwyczaj dwuosobowe. Obie karety na obrazie Canaletta różnią się nie tylko indywidualnymi zdobieniami, ale także różnymi kolorami i krojami liberii (strojów) obsługującej je służby. W owym okresie liberie służby pozwalały określić pasażera (właściciela) pojazdu. Na pierwszym planie widać karetę z jednym lokajem, stojącym z tyłu pojazdu, co sugerować może, że jest w nim jeden pasażer. W karacie na dalszym planie widać dwóch lokai, co z kolei mówi, że prawdopodobnie jest tam więcej pasażerów. ",
        "Drążnik na głowie ma kołpak, ubrany w płaszcz z guzikami (z wytłoczonymi prawdopodobnie symbolami jurydyki. Drążnik uzbrojony jest w solidny drewniany kij, którym mógł egzekwować prawo. Jako strażnik drążnik dbał o  „porządek na placach targowych, oraz chronił zabudowania przed ogniem. ",
        "Prawdopodobnie są to księża ze Zgromadzenia Misjonarzy, do których należał pobliski kościół św. Krzyża. Świadczą o tym długie płaszcze zakonne, oraz fakt, że jeden z nich ma widoczny, wyłożony, biały kołnierzyk, co było charakterystycznym elementem stroju właśnie księży misjonarzy.",
        "Dwaj księża w sutannach mają na głowach popularne wśród w XVIII wieku kleru świeckiego tak zwane „rzymskie kapelusze”  nazywane też saturno. Włosi określali je mianem -cappello romano  (cappelli romani).",
        "Przedstawiona przez Canaletta para należy do warstw wyższych o czym świadczy jej strój który odwołujący się do mody francuskiej .  Mężczyzna na głowie perukę okrytą tricornem (trójkątnym kapeluszem).  Nosi też habit à la française - wytworny wierzchni ubiór męski bogato zdobiony przy brzegach haftem, często o motywach kwiatowych. Ma też widoczne na nogach pończochy, co świadczy, ze nosi spodnie do kolan czyli tzw.  culotte. Stojąca obok niego dama ma dwie spódnice spodnią (białą prawdopodobnie z aksamitu)  i wierzchnią – czerwoną - przy czym ta druga jest z bardziej kosztownego materiału. Wzrok przyciąga granatowe karako ( od francuskiego „caraco”) czyli krótki, dopasowany żakiecik z szerokim zaokrąglonym kołnierzem i mocno zmarszczoną z tyłu baskinką. Jej głowę ozdabia fryzura w stylu „sułtańskim” przysłonięta chustą z trójkolorowej gazy gazy.",
        "Dwóch szlachciców ma na głowach czapki rogatywki nazywane też konfederatkami.  Rozpowszechniły się w Polsce jako nakrycie głowy patriotycznego ruchu konfederatów barskich w 1768, stąd ich nazwa. Konfederatki były sukiennymi czapkami bez daszka, o główce z kwadratowym denkiem, koloru zwykle karmazynowego, obszyte barankiem, czarnym lub siwym.   Przy lewym boku przypinano do niej często kokardę, rozetę lub krzyż kawalerski i pióra lub kitę. Ich wierzchnie odzienie stanowią kontusze, pod spodem widać żupany. Obaj przewiązani są zdobnymi pasami do których przypięte są karabele (szable). Na nogach mają charakterystyczne buty zwane baczmagami. Noszenie przez szlachtę konfederatek oznaczało ich nieprzychylny stosunek do króla Stanisława Augusta.",
        "Włościanin na głowie ma prosty kołpak. Odzienie wierzchnie stanowi kazakin czyli krótki kaftan, noszony początkowo przez Kozaków, odzienie spodnie stanowi długa koszula do kolan oraz buty z cholewami."
    };

    private string[] headers1 = 
    {
        "header1",
    };

    private string[] messages1 = 
    { 
        "message1",
    };

    private string[] exHeaders1 = 
    { 
        "explo1head",
    };

    private string[] exMessages1 = 
    { 
        "explo1mess",
    };

    private string[] headers2 = { };

    private string[] messages2 = { };

    private string[] exHeaders2 = { };

    private string[] exMessages2 = { };

    private string[] headers3 = { };

    private string[] messages3 = { };

    private string[] exHeaders3 = { };

    private string[] exMessages3 = { };

    private string[] headers4 = { };

    private string[] messages4 = { };

    private string[] exHeaders4 = { };

    private string[] exMessages4 = { };

    public void GetNewMessage(int sceneNumber)
    {
        switch(sceneNumber){
            case 0: 
                ModalManager.instance.ShowModal(headers0[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr], messages0[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr]);
                break;
            case 1:
                ModalManager.instance.ShowModal(headers1[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr], messages1[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr]);
                break;
            case 2:
                ModalManager.instance.ShowModal(headers2[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr], messages2[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr]);
                break;
            case 3:
                ModalManager.instance.ShowModal(headers3[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr], messages3[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr]);
                break;
            case 4:
                ModalManager.instance.ShowModal(headers4[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr], messages4[GameObject.Find("PointOfInterest").GetComponent<Interactions>().objectnr]);
                break;
        }
    }

    public void GetNewMessageExplore(int goNumber, int sceneNumber)
    {
        switch (sceneNumber)
        {
            case 0:
                ModalManager.instance.ShowModal(exHeaders0[goNumber], exMessages0[goNumber]);
                break;
            case 1:
                ModalManager.instance.ShowModal(exHeaders1[goNumber], exMessages1[goNumber]);
                break;
            case 2:
                ModalManager.instance.ShowModal(exHeaders2[goNumber], exMessages2[goNumber]);
                break;
            case 3:
                ModalManager.instance.ShowModal(exHeaders3[goNumber], exMessages3[goNumber]);
                break;
            case 4:
                ModalManager.instance.ShowModal(exHeaders4[goNumber], exMessages4[goNumber]);
                break;
        }
    }

}
