using System;
using ConsoleApp2.Levels;

public class MainClass
{
    readonly LowT _low = new LowT();
    readonly MidT _mid = new MidT();
    readonly HigT _hig = new HigT();

    public void Run()
    {
        _low.ReverseString();
    }

    public static void Main(string[] args)
    {
        MainClass program = new MainClass();
        program.Run();
    }

}