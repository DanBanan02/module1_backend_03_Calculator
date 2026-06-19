/* 
using System.Diagnostics;
using RecipiesSelector;

namespace RecipiesSelector
{
    // Class: to Show Recipies
    class RecipieMenu
    {
        
        // Recives Recipie Menu
        public void DisplayMenu(string text2)
        {
            Console.WriteLine("================================");
            Console.WriteLine("");       
            Console.WriteLine(text2);
            Console.WriteLine("");
            Console.WriteLine("================================");
        }

        // DESSERTS
        class DessertMenu()
        {

            // Oppskrift på blåbærfromasj
            public void RecipieDessert1()
            {
                Console.Write(RecipieDessert1);
                Console.WriteLine("Blåbærfromasj");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 3 dl blåbær");
                Console.WriteLine("- 1 dl sukker");
                Console.WriteLine("- 2 dl kremfløte");
                Console.WriteLine("- 2 plater gelatin");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. Legg gelatinplatene i kaldt vann i ca. 5 minutter.");
                Console.WriteLine("2. Kjør blåbærene og sukkeret i en blender til en jevn puré.");
                Console.WriteLine("3. Varm opp blåbærpuréen i en kjele på lav varme.");
                Console.WriteLine("4. Klem vannet ut av gelatinplatene og rør dem inn i den varme blåbærpuréen til de er helt oppløst.");
                Console.WriteLine("5. Pisk kremfløten til myke topper og vend den forsiktig inn i blåbærblandingen.");
                Console.WriteLine("6. Hell blandingen i porsjonsformer eller en stor serveringsbolle og sett den i kjøleskapet i minst 4 timer, eller til den er stivnet.");
                Console.WriteLine("7. Server gjerne med friske bær eller et dryss av melis på toppen.");
                Console.ReadLine();
            }


            // Oppskrift på brownies
            public void RecipieDessert2()
            {   
                Console.Write(RecipieDessert2); 
                Console.WriteLine("Brownies");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 200 g smør");
                Console.WriteLine("- 200 g sukker");
                Console.WriteLine("- 3 egg");
                Console.WriteLine("- 100 g hvetemel");
                Console.WriteLine("- 50 g kakao");
                Console.WriteLine("- 1 ts vaniljesukker");
                Console.WriteLine("- En klype salt");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. Forvarm ovnen til 180°C og smør en bakeform (ca. 20x20 cm).");
                Console.WriteLine("2. Smelt smøret i en kjele på lav varme, og la det avkjøle litt.");
                Console.WriteLine("3. Rør inn sukkeret i det smeltede smøret, og deretter eggene, ett om gangen, mens du rører godt mellom hvert egg.");
                Console.WriteLine("4. Sikt sammen hvetemel, kakao, vaniljesukker og salt i en bolle, og vend det forsiktig inn i den våte blandingen til alt er godt kombinert.");
                Console.WriteLine("5. Hell røren i den forberedte bakeformen og jevn ut overflaten.");
                Console.WriteLine("6. Stek i ovnen i ca. 25-30 minutter, eller til en tannpirker kommer ut med noen fuktige smuler når du stikker den i midten av kaken.");
                Console.WriteLine("7. La browniesene avkjøle helt i formen før du skjærer dem i firkanter og serverer.");
                Console.ReadLine();
            }


            // Oppskrift på churros
            public void RecipieDessert3()
            {   
                Console.Write(RecipieDessert3);
                Console.WriteLine("Churros");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 2 dl vann");
                Console.WriteLine("- 2 ss sukker");
                Console.WriteLine("- 1/2 ts salt");
                Console.WriteLine("- 2 ss vegetabilsk olje");
                Console.WriteLine("- 2 dl hvetemel");
                Console.WriteLine("- Olje til fritering");
                Console.WriteLine("- Kanel og sukker til å rulle churrosene i");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. I en kjele, kok opp vann, sukker, salt og vegetabilsk olje.");
                Console.WriteLine("2. Når blandingen koker, fjern kjelen fra varmen og rør inn hvetemelet til det danner en jevn deig.");
                Console.WriteLine("3. La deigen avkjøle i noen minutter før du overfører den til en sprøytepose med stjernetipp.");
                Console.WriteLine("4. Varm opp olje i en dyp panne eller frityrkoker til ca. 180°C.");
                Console.WriteLine("5. Sprøyt ut deigen i lange strimler direkte i den varme oljen, og klipp av ønsket lengde med saks.");
                Console.WriteLine("6. Friter churrosene i oljen til de er gyldne og sprø, ca. 2-3 minutter per side.");
                Console.WriteLine("7. Bruk en hullsleiv for å ta churrosene ut av oljen og la dem renne av på kjøkkenpapir.");
                Console.WriteLine("8. Rull de varme churrosene i en blanding av kanel og sukker før servering.");
                Console.ReadLine();
            }


            // Oppskrift på sjokolade fondant
            public void RecipieDessert4()
            {   
                Console.Write(RecipieDessert4);
                Console.WriteLine("Sjokolade Fondant");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 200 g mørk sjokolade");
                Console.WriteLine("- 200 g smør");
                Console.WriteLine("- 4 egg");
                Console.WriteLine("- 150 g sukker");
                Console.WriteLine("- 100 g hvetemel");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. Forvarm ovnen til 220°C og smør fire små ramekiner (ca. 150 ml hver) med smør.");
                Console.WriteLine("2. Smelt sjokoladen og smøret sammen i en bolle over vannbad, og rør til det er glatt.");
                Console.WriteLine("3. I en annen bolle, visp eggene og sukkeret sammen til det er lyst og luftig.");
                Console.WriteLine("4. Vend forsiktig inn den smeltede sjokoladeblandingen i eggedosisen, og deretter sikt inn hvetemelet og vend det inn til alt er godt kombinert.");
                Console.WriteLine("5. Fordel røren jevnt i de forberedte ramekinene.");
                Console.WriteLine("6. Stek i ovnen i ca. 12-14 minutter, eller til kantene er");
                Console.ReadLine();
            }


            // Oppskrift på vafler
            public void RecipieDessert5()
            {
                Console.Write(RecipieDessert5);
                Console.WriteLine("Vafler");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 3 egg");
                Console.WriteLine("- 500 ml melk");
                Console.WriteLine("- 250 g hvetemel");
                Console.WriteLine("- 50 g sukker");
                Console.WriteLine("- 1 ts vaniljesukker");
                Console.WriteLine("- En klype salt");
                Console.WriteLine("- Smør til steking");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. I en stor bolle, visp sammen eggene og melken.");
                Console.WriteLine("2. Sikt inn hvetemel, sukker, vaniljesukker og salt, og rør til du får en jevn røre.");
                Console.WriteLine("3. La røren hvile i ca. 30 minutter for å få luftigere vafler.");
                Console.WriteLine("4. Forvarm vaffeljernet og smør det lett med smør.");
                Console.WriteLine("5. Hell en passende mengde røre i vaffeljernet og stek til vaflene er gyldne og sprø.");
                Console.WriteLine("6. Server vaflene varme med ønsket tilbehør, som syltetøy, rømme eller friske bær.");
                Console.ReadLine();
            }
        }

        // DINNERS
        class DinnerMenu()
        {

            // Oppskrift på hamburger
            public void RecipieDinner1()
        {
            Console.WriteLine(RecipieDinner1);
            Console.WriteLine("Hamburger");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Ingredienser:");
            Console.WriteLine("- 500 g kjøttdeig");
            Console.WriteLine("- 1 ts salt");
            Console.WriteLine("- 1/2 ts pepper");
            Console.WriteLine("- 4 hamburgerbrød");
            Console.WriteLine("- Salat, tomat, løk og ost etter ønske");
            Console.WriteLine("");
            Console.WriteLine("Fremgangsmåte:");
            Console.WriteLine("");
            Console.WriteLine("1. Forvarm grillen eller en stekepanne på medium høy varme.");
            Console.WriteLine("2. Bland kjøttdeigen med salt og pepper, og form den til fire like store burgere.");
            Console.WriteLine("3. Stek burgerne i ca. 4-5 minutter på hver side, eller til de er gjennomstekte.");
            Console.WriteLine("4. Legg en skive ost på hver burger de siste minuttene av steketiden for å smelte osten.");
            Console.WriteLine("5. Rist hamburgerbrødene lett på grillen eller i pannen.");
            Console.WriteLine("6. Monter burgerne med ønsket tilbehør som salat, tomat og løk, og server umiddelbart.");
            Console.ReadLine();
        }

            // Oppskrift på lasagne
            public void RecipieDinner2()
        {
            Console.WriteLine(RecipieDinner2);
            Console.WriteLine("Lasagne");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Ingredienser:");
            Console.WriteLine("- 500 g kjøttdeig");
            Console.WriteLine("- 1 løk, finhakket");
            Console.WriteLine("- 2 fedd hvitløk, finhakket");
            Console.WriteLine("- 400 g hakkede tomater");
            Console.WriteLine("- 2 ss tomatpuré");
            Console.WriteLine("- 1 ts tørket oregano");
            Console.WriteLine("- 1 ts tørket basilikum");
            Console.WriteLine("- Salt og pepper etter smak");
            Console.WriteLine("- 9 lasagneplater");
            Console.WriteLine("- 500 ml béchamelsaus");
            Console.WriteLine("- 200 g revet ost (for eksempel mozzarella eller cheddar)");
            Console.WriteLine("");
            Console.WriteLine("Fremgangsmåte:");
            Console.WriteLine("");
            Console.WriteLine("1. Forvarm ovnen til 180°C.");
            Console.WriteLine("2. I en stor stekepanne, brun kjøttdeigen sammen med løk og hvitløk til kjøttet er gjennomstekt og løken er myk.");
            Console.WriteLine("3. Tilsett hakkede tomater, tomatpuré, oregano, basilikum, salt og pepper. La det småkoke i ca. 15-20 minutter for å utvikle smakene.");
            Console.WriteLine("4. I en stor ildfast form, legg et lag med kjøttsaus i bunnen, deretter et lag med lasagneplater, og deretter et lag med béchamelsaus. Gjenta lagene til alle ingrediensene er brukt opp, og avslutt med et lag béchamelsaus på toppen.");
            Console.WriteLine("5. Strø revet ost over det øverste laget.");
            Console.WriteLine("6. Stek lasagnen i ovnen i ca. 30-35 minutter, eller til den er gylden og boblende på toppen.");
            Console.WriteLine("7. La lasagnen hvile i noen minutter før du skjærer den opp og serverer.");
        }

            // Oppskrift på pizza deig
            public void RecipieDinner3()
        {
            Console.WriteLine(RecipieDinner3);
            Console.WriteLine("Pizza Deig");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Ingredienser:");
            Console.WriteLine("- 500 g hvetemel");
            Console.WriteLine("- 1 ts salt");
            Console.WriteLine("- 1 ts sukker");
            Console.WriteLine("- 2 ss olivenolje");
            Console.WriteLine("- 25 g fersk gjær eller 7 g tørrgjær");
            Console.WriteLine("- 300 ml lunkent vann");
            Console.WriteLine("");
            Console.WriteLine("Fremgangsmåte:");
            Console.WriteLine("");
            Console.WriteLine("1. I en stor bolle, bland sammen hvetemel, salt og sukker.");
            Console.WriteLine("2. Smuldre gjæren i det lunkne vannet og la det stå i noen minutter til det begynner å skumme.");
            Console.WriteLine("3. Lag en grop i midten av melblandingen og hell i gjærblandingen og olivenoljen.");
            Console.WriteLine("4. Rør sammen til en deig begynner å forme seg, og deretter kna deigen på en melet overflate i ca. 10 minutter til den er glatt og elastisk.");
            Console.WriteLine("5. Legg deigen i en lett oljet bolle, dekk den til med plastfolie eller et kjøkkenhåndkle, og la den heve på et lunt sted i ca. 1-2 timer, eller til den har doblet i størrelse.");
            Console.WriteLine("6. Når deigen har hevet, slå den ned for å fjerne luftbobler, og del den i ønsket antall porsjoner for å lage pizzaer.");
            Console.ReadLine();
        }

            // Oppskrift på potetmos
            public void RecipieDinner4()
        {
            Console.WriteLine(RecipieDinner4);
            Console.WriteLine("Potetmos");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Ingredienser:");
            Console.WriteLine("- 1 kg poteter");
            Console.WriteLine("- 100 g smør");
            Console.WriteLine("- 200 ml melk");
            Console.WriteLine("- Salt og pepper etter smak");
            Console.WriteLine("");
            Console.WriteLine("Fremgangsmåte:");
            Console.WriteLine("");
            Console.WriteLine("1. Skrell potetene og del dem i jevne biter.");
            Console.WriteLine("2. Kok potetene i en stor kjele med saltet vann til de er møre, ca. 15-20 minutter.");
            Console.WriteLine("3. Tøm av vannet og la potetene dampe av i noen minutter for å fjerne overflødig fuktighet.");
            Console.WriteLine("4. Tilsett smør og melk til de varme potetene, og mos dem sammen med en potetmoser eller en elektrisk mikser til du får en glatt og kremet konsistens.");
            Console.WriteLine("5. Smak til med salt og pepper, og server potetmosen varm som tilbehør til kjøtt, fisk eller grønnsaker.");
            Console.ReadLine();
        }

            // Oppskrift på spagetti bolognese
            public void RecipieDinner5()
        {
            Console.WriteLine(RecipieDinner5);
            Console.WriteLine("Spagetti Bolognese");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Ingredienser:");
            Console.WriteLine("- 500 g kjøttdeig");
            Console.WriteLine("- 1 løk, finhakket");
            Console.WriteLine("- 2 fedd hvitløk, finhakket");
            Console.WriteLine("- 400 g hakkede tomater");
            Console.WriteLine("- 2 ss tomatpuré");
            Console.WriteLine("- 1 ts tørket oregano");
            Console.WriteLine("- 1 ts tørket basilikum");
            Console.WriteLine("- Salt og pepper etter smak");
            Console.WriteLine("- 400 g spagetti");
            Console.WriteLine("");
            Console.WriteLine("Fremgangsmåte:");
            Console.WriteLine("");
            Console.WriteLine("1. Kok spagettien i en stor kjele med saltet vann i henhold til pakningsanvisningene til den er al dente. Tøm av vannet og sett spagettien til side.");
            Console.WriteLine("2. I en stor stekepanne, brun kjøttdeigen sammen med løk og hvitløk til kjøttet er gjennomstekt og løken er myk.");
            Console.WriteLine("3. Tilsett hakkede tomater, tomatpuré, oregano, basilikum, salt og pepper. La det småkoke i ca. 15-20 minutter for å utvikle smakene.");
            Console.WriteLine("4. Server den varme bolognesesausen over den kokte spagettien, og gjerne med et dryss av revet parmesanost på toppen.");
            Console.ReadLine();
        }
        }

        // LUNCHES
        class LunchMenu
        {

            // Oppskrift på eggrøre
            public void RecipieLunch1()
            {
                Console.WriteLine(RecipieLunch1);
                Console.WriteLine("Eggroore");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 4 egg");
                Console.WriteLine("- 100 g røkt laks");
                Console.WriteLine("- 1 ss smør");
                Console.WriteLine("- Salt og pepper etter smak");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. Visp eggene i en bolle og krydre med salt og pepper.");
                Console.WriteLine("2. Smelt smøret i en stekepanne på medium varme.");
                Console.WriteLine("3. Hell de vispede eggene i pannen og la dem steke i noen sekunder før du begynner å røre forsiktig med en slikkepott for å lage myke, kremete eggerøre.");
                Console.WriteLine("4. Når eggerøren begynner å sette seg, tilsett den røkte laksen i små biter og rør forsiktig for å kombinere.");
                Console.WriteLine("5. Fortsett å steke til eggerøren");
                Console.ReadLine();
            }

            // Oppskrift på egg og bacon
            public void RecipieLunch2()
            {
                Console.WriteLine(RecipieLunch2);
                Console.WriteLine("Egg og Bacon");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 4 skiver bacon");
                Console.WriteLine("- 4 egg");
                Console.WriteLine("- Salt og pepper etter smak");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. Stek baconet i en stekepanne på medium høy varme til det er sprøtt. Fjern baconet fra pannen og la det renne av på kjøkkenpapir.");
                Console.WriteLine("2. I samme panne, knekk eggene og stek dem etter ønsket stekegrad (for eksempel speilegg eller eggerøre). Krydre med salt og pepper.");
                Console.WriteLine("3. Server de stekte eggene sammen med det sprøste baconet, og gjerne med en skive ristet brød ved siden av.");
                Console.ReadLine();
            }

            // Oppskrift på lapper
            public void RecipieLunch3()
            {
                Console.WriteLine(RecipieLunch3);
                Console.WriteLine("Lapper");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 2 egg");
                Console.WriteLine("- 2 dl melk");
                Console.WriteLine("- 2 dl hvetemel");
                Console.WriteLine("- 1 ss sukker");
                Console.WriteLine("- 1 ts vaniljesukker");
                Console.WriteLine("- En klype salt");
                Console.WriteLine("- Smør til steking");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. I en stor bolle, visp sammen eggene og melken.");
                Console.WriteLine("2. Sikt inn hvetemel, sukker, vaniljesukker og salt, og rør til du får en jevn røre.");
                Console.WriteLine("3. La røren hvile i ca. 30 minutter for å få luftigere lapper.");
                Console.WriteLine("4. Forvarm en stekepanne på medium varme og smelt litt smør i den.");
                Console.WriteLine("5. Hell en liten mengde røre i pannen for hver lapp, og stek til de er gyldne på begge sider.");
                Console.WriteLine("6. Server lappene varme med ønsket tilbehør, som syltetøy, rømme eller friske bær.");
            }

            // Oppskrift på pannekaker
            public void RecipieLunch4()
            {
                Console.WriteLine(RecipieLunch4);
                Console.WriteLine("Pannekaker");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 2 egg");
                Console.WriteLine("- 3 dl melk");
                Console.WriteLine("- 2 dl hvetemel");
                Console.WriteLine("- 1 ss sukker");
                Console.WriteLine("- 1 ts vaniljesukker");
                Console.WriteLine("- En klype salt");
                Console.WriteLine("- Smør til steking");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. I en stor bolle, visp sammen eggene og melken.");
                Console.WriteLine("2. Sikt inn hvetemel, sukker, vaniljesukker og salt, og rør til du får en jevn røre.");
                Console.WriteLine("3. La røren hvile i ca. 30 minutter for å få luftigere pannekaker.");
                Console.WriteLine("4. Forvarm en stekepanne på medium varme og smelt litt smør i den.");
                Console.WriteLine("5. Hell en liten mengde røre i pannen for hver pannekake, og stek til de er gyldne på begge sider.");
                Console.WriteLine("6. Server pannekakene varme med ønsket tilbehør, som syltetøy, rømme eller friske bær.");
                Console.ReadLine();
            }

            // Oppskrift på rundstykke
            public void RecipieLunch5()
            {
                Console.WriteLine(RecipieLunch5);
                Console.WriteLine("Rundstykke");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("- 500 g hvetemel");
                Console.WriteLine("- 1 ts salt");
                Console.WriteLine("- 1 ts sukker");
                Console.WriteLine("- 25 g fersk gjær eller 7 g tørrgjær");
                Console.WriteLine("- 300 ml lunkent vann");
                Console.WriteLine("");
                Console.WriteLine("Fremgangsmåte:");
                Console.WriteLine("");
                Console.WriteLine("1. I en stor bolle, bland sammen hvetemel, salt og sukker.");
                Console.WriteLine("2. Smuldre gjæren i det lunkne vannet og la det stå i noen minutter til det begynner å skumme.");
                Console.WriteLine("3. Lag en grop i midten av melblandingen og hell i gjærblandingen.");
                Console.WriteLine("4. Rør sammen til en deig begynner å forme seg, og deretter kna deigen på en melet overflate i ca. 10 minutter til den er glatt og elastisk.");
                Console.WriteLine("5. Legg deigen i en lett oljet bolle, dekk den til med plastfolie eller et kjøkkenhåndkle, og la den heve på et lunt sted i ca. 1-2 timer, eller til den har doblet i størrelse.");
                Console.WriteLine("6. Når deigen har hevet, slå den ned for å fjerne luftbobler, og del den i ønsket antall porsjoner for å lage rundstykker.");
                Console.ReadLine();
            }
        }
    }
}

class MenuList
{
    static async Task Pager()
    {
        RecipieMenu menu = new RecipieMenu();

        int page = 1;

        bool running = true;

        while (running)
        {
            Console.Clear();

            if (page == 1)
            {
                Console.WriteLine("=== Start Menu ===");
                Console.WriteLine("");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. List of Recipies");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("6. Exit Program");
            }
            
            else
            {
                Console.WriteLine("=== List of Recipies");
                Console.WriteLine("");
                Console.WriteLine("1. Dessert Menu");
                Console.WriteLine("2. Dinner Menu");
                Console.WriteLine("3. Lunch Menu");
           
            }
        }
    }
} */