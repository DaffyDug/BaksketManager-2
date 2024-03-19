using System;
public static class Errors
{
    public static void DoubleText()
    {
        Console.WriteLine(BasketManager.basketManager._TEXT.GetDictionaryValue(Keys.KeyCannotEnterEmptyCharacters));
    }
    public static void DoubleEmpty() 
    {
        Console.WriteLine(BasketManager.basketManager._TEXT.GetDictionaryValue(Keys.KeyEmpty));
    }
    public static void Range()
    {
        Console.WriteLine(BasketManager.basketManager._TEXT.GetDictionaryValue(Keys.KeyNotThisRange));
    }
    public static void RemoveProduct()
    {
        Console.WriteLine(BasketManager.basketManager._TEXT.GetDictionaryValue(Keys.KeyFailedRemoveProduct));
    }
}
