Console.Write("Введите сумму вклада: ");
int deposit = Convert.ToInt32(Console.ReadLine());
if (deposit > 200000)
{
  int sum = (deposit / 100) * 10 + deposit;
  Console.WriteLine($"Сумма вклада вместе с начисленными процентами составит {sum} ");
}
else if (deposit >= 100000 && deposit <= 200000)
{
  int sum = (deposit / 100) * 7 + deposit;
  Console.WriteLine($"Сумма вклада вместе с начисленными процентами составит {sum} ");
}
else
{
  int sum = (deposit / 100) * 5 + deposit;
  Console.WriteLine($"Сумма вклада вместе с начисленными процентами составит {sum} ");
}