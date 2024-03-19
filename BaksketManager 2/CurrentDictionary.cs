using System;
using System.Collections.Generic;
public class CurrentDictionary : ICommandBasket
{
    public static readonly CurrentDictionary Instance;
    public Dictionary<Keys, string> keyValuePairs = new Dictionary<Keys, string>();
    public string Description => BasketManager.basketManager._TEXT.GetDictionaryValue(Keys.KeySettingsForTranslateProgramm);
    private CurrentDictionary()
    { }
    static CurrentDictionary()
    {
        Instance = new CurrentDictionary();
    }
    public string GetDictionaryValue(Keys keys)
    {
        return keyValuePairs[keys];
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
    private static Dictionary<Keys, string> Locales_RU = new Dictionary<Keys, string>()
    {
        #region методы
                { Keys.KeyAddProduct,"Добавить продукт" },
                { Keys.KeyRemoveProduct,"Удалить продукт" },
                { Keys.KeyPrintInfoProducts,"Информация о продуктах" },
                { Keys.KeyPrintInfoProductsCategory,"Информация о продуктах по категории" },
                { Keys.KeyPrintInfoProductsPrice,"Информация о продуктах по цене" },
                { Keys.KeySettingsForTranslateProgramm,"настройки для переводв программы" },
        #endregion
        #region ввод данных
                {Keys.KeyNameProduct,"имя продукта: " },
                {Keys.KeyPriceProduct,"\nцена продукта: " },
                {Keys.KeyCategoryProduct,"\nкатегория продукта: " },
                {Keys.KeyInputMinRangeProduct,"введите минимальный диапозон продукта: \n" },
                {Keys.KeyInputMaxRangeProduct,"введите максимальный диапозон продукта: \n" },
                {Keys.KeyWhatCategoryInput,"\nкакую котегорию хотите выбрать? " },
                {Keys.KeyWhatProductWhantRemove,"\nкакой продукт вы хотите удалить: " },
                {Keys.KeyWhatProductWhantCheckInformation,"\nо каком продукте вы хотите узнать информацию:\n " },
                {Keys.KeyWhatCategoryWhantCheckInformation,"Выберите категорию о которой хотите получить инфу: \n" },
                {Keys.KeyWhatWillDo,"выберите что вы будете делать: " },
        #endregion
        #region завершенные выводы
                {Keys.KeyAddProductCompleted,"\nпродукт добавлен\n" },
                {Keys.KeyARemoveProductCompleted,"\nпродукт удален\n" },
        #endregion
        #region ошибки
                {Keys.KeyCannotEnterEmptyCharacters,"нельзя воодить пустые символы" },
                {Keys.KeyEmpty,"пусто!" },
                {Keys.KeyNotThisRange,"нету такого диапозона!" },
                {Keys.KeyFailedRemoveProduct,"не удалось удалить продукт" }
        #endregion
    };
    private static Dictionary<Keys, string> Locales_EN = new Dictionary<Keys, string>()
    {
        #region методы
                { Keys.KeyAddProduct,"Add a product" },
                { Keys.KeyRemoveProduct,"Remove a product" },
                { Keys.KeyPrintInfoProducts,"Information a products" },
                { Keys.KeyPrintInfoProductsCategory,"Product information by category" },
                { Keys.KeyPrintInfoProductsPrice,"Product information by price" },
                {Keys.KeySettingsForTranslateProgramm,"Settings For Translate Programm" },
                #endregion
        #region ввод данных
                {Keys.KeyNameProduct,"Name Product: " },
                {Keys.KeyPriceProduct,"\nPrice Product: " },
                {Keys.KeyCategoryProduct,"\nCategory Product: " },
                {Keys.KeyInputMinRangeProduct,"Input Min Range Product: \n" },
                {Keys.KeyInputMaxRangeProduct,"Input Max Range Product: \n" },
                {Keys.KeyWhatCategoryInput,"\nWhat Category Input? " },
                {Keys.KeyWhatProductWhantRemove,"\nWhat Product Whant Remove: " },
                {Keys.KeyWhatProductWhantCheckInformation,"\nWhat Product Whant Check Information:\n " },
                {Keys.KeyWhatCategoryWhantCheckInformation,"What Category Whant Check Information: \n" },
                {Keys.KeyWhatWillDo,"What Will Do: " },
                #endregion
        #region завершенные выводы
                {Keys.KeyAddProductCompleted,"\nAdd Product Completed\n" },
                {Keys.KeyARemoveProductCompleted,"\nARemove Product Completed\n" },
                #endregion
        #region ошибки
                {Keys.KeyCannotEnterEmptyCharacters,"Cannot Enter Empty Characters" },
                {Keys.KeyEmpty,"Empty!" },
                {Keys.KeyNotThisRange,"Not This Range!" },
                {Keys.KeyFailedRemoveProduct,"Failed Remove Product" }
                #endregion
    };
    public static Dictionary<Keys, string> GetLocale(string locale)
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