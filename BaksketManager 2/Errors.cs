using System;
public static class Errors
{
    private const string Text = "";
    private const string Empty = "пусто!";
    private const string NotThisRange = "нету такого диапозона!";
    private const string FailedRemoveProduct = "не удалось удалить продукт";


    public static void DoubleText()
    {
        Console.WriteLine(Text);
    }
    public static void DoubleEmpty() 
    {
        Console.WriteLine(Empty);
    }
    public static void Range()
    {
        Console.WriteLine(NotThisRange);
    }
    public static void RemoveProduct()
    {
        Console.WriteLine(FailedRemoveProduct);
    }
}
