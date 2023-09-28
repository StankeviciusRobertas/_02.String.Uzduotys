namespace _04.SwitchCase.Uzduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=========================================");
            //Console.WriteLine("Iveskit savaite dienos skaiciu: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Pirmadienis");
            //        break;
            //    case 2:
            //        Console.WriteLine("Antradienis");
            //        break;
            //    case 3:
            //        Console.WriteLine("Treaciadienis");
            //        break;
            //    case 4:
            //        Console.WriteLine("Ketvirtadienis");
            //        break;
            //    case 5:
            //        Console.WriteLine("Penktadienis");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sestadienis");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sekmadienis");
            //        break;
            //    default:
            //        Console.WriteLine("Ivesta neteisigna diena");
            //        break;
            //}
            //Console.WriteLine("=========================================");

            //Console.WriteLine("Iveskit savo amziu: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //string status = age switch
            //{               
            //    < 0 => "Blogai ivestas amzius",
            //    < 7 => "Vaikas",
            //    < 19 => "Moksleivis",
            //    < 26 => "Studentas",
            //    < 65 => "Darbuotojas",
            //    >= 65 => "Pensininkas",                
            //};
            //Console.WriteLine(status);

            //Console.WriteLine("=========================================");

            //Console.WriteLine("Iveskit menesio numeri: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //var result = month switch
            //{
            //    1 => "Sausis",
            //    2 => "Vasaris",
            //    3 => "Kovas",
            //    4 => "Balandis",
            //    5 => "Geguze",
            //    6 => "Birzelis",
            //    7 => "Liepa",
            //    8 => "Rugpjutis",
            //    9 => "Rugsejos",
            //    10 => "Spalis",
            //    11 => "Lapkritis",
            //    12 => "Gruodis",
            //    _ => "Tokio menesio nera"
            //};
            //Console.WriteLine(result);

            //Console.WriteLine("=========================================");

            //Console.WriteLine("Iveskite kurios figuros plota noretumete apskaiciuoti: kvadrato, apskritimo, trikampio");

            //string figura = Console.ReadLine();

            //switch (figura)
            //{
            //    case "kvadrato":
            //        Console.WriteLine("Iveskit kvadrato 1 krastines ilgi: ");
            //        int lenght = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Iveskit kvadrato 2 krastines ilgi: ");
            //        int lenght2 = Convert.ToInt32(Console.ReadLine());
            //        int sum = lenght * lenght2;
            //        Console.WriteLine($"Kvadrato plotas: {sum}");
            //        break;

            //    case "apskritimo":
            //        Console.WriteLine("Iveskit apskritimo spinduli: ");
            //        double rad = Convert.ToInt32(Console.ReadLine());
            //        double sumOfCircle = Math.PI * rad * rad;
            //        Console.WriteLine($"Apskritimo plotas yra: {sumOfCircle}");
            //        break;

            //    case "trikampio":
            //        Console.WriteLine("Iveskit trikampio pirmos krastines ilgi: ");
            //        double numTriangle = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Iveskit trikampio antros krastines ilgi: ");
            //        double numTriangle2 = Convert.ToInt32(Console.ReadLine());

            //        double sumTriangle = numTriangle * numTriangle2 / 2;
            //        Console.WriteLine($"Trikampio plotas: {sumTriangle}");

            //        break;
            //}
            //Console.WriteLine("=========================================");

            //Console.WriteLine("Iveskit viena is elementu: ugnis, vanduo: ");
            //string element = Console.ReadLine();

            //switch (element)
            //{
            //    case "ugnis":
            //        Console.WriteLine("  /\\");
            //        Console.WriteLine(" /  \\");
            //        Console.WriteLine("/    \\");
            //        Console.WriteLine("------");
            //        Console.WriteLine("  ||");
            //        Console.WriteLine("  ||");
            //        break;

            //    case "vanduo":
            //        Console.WriteLine("     ~ ~ ~");
            //        Console.WriteLine("   ~ ~ ~ ~ ~");
            //        Console.WriteLine(" ~ ~ ~ ~ ~ ~ ~");
            //        Console.WriteLine(" ~ ~ ~ ~ ~ ~ ~");
            //        Console.WriteLine("   ~ ~ ~ ~ ~");
            //        Console.WriteLine("     ~ ~ ~");
            //        break;
            //}
            //Console.WriteLine("=========================================");

            //Console.WriteLine("Galime studijuoti specialybe: matematika,informatika:");
            //string study = Console.ReadLine();

            //switch (study)
            //{
            //    case "matematika":
            //        Console.WriteLine("Iveskite savo matematikos egzamino bala: ");
            //        int vidurkis = Convert.ToInt32(Console.ReadLine());
            //        if (vidurkis > 85)
            //        {
            //            Console.WriteLine("Jus priimtas");
            //        }
            //        break;
            //    case "informatika":
            //        Console.WriteLine("Tam kad mokytis informatikos specialybes atsakykite ar teiginys teisingas irasydami y/n");
            //        Console.WriteLine("Ar programavimo gali mokytis bet kas?");
            //        string answer = Console.ReadLine();
            //        if (answer == "y")
            //        {
            //            Console.WriteLine("jus priimtas");
            //        }
            //        else if (answer == "n")
            //        {
            //            Console.WriteLine("jus nepriimtas");
            //        }
            //        else
            //        {
            //            Console.WriteLine("blogai ivestas atsakymas");
            //        }
            //        break;
            //}
            //Console.WriteLine("=========================================");

            //Console.WriteLine("Iveskit menesio skaiciu: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //string metuLaikas = month switch
            //{
            //    < 1 => "Tokio menesio nera",
            //    < 4 => "Ziemos menuo",
            //    < 7 => "Pavasario menuo",
            //    < 10 => "Vasaros menuo",
            //    < 13 => "Rudens menuo",
            //    _ => "Tokio menesio nera",
            //};
            //Console.WriteLine(metuLaikas);

            //Console.WriteLine("=========================================");

            //Console.WriteLine("Kalkuliatorius, pasirinkime kuri veiskma norite atlikti irasydami: sudetis, atimtis, daugyba, dalyba: ");
            //string veiksmas = Console.ReadLine();
            //Console.WriteLine("iveskit pirma skaiciu:");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Iveskite antra skaiciu: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int sum;
            //switch (veiksmas)
            //{
            //    case "sudetis":
            //        sum = number1 + number2;
            //        Console.WriteLine($"Atsakymas: {sum}");
            //        break;
            //    case "atimtis":
            //        sum = number1 - number2;
            //        Console.WriteLine($"Atsakymas: {sum}");
            //        break;
            //    case "daugyba":
            //        sum = number1 * number2;
            //        Console.WriteLine($"Atsakymas: {sum}");
            //        break;
            //    case "dalyba":
            //        sum = number1 / number2;
            //        Console.WriteLine($"Atsakymas: {sum}");
            //        break;
            //}
            Console.WriteLine("=========================================");

            Console.WriteLine("Iveskite valiuta USD, EUR, GBP, JPY: ");
            string valiuta = Console.ReadLine();                        
            Console.WriteLine("Iveskit suma: ");
            string sumaInput = Console.ReadLine();

            if (double.TryParse(sumaInput, out double suma))
            {
                double USD = 0;
                double EUR = 0;
                double GBP = 0;
                double JPY = 0;

                switch (valiuta.ToLower())
                {
                    case "usd":
                        EUR = suma * 0.95;
                        GBP = suma * 0.82;
                        JPY = suma * 149.17;
                        Console.WriteLine($"Suma EUR: {EUR}");
                        Console.WriteLine($"Suma GBP: {GBP}");
                        Console.WriteLine($"Suma JPY: {JPY}");
                        break;
                    case "eur":
                        USD = suma * 1.06;
                        GBP = suma * 0.87;
                        JPY = suma * 157.43;
                        Console.WriteLine($"Suma EUR: {USD}");
                        Console.WriteLine($"Suma GBP: {GBP}");
                        Console.WriteLine($"Suma JPY: {JPY}");
                        break;
                    case "gbp":
                        USD = suma * 1.21;
                        EUR = suma * 1.15;
                        JPY = suma * 181.14;
                        Console.WriteLine($"Suma EUR: {USD}");
                        Console.WriteLine($"Suma GBP: {EUR}");
                        Console.WriteLine($"Suma JPY: {JPY}");
                        break;
                    case "jpy":
                        USD = suma * 0.0067;
                        EUR = suma * 0.0063;
                        GBP = suma * 0.0055;
                        Console.WriteLine($"Suma EUR: {USD}");
                        Console.WriteLine($"Suma GBP: {EUR}");
                        Console.WriteLine($"Suma JPY: {GBP}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nenurodytas skaicius");
            }

            Console.WriteLine("=========================================");
        }
    }
}