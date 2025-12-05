using System;
using ConsoleApp2.Levels;

public class MainClass
{
    LowT _low = new LowT();
    MidT _mid = new MidT();
    HigT _hig = new HigT();

    public void Run()
    {
        _low.MaxInArray();
    }

    public static void Main(string[] args)
    {
        MainClass program = new MainClass();
        program.Run();
    }

}