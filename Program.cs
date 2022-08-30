{
{
static void main(string[] args);

Console.Write("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

if (number > -100 && number < 100)
{
    Console.WriteLine("Third digital not");
}
else 
{
    if (number < 0)
    {
        number = - 1 * number;
    }
    string thirdDigit = Convert.ToString(number);
    Console.WriteLine(thirdDigit[2]);
}
}
}