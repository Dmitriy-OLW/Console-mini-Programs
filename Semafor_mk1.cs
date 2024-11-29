using System;
using System.Threading;

class Program
{
    static SemaphoreSlim semaphore1 = new SemaphoreSlim(0, 1);
    static SemaphoreSlim semaphore2 = new SemaphoreSlim(0, 1);
    static SemaphoreSlim semaphore3 = new SemaphoreSlim(0, 1);
    static ManualResetEventSlim waitForGH = new ManualResetEventSlim(false);

    static void Main()
    {
        Thread A = new Thread(ProcessA);
        A.Start();
        A.Join();
    }

    static void ProcessA()
    {
        Console.WriteLine("Процесс  A запущен.");
        Thread B = new Thread(ProcessB);
        Thread C = new Thread(ProcessC);
        Thread I = new Thread(ProcessI);
        Thread J = new Thread(ProcessJ);

        B.Start();
        C.Start();
        I.Start();
        J.Start();

        semaphore1.Wait();
        semaphore1.Release();
    }

    static void ProcessB()
    {
        Console.WriteLine("Процесс  B запущен.");
        Thread D = new Thread(ProcessD);
        Thread E = new Thread(ProcessE);
        Thread F = new Thread(ProcessF);

        D.Start();
        E.Start();
        F.Start();

        semaphore1.Release();
        semaphore2.Wait();
        semaphore2.Release();
    }

    static void ProcessC() 
    { 
        Console.WriteLine("Процесс  C запущен."); 
    }

    static void ProcessI() 
    { 
        Console.WriteLine("Процесс  I запущен."); 
    }

    static void ProcessJ()
    {
        Console.WriteLine("Процесс  J запущен.");
        Thread G = new Thread(ProcessG);
        Thread H = new Thread(ProcessH);

        G.Start();
        H.Start();

        waitForGH.Wait();
        ProcessK();
    }

    static void ProcessD()
    { 
        Console.WriteLine("Процесс  D запущен."); 
    }

    static void ProcessE() 
    {
        Console.WriteLine("Процесс  E запущен."); 
    }

    static void ProcessF()
    {
        Console.WriteLine("Процесс  F запущен.");
        semaphore2.Release();
    }

    static void ProcessG()
    {
        Console.WriteLine("Процесс  G запущен.");
        waitForGH.Set();
    }

    static void ProcessH()
    {
        Console.WriteLine("Процесс  H запущен.");
        waitForGH.Set();
    }

    static void ProcessK()
    {
        Console.WriteLine("Процесс  K запущен. Программа завершена.");
        Console.ReadKey();
    }
}


