System.Console.WriteLine("Введите число: ");
double Number = Convert.ToInt32(Console.ReadLine());


for (double i = 1; i <= Number; i++)
{
   
    double i2 = Math.Pow(i, 3);
    System.Console.Write("\t" + i2);
  
}