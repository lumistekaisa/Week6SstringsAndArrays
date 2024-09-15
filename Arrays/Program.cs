
string[] fruitBasket = { "apples", "bananas", "oranges" };

Console.WriteLine($"There are {fruitBasket.Length} fruit in your basket.");

//Console.WriteLine($"In your basket there are {fruitBasket[0]}, {fruitBasket[1]} and {fruitBasket[2]}.");

for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}

fruitBasket[0] = "pears";
fruitBasket[2] = "melons";

//Console.WriteLine($"I made some changes in your basket and now you have {fruitBasket[0]}, {fruitBasket[1]} and {fruitBasket[2]}.");

for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}
