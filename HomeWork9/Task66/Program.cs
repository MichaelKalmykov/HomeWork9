int valueM = InputUserValue("Введите значение числа M ");
int valueN = InputUserValue("Введите значение числа N ");
PrintValueOfMFromN(valueM, valueN);

void PrintValueOfMFromN (int valueM, int valueN)
{
    int summ = 0;
    if (valueM <= valueN)
    {
        while (valueM <= valueN)
        { 
           summ += valueM;
           valueM++;
        }
    }
    else if (valueM >= valueN)
    {
        while (valueM >= valueN)
        {
           summ += valueN;
           valueN++;
        }
    }
    Console.Write("Сумма чисел между M и N: " + summ);
}
int InputUserValue ( string  input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

