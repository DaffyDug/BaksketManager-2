using System;
class Program
{
    static void Main(string[] args)
    {
        ICommandBasket[] CommandBaskets = new ICommandBasket[]
        {
        new AddProduct(),
        new RemoveProduct(),
        new PrintInfo(),
        new PrintInfoCategoryProduct(),
        new GetProductRangePrice()
        };
        while (true)
        {
            ShowMenu(CommandBaskets);
            if (InputHelper.Input("выберите что вы будете делать: ", 1, CommandBaskets.Length, out int inputvalue))
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
            Console.WriteLine($"{i + 1}--{item}");
        }
    }
}