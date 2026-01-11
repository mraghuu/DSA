using System;
using ConsoleApp2.Levels;

public class MainClass
{
    private readonly LowT _low = new LowT();
    private readonly MidT _mid = new MidT();
    private readonly HigT _hig = new HigT();
    private readonly StringArray _stringArray = new StringArray();

    

    public void Run()
    {
        _stringArray.FreqStrArrayDict();
    }

    public static void Main(string[] args)
    {
        MainClass program = new MainClass();
        program.Run();
    }


}