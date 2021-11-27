// See https://aka.ms/new-console-template for more information
using BasicProgram;

Console.WriteLine("\tEnter any key to run and n to End the program!!!");
char choice=Convert.ToChar(Console.ReadLine());
while (choice != 'n')
{

    Console.WriteLine("\t(((((Choose any one!)))))");
    Console.WriteLine("\t(((((1.Leap Year)))))");
    Console.WriteLine("\t(((((2.Prime Factors)))))");
    Console.WriteLine("\t(((((3.Harmonic Numb)))))");
    Console.WriteLine("\t(((((4.Even Odd)))))");
    Console.WriteLine("\t(((((1.LeapYear)))))");
    Console.WriteLine("\t(((((5.Greatest among 3)))))");
    Console.WriteLine("\t(((((6.Power of 2)))))");
    Console.WriteLine("\t(((((7.Qoutient and Rem)))))");
    Console.WriteLine("\t(((((8.Swapping)))))");
    Console.WriteLine("\t(((((9.Vowel Or Consonant)))))");
    Console.WriteLine("\t(((((10.Flip Coin    )))))))))");
    int n = Convert.ToInt32(Console.ReadLine());
    switch (n)
    {


        case 1:
            LeapYear leapYear = new LeapYear();
            leapYear.Year();
            break;
        case 2:
            PrimeFactors obj = new PrimeFactors();
            obj.Prime();
            break;
        case 3:
            HarmonicNumber hn = new HarmonicNumber();
            hn.Harmonic();
            break;
        case 4:
            EvenOdd eo = new EvenOdd();
            eo.EvenOrOdd();
            break;
        case 5:
            ThreeNumComparison TNC = new ThreeNumComparison();
            TNC.GreatestNum();
            break;
        case 6:
            PowerOfTwo pt = new PowerOfTwo();
            pt.TwoPower();
            break;
        case 7:
            QuotientAndRemainder qr1 = new QuotientAndRemainder();
            qr1.QAndR();
            break;
        case 8:
            SwappingNumbers sw = new SwappingNumbers();
            sw.swap();
            break;
        case 9:
            VowelOrConsonent VC = new VowelOrConsonent();
            VC.VowelOrCons();
            break;
        case 10:
            FlipCoin fc = new FlipCoin();
            fc.Flip_coin();
            break;
    }
    Console.WriteLine("\tEnter any key to run and n to End the program!!!");
     choice = Convert.ToChar(Console.ReadLine());
}