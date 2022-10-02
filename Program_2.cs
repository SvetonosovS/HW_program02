Console.Write("Введите целое первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите целое второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

Console.Write("a=" + userNumber1 + ";" + "b=" + userNumber2 + " -> MAX:");

if (userNumber1>userNumber2)
{
    Console.WriteLine(userNumber1);
}
else
{
    Console.WriteLine(userNumber2);
}