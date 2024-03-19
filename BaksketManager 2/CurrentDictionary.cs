using System;
using System.Collections.Generic;


public class CurrentDictionary : ICommandBasket
{
    public static readonly CurrentDictionary Instance;
    public Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
    private CurrentDictionary()
    { }
    static CurrentDictionary()
    {
        Instance = new CurrentDictionary();
    }
    public string GetDictionaryValue(string stringKey)
    {
        return keyValuePairs[stringKey];
    }

    public void SetLeocale(string language)
    {
        keyValuePairs = Locales.GetLocale(language);
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
public static class Locales
{
    private static Dictionary<string, string> Locales_RU = new Dictionary<string, string>()
    {
#region методы
        { "KeyAddProduct","Добавить продукт" },
        { "KeyRemoveProduct","Удалить продукт" },
        { "KeyPrintInfoProducts","Информация о продуктах" },
        { "KeyPrintInfoProductsCategory","Информация о продуктах по категории" },
        { "KeyPrintInfoProductsPrice","Информация о продуктах по цене" },
#endregion
#region ввод данных
        {"KeyNameProduct","имя продукта: " },
        {"KeyPriceProduct","\nцена продукта: " },
        {"KeyCategoryProduct","\nкатегория продукта: " },
        {"KeyInputMinRangeProduct","введите минимальный диапозон продукта: \n" },
        {"KeyInputMaxRangeProduct","введите максимальный диапозон продукта: \n" },
        {"KeyWhatCategoryInput","\nкакую котегорию хотите выбрать? " },
        {"KeyWhatProductWhantRemove","\nкакой продукт вы хотите удалить: " },
        {"KeyWhatProductWhantCheckInformation","\nо каком продукте вы хотите узнать информацию:\n " },
        {"KeyWhatCategoryWhantCheckInformation","Выберите категорию о которой хотите получить инфу: \n" },
        {"KeyWhatWillDo","выберите что вы будете делать: " },
#endregion
#region завершенные выводы
        {"KeyAddProductCompleted","\nпродукт добавлен\n" },
        {"KeyARemoveProductCompleted","\nпродукт удален\n" },
        #endregion
        #region ошибки
        {"","нельзя воодить пустые символы" },
#endregion
    };
    private static Dictionary<string, string> Locales_EN = new Dictionary<string, string>()
    {
        { "KeyAddProduct","Add a product" },
        { "KeyRemoveProduct","Remove a product" },
        { "KeyPrintInfoProducts","Information a products" },
        { "KeyPrintInfoProductsCategory","Product information by category" },
        { "KeyPrintInfoProductsPrice","Product information by price" },

    };

    public static Dictionary<string, string> GetLocale(string locale)
    {
        if (locale == "RU")
        {
            return Locales_RU;
        }
        else
        {
            return Locales_EN;
        }
    }
};
public enum Language
{
    RU = 1,
    En
}