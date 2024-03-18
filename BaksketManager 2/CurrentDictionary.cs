using System;
using System.Collections.Generic;


class CurrentDictionary : ICommandBasket
{
    public static readonly CurrentDictionary class1;
    public Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
    private CurrentDictionary()
    { }
    static CurrentDictionary()
    {
        class1 = new CurrentDictionary();
    }
    public string GetDictionaryValue(string stringKey)
    {
        return keyValuePairs[stringKey];
    }

    public void SetLeocale(string language)
    {
        if (language == "RU")
        {
            keyValuePairs = Locales.Locales_RU;
        }
        else if (language == "EN")
        {
            keyValuePairs = Locales.Locales_EN;
        }
    }

    public void Run()
    {
        Array collection = Enum.GetValues(typeof(Language));
        MenuLanguage();
        string language;
        if (InputHelper.Input("выберите язык: \n", 1, collection.Length, out int inputvalue))
        {
            if (inputvalue == 1)
            {
                language = "RU";
                SetLeocale(language);
            }
            else if (inputvalue == 2)
            {
                language = "EN";
                SetLeocale(language);
            }
        }
    }
    public void MenuLanguage()
    {
        Array collection = Enum.GetValues(typeof(Language));
        System.Collections.IList list = collection;
        for (int i = 0; i < list.Count; i++)
        {
            object item = list[i];
            Console.WriteLine($"{i + 1}--{item}");
        }
    }
}
static class Locales
{
    public static Dictionary<string, string> Locales_RU = new Dictionary<string, string>()
    {
        { "KeyAddProduct","Добавить продукт" },
        { "KeyRemoveProduct","Удалить продукт" },
        { "KeyPrintInfoProducts","Информация о продуктах" },
        { "KeyPrintInfoProductsCategory","Информация о продуктах по категории" },
        { "KeyPrintInfoProductsPrice","Информация о продуктах по цене" },
    };
    public static Dictionary<string, string> Locales_EN = new Dictionary<string, string>()
    {
        { "KeyAddProduct","Add a product" },
        { "KeyRemoveProduct","Remove a product" },
        { "KeyPrintInfoProducts","Information a products" },
        { "KeyPrintInfoProductsCategory","Product information by category" },
        { "KeyPrintInfoProductsPrice","Product information by price" },
    };
};
public enum Language
{
    RU = 1,
    En
}