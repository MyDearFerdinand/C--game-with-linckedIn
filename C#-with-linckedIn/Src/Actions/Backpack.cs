using System.Security.Cryptography.X509Certificates;

namespace OOPAdventure;

public class Backpack : Action
{
    private readonly IInvertory _invertory;

    public Backpack(IInvertory invertory)
    {
        _invertory = invertory;
    }

    public override string Name => Text.Language.Backpack;

    public override void Execute(string[] args)
    {
        var items = _invertory.InvertoryList;

        if(items.Length == 0) 
        {
            Console.WriteLine(Text.Language.BackpackError);

            return;
        }

        var list = Text.Language.JoinedWordList(items, Text.Language.And); 

        Console.WriteLine(Text.Language.BackpackDescription , list);
    }
}
