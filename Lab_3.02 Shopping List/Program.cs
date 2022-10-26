List<string> shopList = new();

Dictionary<string, decimal> items = new()
{
    ["Apple"] = 1.99m,
    ["Orange"] = 2.99m,
    ["Pear"] = 1.00m,
    ["Banana"] = 4.00m,
    ["Potato"] = 0.99m,
    ["Tomato"] = 1.00m,
    ["Celery"] = 5.00m,
    ["Blueberries"] = 2.00m,
};
Console.WriteLine("Welcome to Aldi. Here's a list of all of our items and prices.");
foreach (var item in items)
{
    Console.WriteLine($"{item.Key} = {item.Value}");
}

jump:
Console.WriteLine();
Console.WriteLine("Enter an item you would like: ");
string userInput = Console.ReadLine();

if (items.ContainsKey(userInput))
{
    Console.WriteLine($"You selected a {userInput} and it cost {items[userInput]}.");
    shopList.Add(userInput);
    Console.WriteLine("Would you like to add another item? Enter: 'Yes' or 'No'");
    string resetResponse = Console.ReadLine();
    if (resetResponse == "Yes")
    {
        goto jump;
    }
    else
    {
        PrintTotal(shopList, items);
    }
}
else
{
    Console.WriteLine("That was not a listed item.");
    goto jump;
}


//Methods below here
void PrintTotal(List<string> shopList, Dictionary<string, decimal> items)
{
    Console.WriteLine("These are the items in your shopping list: ");
    decimal sumTotal = 0;

    
    foreach (string item in shopList)
    {
        Console.WriteLine($"{item} - {items[item]}");
        sumTotal += items[item];
    }
    Console.WriteLine($"Your total price is: {sumTotal}");
}
