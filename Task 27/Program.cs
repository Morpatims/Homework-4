Console.Clear();
PromptNumber();
void PromptNumber()
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int sum = GetDigitSum(number);
    Console.WriteLine("Sum of digits: " + sum);
}

int GetDigitSum(int number)
{
    int sum = 0;
    number = Math.Abs(number);
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}