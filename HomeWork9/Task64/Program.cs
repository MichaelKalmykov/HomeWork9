int valueM = InputUserValue("Введите значение числа M ");
int valueN = InputUserValue("Введите значение числа N ");
PrintValueOfMFromN(valueM, valueN);

void PrintValueOfMFromN (int valueM, int valueN)
{
    Console.Write("Ряд между числами M и N: (");
    if (valueM <= valueN)
    {
        while (valueM <= valueN)
        {
           Console.Write(" " + valueM + " "); 
           valueM++;
        }
    }
    else if (valueM >= valueN)
    {
        while (valueM >= valueN)
        {
           Console.Write(" " + valueN + " ");
           valueN++;
        }
    }
    Console.Write(")");
}
int InputUserValue ( string  input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}
