// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Net.NetworkInformation;



public class Program {

  static readonly string sport = "Tennis";
  static readonly int age = 25;
  static readonly float timeUsed = 4.25f;
  static byte white = 255;
  public static void Addition(int age, float timeUsed, float age2, byte white){
    var sum = age * timeUsed - age2 * white;
    Console.WriteLine(sport + " cost is: $" + sum);
  }

   public static void Main()
    {
      var age2 = -72.25f;
      var age3 = 72.25;
      var sum = timeUsed * age2;
      var sum2 = timeUsed * age3;
      var sum3 = timeUsed * white;
      var sum4 = age3 * white;
      white = 15;
      Console.WriteLine(age2); //float
      Console.WriteLine(age3); //double
      Console.WriteLine(sum); //float * float = float
      Console.WriteLine(sum2); //float * double = double
      Console.WriteLine(sum3); //float * byte = float
      Console.WriteLine(sum4); //double * byte = double
      Addition(age, timeUsed, age2, white);
      SwapNums();
    }


  public static void SwapNums(){
    int a = 2;
    int b = 6;
    (a, b) = (b, a);
    Console.WriteLine("a: " + a + " and b: " + b);
  }
}