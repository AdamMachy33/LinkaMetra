using LinkaMetra ;
Metralinka linkametra = new Metralinka();

string[] poleLinkaA = {"Nemocnice Motol","Petřiny","Nádraží Veleslavín","Bořislavka","Dejvicka","Hradčanská","Malostranská","Staroměstká","Můstek","Muzeum","Náměstí Míru"
, "Jiřího z Poděbrad","FLORA","ŽELIVSKÉHO","SKALKA","DEPO HOSTIVAŘ"};

string[] poleLinkaB = {"Zličín","STODŮLKY","LUKA","LUŽINY","¨HŮRKA","NOVÉ BUTOVICE","JINONICE","RADLICKÁ","SMÍCHOVKSÉ NÁDRAŽÍ","ANDĚL","KARLOVO NÁMĚSTÍ","národní třída",
"MŮSTEK","NÁMĚSTÍ REPUBLIKY","FLORENC","KŘÍŽKOVA","INVALIDOVNA","PALMOVKA","ČESKOMORAVSKÁ","VYSOČANSKÁ","KOLBENOVA","HLOUBĚTÍN","RAJSKÁ ZAHRADA","ČERNÝ MOST"};

string[] poleLinkaC = { "Letnany", "Prosek", "Střížkov", "Ládví", "Kobylisy", "Nádraží Holešovice", "Vltavská", "Florenc", "Hlavní Nádrazí", "Muzeum", "I.P Pavlova", "Vyšehrad", "Pražského Povstaní", "Pankrác", "Budějovická", "Kačerov", "Roztyly", "chodov", "Opatov ", "háje ", };

Console.WriteLine("zadej linku kterou chčeš využít ");
string volbalinky = Console.ReadLine();
if (volbalinky == "A")
{
    Metralinka LinkaA = new Metralinka() { NázevLinky = "A", Barva = "zelená", aktivni = true, stanice = poleLinkaA };
    LinkaA.nastavlinku();
    Console.WriteLine("chcete vypsat 1. všechny stanice 2. první a poslední 3. zjistit čas cesty");
    string volba = Console.ReadLine();
    if (volba =="1")
    {
        LinkaA.VypisStanice();
    }
    else if (volba =="2")
    {
        LinkaA.VypisPrvniPosledni();
    }
    else if (volba == "3")
    {
        LinkaA.CasCesty();
    }

}
if (volbalinky == "B")
{
    Metralinka LinkaB = new Metralinka() { NázevLinky = "B", Barva = "červená", aktivni = true, stanice = poleLinkaB };
    LinkaB.nastavlinku();
    Console.WriteLine("chcete vypsat 1. všechny stanice 2. první a poslední  3. zjistit čas cesty ");
    string volba = Console.ReadLine();
    if (volba == "1")
    {
        LinkaB.VypisStanice();
    }
    else if (volba == "2")
    {
        LinkaB.VypisPrvniPosledni();
    }
    else if (volba == "3")
    {
        LinkaB.CasCesty();
    }

}
if (volbalinky == "C")
{
    Metralinka LinkaC = new Metralinka() { NázevLinky = "C", Barva = "žlutá", aktivni = true, stanice = poleLinkaC };
    LinkaC.nastavlinku();
    Console.WriteLine("chcete vypsat 1. všechny stanice 2. první a poslední  3. zjistit čas cesty ");
    string volba = Console.ReadLine();
    if (volba == "1")
    {
        LinkaC.VypisStanice();
    }
    else if (volba == "2")
    {
        LinkaC.VypisPrvniPosledni();
    }
    else if (volba == "3")
    {
        LinkaC.CasCesty();
    }

}

