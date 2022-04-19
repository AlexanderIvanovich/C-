/*
//Задача 1 Выдает квадрат целого числа 
 
Console.Write("input itger mumber:");
int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;

Console.WriteLine("Result is " + result);
*/

/*
//Задача 2 приним 2 числа , провер 1число является ли квадратом 2числа

Console.WriteLine("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

 if(num1 == num2 * num2)
    Console.WriteLine("First number is quad of second number");
  else
    Console.WriteLine("First number is not a quad of second number"); 
  
  */ 

  // Задача 3 Номер дня недели - название дня недели

/*

Console.WriteLine("Input number of weekdey: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day < 1 )
{
  Console.WriteLine("incorrect number of day!");
}
else
{
  if(day == 1)
      Console.WriteLine("It's Mondey");
  if(day == 2)
      Console.WriteLine("It's Tuesday");  
  if(day == 3)
      Console.WriteLine("It's Wednesday");
  if(day == 4)
      Console.WriteLine("It's Thursday");
  if(day == 5)
      Console.WriteLine("It's Friday");
  if(day == 6)
      Console.WriteLine("It's Saturday");
  if(day == 7)
      Console.WriteLine("It's Sunday");

}

// Задача 4 перебор от - к +  числа
/*
Console.Write("input itger mumber:");
int num = Convert.ToInt32(Console.ReadLine());
int current;
 
if(num < 0)
{
  current = num;
  num = num * (-1);
}
else
{
  current = -1 * num;
}

while (current <= num)
{
  Console.Write(current + " ");
  current++;
}

*/

//Задача 5 на вход трехзначное число на выходе последнюю цифру числа

/*

Console.Write("input itger mumber:");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
   Console.WriteLine("Incorrect number");
else 
{
  int a = num % 10;
   Console.WriteLine("Resulted number is " + a);
}     

*/  
