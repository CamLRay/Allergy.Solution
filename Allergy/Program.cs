using System;
using System.Collections.Generic;
using Allergy;
using System.Diagnostics;
using System.Threading;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("What is your Allergy Score?");
    int userScore = int.Parse(Console.ReadLine());
    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
    List<string> userAllergyList = AllergyChecker.AllergyCounter(userScore);
    stopWatch.Stop();
    TimeSpan ts = stopWatch.Elapsed;
    Console.WriteLine("RunTime " + ts);
    foreach (string allergy in userAllergyList)
    {
      Console.WriteLine(allergy);
    }
  }
}