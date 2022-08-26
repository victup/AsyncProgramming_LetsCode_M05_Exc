using System.Diagnostics;
using System;
using static System.Console;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {

        Stopwatch stopwatch = new();
        stopwatch.Start();

        var tarefa1 = LavarLouca();
        var tarefa2 = LavarRoupa();
        var tarefa3 = FazerJantar();

        await tarefa1;
        await tarefa2;
        await tarefa3;

        stopwatch.Stop();

        WriteLine($"Todo o processo durou: {stopwatch.ElapsedMilliseconds} ms");

    }

    static async Task LavarLouca()
    {
        WriteLine($"Inicio: Lavar louça - Thread: {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(2000);
        WriteLine("Fim: Lavar louça");
    }

    static async Task LavarRoupa()
    {
        WriteLine($"Inicio: Lavar roupa - Thread: {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(3000);
        WriteLine("Fim: Lavar roupa");
    }

    static async Task FazerJantar()
    {
        WriteLine($"Inicio: Fazer o jantar - Thread: {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(5000);
        WriteLine("Fim: Fazer o jantar");
    }
}