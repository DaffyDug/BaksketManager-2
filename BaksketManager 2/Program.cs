using System;
class Program
{
    static void Main(string[] args)
    {
        CurrentDictionary.Instance.SetLeocale("RU");
        ICommandBasket[] CommandBaskets = new ICommandBasket[]
        {
        new AddProduct(),
        new RemoveProduct(),
        new PrintInfo(),
        new PrintInfoCategoryProduct(),
        new GetProductRangePrice(),
        CurrentDictionary.Instance,
        }; 
        while (true)
        {
            ShowMenu(CommandBaskets);
            if (InputHelper.Input(BasketManager.basketManager._TEXT.GetDictionaryValue(Keys.KeyWhatWillDo), 1, CommandBaskets.Length, out int inputvalue))
            {
                CommandBaskets[inputvalue - 1].Run();
            }
        }
    }
    static void ShowMenu(ICommandBasket[] CommandBaskets)
    {
        for (int i = 0; i < CommandBaskets.Length; i++)
        {
            ICommandBasket item = CommandBaskets[i];
            Console.WriteLine($"{i + 1}--{item.Description}");
        }
    }
}