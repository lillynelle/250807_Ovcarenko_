using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== VELKÁ KALKULAČKA ===");
            Console.WriteLine("1. Základní operace");
            Console.WriteLine("2. Obrazce (obsah a obvod)");
            Console.WriteLine("3. Tělesa (objem a povrch)");
            Console.WriteLine("4. Konec");
            Console.Write("Zadej volbu: ");
            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1": ZakladniOperace(); break;
                case "2": Obrazce(); break;
                case "3": Telesa(); break;
                case "4": return;
                default: Console.WriteLine("Neplatná volba."); break;
            }

            Console.WriteLine("\nStiskni Enter pro pokračování...");
            Console.ReadLine();
        }
    }

    // 1. ZÁKLADNÍ OPERACE
    static void ZakladniOperace()
    {
        Console.Clear();
        Console.WriteLine("== ZÁKLADNÍ OPERACE ==");
        Console.WriteLine("Operace: sčítáni, odčítaání, násobení, dělení, umocnění, odmocnění");
        Console.Write("Zadej operaci: ");
        string od = Console.ReadLine();

        double a = 0, b = 0, vysledek = 0;
        bool chyba = false;

        if (od == "odmocnění")
        {
            Console.Write("Zadej číslo: ");
            a = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Nelze odmocnit záporné číslo.");
                chyba = true;
            }
            else
            {
                vysledek = Math.Sqrt(a);
            }
        }
        else
        {
            Console.Write("První číslo: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Druhé číslo: ");
            b = double.Parse(Console.ReadLine());

            switch (od)
            {
                case "sčítání": vysledek = a + b; break;
                case "odčítání": vysledek = a - b; break;
                case "násobení": vysledek = a * b; break;
                case "dělení": vysledek = (b != 0) ? a / b : double.NaN; break;
                case "umocnění": vysledek = Math.Pow(a, b); break;
                default: Console.WriteLine("Neznámá operace."); chyba = true; break;
            }
        }

        if (!chyba)
            Console.WriteLine($"Výsledek: {vysledek}");
    }

    // 2. OBRAZCE
    static void Obrazce()
    {
        Console.Clear();
        Console.WriteLine("== OBRAZCE ==");
        Console.WriteLine("1. Čtverec");
        Console.WriteLine("2. Obdélník");
        Console.WriteLine("3. Kruh");
        Console.WriteLine("4. Trojúhelník");
        Console.Write("Zadej volbu: ");
        string tvar = Console.ReadLine();

        switch (tvar)
        {
            case "1":
                Console.Write("Strana a: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Obsah: {a * a}");
                Console.WriteLine($"Obvod: {4 * a}");
                break;

            case "2":
                Console.Write("Šířka: ");
                double w = double.Parse(Console.ReadLine());
                Console.Write("Výška: ");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"Obsah: {w * h}");
                Console.WriteLine($"Obvod: {2 * (w + h)}");
                break;

            case "3":
                Console.Write("Poloměr r: ");
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"Obsah: {Math.PI * r * r:F2}");
                Console.WriteLine($"Obvod: {2 * Math.PI * r:F2}");
                break;

            case "4":
                Console.Write("Základna: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Výška: ");
                double v = double.Parse(Console.ReadLine());
                Console.Write("Strana 1: ");
                double s1 = double.Parse(Console.ReadLine());
                Console.Write("Strana 2: ");
                double s2 = double.Parse(Console.ReadLine());
                Console.Write("Strana 3: ");
                double s3 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Obsah: {(b * v) / 2}");
                Console.WriteLine($"Obvod: {s1 + s2 + s3}");
                break;

            default:
                Console.WriteLine("Neznámý obrazec.");
                break;
        }
    }

    // 3. TĚLESA
    static void Telesa()
    {
        Console.Clear();
        Console.WriteLine("== TĚLESA ==");
        Console.WriteLine("1. Krychle");
        Console.WriteLine("2. Kvádr");
        Console.WriteLine("3. Koule");
        Console.WriteLine("4. Válec");
        Console.WriteLine("5. Kužel");
        Console.WriteLine("6. Jehlan");
        Console.Write("Zadej volbu: ");
        string telo = Console.ReadLine();

        switch (telo)
        {
            case "1":
                Console.Write("Strana a: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Objem: {Math.Pow(a, 3)}");
                Console.WriteLine($"Povrch: {6 * a * a}");
                break;

            case "2":
                Console.Write("Šířka: ");
                double w = double.Parse(Console.ReadLine());
                Console.Write("Výška: ");
                double h = double.Parse(Console.ReadLine());
                Console.Write("Hloubka: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine($"Objem: {w * h * d}");
                Console.WriteLine($"Povrch: {2 * (w * h + w * d + h * d)}");
                break;

            case "3":
                Console.Write("Poloměr r: ");
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"Objem: {(4.0 / 3.0) * Math.PI * Math.Pow(r, 3):F2}");
                Console.WriteLine($"Povrch: {4 * Math.PI * r * r:F2}");
                break;

            case "4":
                Console.Write("Poloměr r: ");
                double rv = double.Parse(Console.ReadLine());
                Console.Write("Výška h: ");
                double hv = double.Parse(Console.ReadLine());
                Console.WriteLine($"Objem: {Math.PI * rv * rv * hv:F2}");
                Console.WriteLine($"Povrch: {2 * Math.PI * rv * (rv + hv):F2}");
                break;

            case "5":
                Console.Write("Poloměr r: ");
                double rk = double.Parse(Console.ReadLine());
                Console.Write("Výška h: ");
                double hk = double.Parse(Console.ReadLine());
                double s = Math.Sqrt(rk * rk + hk * hk);
                Console.WriteLine($"Objem: {(1.0 / 3.0) * Math.PI * rk * rk * hk:F2}");
                Console.WriteLine($"Povrch: {Math.PI * rk * (rk + s):F2}");
                break;

            case "6":
                Console.Write("Základna a: ");
                double az = double.Parse(Console.ReadLine());
                Console.Write("Výška v: ");
                double vz = double.Parse(Console.ReadLine());
                Console.WriteLine($"Objem: {(1.0 / 3.0) * az * az * vz}");
                Console.WriteLine($"Povrch: {az * az + 2 * az * Math.Sqrt((az / 2) * (az / 2) + vz * vz)}");
                break;

            default:
                Console.WriteLine("Neznámé těleso.");
                break;

                
        }
    }
}

