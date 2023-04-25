// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
int Ack (int first, int second)
{
  if (first == 0)
    return second + 1;
  else
    if ((first != 0) && (second == 0))
      return Ack(first - 1, 1);
    else
      return Ack(first - 1, Ack(first, second - 1));
}

System.Console.WriteLine(Ack(3,2));