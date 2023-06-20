Console.Clear();
DegreeOfIncrease();
void DegreeOfIncrease()
{
    Console.Write("Enter the value for A: ");
    int A = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the value for B: ");
    int B = Convert.ToInt32(Console.ReadLine());

    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }

    Console.WriteLine("The result is: " + result);
}