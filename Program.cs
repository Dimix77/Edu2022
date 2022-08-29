Console.Write("Enter three digital number");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = 0;
if (number < 0)
{
    secondDigit = -1 * number % 100 / 10;

}
else 
{
    secondDigit = number % 100 / 10;
}
Console.WriteLine(secondDigit);
