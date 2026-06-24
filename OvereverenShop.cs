using System;

// Base class voor elke shop upgrade.
// Child classes bepalen wat er gekoct word.
internal class OvereverenShop
{
    protected string _nameOfItem;
    protected float _costOfItem;
    protected string _infoOfItem;

    public OvereverenShop(string nameOfItem, float costOfItem, string infoOfItem)
    {
        _nameOfItem = nameOfItem;
        _costOfItem = costOfItem;
        _infoOfItem = infoOfItem;
        _infoOfItem = infoOfItem;
    }

    public string GetName()
    {
        return _nameOfItem;
    }

    public virtual void ShowItem()
    {
        Console.WriteLine($"{_nameOfItem}");
        Console.WriteLine($"Het kost: {_costOfItem}");
        Console.WriteLine(_infoOfItem);
        Console.WriteLine();
    }

    public virtual void BuyUpgrade(ref float money, ref float multiplier, ref float autoIncome)
    {
        Console.WriteLine("Deze upgrade heeft nog geen effect.");
    }
}
