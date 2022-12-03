switch (15)
{
    case 1:
        pb1();
        break;
    case 2:
        pb2();
        break;
    case 3:
        pb3();
        break;
    case 4:
        pb4();
        break;
    case 5:
        pb5();
        break;
    case 6:
        pb6();
        break;
    case 7:
        pb7();
        break;
    case 8:
        pb8();
        break;
    case 9:
        pb9();
        break;
    case 10:
        pb10();
        break;
    case 11:
        pb11();
        break;
    case 12:
        pb12();
        break;
    case 13:
        pb13();
        break;
    case 14:
        pb14();
        break;
    case 15:
        pb15();
        break;
    case 16:
        pb16();
        break;
    case 17:
        pb17();
        break;
    case 18:
        pb18();
        break;
    case 19:
        pb19();
        break;
    case 20:
        pb20();
        break;
    case 21:
        pb21();
        break;


}

void pb1()
{
    Console.WriteLine("1: Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.");
    try
    {
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());
        float x = -(b / (float)a);
        if (a == 0)
            x = 0;
        Console.WriteLine($"ax + b = 0 => x = {x}");
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb1();
    }

}

void pb2()
{
    Console.WriteLine("2: Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");
    try
    {
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("c: ");
        int c = int.Parse(Console.ReadLine());
        float delta = b * b * 4 * a * c;
        float x1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
        float x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
        if (a == 0) { x1 = -(c / (float)b); x2 = x1; }
        Console.WriteLine($"ax^2 + bx + c = 0 => x1 = {x1}; x2 = {x2}");

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb2();
    }

}

void pb3()
{
    Console.WriteLine("3: Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
    try
    {
        Console.WriteLine("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("k: ");
        int k = int.Parse(Console.ReadLine());
        if (n % k == 0)
            Console.WriteLine($"{n} se divide cu {k}");
        else
            Console.WriteLine($"{n} nu se divide cu {k}");


    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb3();
    }

}

bool isBisect(int year)
{
    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
                return true;

        }
        else
            return true;
    }
    return false;
}

void pb4()
{
    Console.WriteLine(": Detreminati daca un an y este an bisect.");
    try
    {
        Console.WriteLine("year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine($"Anul {year} {(isBisect(year) ? "este" : "nu este")} bisect.");

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb4();
    }

}

void pb5()
{
    Console.WriteLine("5: Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");
    try
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter which digit to get: ");
        int k = int.Parse(Console.ReadLine());

        int p = (int)Math.Pow(10, k) / 10;

        int digit = n / p % 10;

        Console.WriteLine(p > n ? $"Numarul {n} nu are {k} cifre!" : $"{(k == 1 ? "Prima" : $"A {k}-a")} cifra a lui {n} este {digit}.");

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb5();
    }

}

void pb6()
{
    Console.WriteLine("6: Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
    try
    {
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("c: ");
        int c = int.Parse(Console.ReadLine());
        if (a + b > c && b + c > a && a + c > b)
        {
            Console.WriteLine($"{a}, {b} si {c} pot fi lungimile laturilor unui triunghi.");
        }
        else
        {
            Console.WriteLine($"{a}, {b} si {c} nu pot fi lungimile laturilor unui triunghi.");
        }


    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb6();
    }

}

void pb7()
{
    Console.WriteLine("7: (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.");
    try
    {
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write($"Valorile {a}, {b} au fost inversate ");
        int aux = a;
        a = b;
        b = aux;
        Console.WriteLine($"devenind a={a} si b={b}.");


    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb7();
    }

}

void pb8()
{
    Console.WriteLine("8: (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
    try
    {
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write($"Valorile {a}, {b} au fost inversate ");
        a += b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"devenind a={a} si b={b}.");


    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb8();
    }

}

void pb9()
{
    Console.WriteLine("9: Afisati toti divizorii numarului n.");
    try
    {
        Console.WriteLine("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Divizorii lui {n} sunt :");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }


    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb9();
    }

}

void pb10()
{
    Console.WriteLine("10: Test de primalitate: determinati daca un numar n este prim.");
    try
    {
        Console.WriteLine("n: ");
        int n = int.Parse(Console.ReadLine());
        bool prim = true;
        if (n == 1)
            prim = false;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                prim = false;
        }
        if (prim)
            Console.WriteLine($"{n} este prim.");
        else
            Console.WriteLine($"{n} nu este prim");


    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb10();
    }

}

void pb11()
{
    Console.WriteLine("11: Afisati in ordine inversa cifrele unui numar n.");
    try
    {
        Console.WriteLine("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Cifrele lui n in ordine inversa sunt :");
        if (n == 0)
            Console.Write(n);
        while (n > 0)
        {
            Console.Write(n % 10);
            n /= 10;
        }


    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb11();
    }

}

void pb12()
{
    Console.WriteLine("12: Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
    try
    {
        Console.WriteLine("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b:");
        int b = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % n == 0)
                count++;
        }
        Console.WriteLine($"In intervalul [{a}, {b}] sunt {count} nr divizibile cu {n}");



    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb12();
    }

}

void pb13()
{
    Console.WriteLine("13: Determianti cati ani bisecti sunt intre anii y1 si y2.");
    try
    {
        Console.WriteLine("y1: ");
        int y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("y2: ");
        int y2 = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = y1; i <= y2; i++)
        {
            if (isBisect(i))
                count++;
        }
        Console.WriteLine($"Intre anii {y1} si {y2} {(count == 1 ? "este 1 singur an bisect" : $"sunt {count} ani bisecti.")}");



    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb13();
    }

}

void pb14()
{
    Console.WriteLine("14: Determianti daca un numar n este palindrom.");
    try
    {
        Console.WriteLine("n: ");
        int n = int.Parse(Console.ReadLine());
        int rev = 0;
        int aux = n;
        while (aux > 0)
        {
            rev = rev * 10 + aux % 10;
            aux = aux / 10;
        }
        if (n == rev)
            Console.WriteLine($"{n} este palindrom.");
        else
            Console.WriteLine($"{n} nu este palindrom.");



    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb14();
    }
}

void swap(ref int a, ref int b)
{
    int aux = a;
    a = b;
    b = aux;
}

void pb15()
{
    Console.WriteLine("15: Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
    try
    {
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("c: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Numerele in ordine crescatoare sunt :");
        if (a > c)
            swap(ref a, ref c);
        if (a > b)
            swap(ref a, ref b);
        if (b > c)
            swap(ref b, ref c);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb15();
    }
}

void pb16()
{
    Console.WriteLine("16: Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
    try
    {
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("c: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("d: ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("e: ");
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine("Numerele in ordine crescatoare sunt :");

        if (b < a)
            swap(ref b, ref a);
        if (c < b)
        {
            swap(ref c, ref b);
            if (b < a)
                swap(ref b, ref a);
        }

        if (d < c)
        {
            swap(ref d, ref c);
            if (b < a)
                swap(ref b, ref a);
            if (c < b)
            {
                swap(ref c, ref b);
                if (b < a)
                    swap(ref b, ref a);
            }
        }

        if (e < d)
        {
            swap(ref e, ref d);
            if (d < c)
            {
                swap(ref d, ref c);
                if (b < a)
                    swap(ref b, ref a);
                if (c < b)
                {
                    swap(ref c, ref b);
                    if (b < a)
                        swap(ref b, ref a);
                }
            }
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb16();
    }
}

void pb17()
{
    Console.WriteLine("17: Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
    try
    {
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());
        int n = a;
        int m = b;
        while (m != n)
        {
            if (n < m)
                n += a;
            else
                m += b;
        }
        Console.WriteLine($"Cel mai mic multiplu comun: {m}");
        while (a != b)
        {
            if (a > b)
                a -= b;
            else
                b -= a;
        }
        Console.WriteLine($"Cel mai mare divizor comun: {a}");

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb17();
    }
}

void pb18()
{
    Console.WriteLine("18: Afisati descompunerea in factori primi ai unui numar n.");
    try
    {
        Console.WriteLine("n: ");
        int n = int.Parse(Console.ReadLine());
        int div = 2;
        int putere;

        while (n > 1)
        {
            if (n % div == 0)
            {
                putere = 0;
                while (n % div == 0)
                {
                    putere += 1;
                    n /= div;
                }
                Console.Write($"{div}^{putere} x ");
            }
            div++;
        }
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb18();
    }

}

void pb19()
{
    Console.WriteLine("19: Determinati daca un numar e format doar cu 2 cifre care se pot repeta.");
    try
    {
        Console.WriteLine("n: ");
        int n = int.Parse(Console.ReadLine());
        int[] cif = new int[10];
        int cifCount = 0;
        Array.Fill(cif, 0);
        while (n > 0)
        {
            cif[n % 10] = 1;
            n /= 10;
        }

        foreach (int i in cif)
        {
            if (cif[i] == 1)
                cifCount++;

        }

        if (cifCount == 2)
            Console.WriteLine($"Numarul este format doar din 2 cifre.");
        else
            Console.WriteLine($"Numarul nu este format doar din 2 cifre.");


    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb19();
    }
}

void pb20()
{
    Console.WriteLine("20: Afisati fractia m/n in format zecimal, cu perioada intre paranteze");
    try
    {
        Console.WriteLine("m: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Format zecimal:");
        int wholePart, fractPart;
        wholePart = m / n;
        fractPart = m % n;
        Console.Write($"{wholePart},");
        int cif, rest;
        List<int> resturi = new List<int>();
        List<int> cifre = new List<int>();
        resturi.Add(fractPart);
        bool period = false;
        do
        {
            cif = fractPart * 10 / n;
            cifre.Add(cif);
        
            rest = fractPart * 10 % n;
            if (!resturi.Contains(rest))
            {
                resturi.Add(rest);
            }
            else
            {
                period = true;
                break;
            }
            fractPart = rest;
        } while (rest != 0);

        if (!period)
        {
            foreach (int item in cifre)
            {
                Console.Write(item);
            }
        }
        else
        {
            for (int i = 0; i < resturi.Count; i++)
            {
                if (resturi[i] == rest)
                {
                    Console.Write("(");
                }
                Console.Write(cifre[i]);
            }
            Console.WriteLine(")");
        }

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter integers only!");
        pb20();
    }

}



void pb21()
{
    Console.WriteLine("21: Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\".");
    int guess = 512;
    int min = 1;
    int max = 1024;
    Console.WriteLine("Think of a number...and click any key...");
    Console.ReadLine();
    while (true)
    {
        Console.WriteLine($"Guess: {guess}");
        Console.WriteLine($"Am I right? (y/n)");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.WriteLine($"Great! The number is {guess}.");
            break;
        }
        else if (answer == "n")
        {
            Console.WriteLine($"Is the number grater than {guess}? (y/n)");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                min = guess;
                guess = (guess + max) / 2;
            }
            else
            {
                max = guess;
                guess = (min + guess) / 2;
            }
        }
        else
            Console.WriteLine("Please answer only with the given choice!");
    }
}

