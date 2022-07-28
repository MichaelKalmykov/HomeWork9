
int valueM = InputUserValue("Введите значение числа M ");
int valueN = InputUserValue("Введите значение числа N ");
AckermanFunction(valueM, valueN);
Console.WriteLine(AckermanFunction(valueM, valueN));

int InputUserValue ( string  input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}
int AckermanFunction(int valueM, int valueN)
{
  if (valueM == 0)
    return valueN + 1;
  else
    if ((valueM != 0) && (valueN == 0))
      return AckermanFunction(valueM - 1, 1);
    else
      return AckermanFunction(valueM - 1, AckermanFunction(valueM, valueN - 1));
}