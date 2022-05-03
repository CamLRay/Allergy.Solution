using System;
using System.Collections.Generic;
using System.Linq;


namespace Allergy
{
  public class AllergyChecker
  {
    static Dictionary<int, string> allergyDict = new Dictionary<int, string>() { {1,"eggs"}, {2,"peanuts"}, {4,"shellfish"}, {8,"strawberries"},{16,"tomatoes"},{32,"chocolate"},{64,"pollen"},{128,"cats"}};
  
    public static List<string> AllergyCounter(int score)
    {
      List<string> listOfAllergy = new List<string>() {};
      if(score == 0)
      {
        listOfAllergy.Add("no known allergies");
      } else if(score > 255)
      {
        listOfAllergy.Add("enter a valid score");
      } else
      {
        for (int i = allergyDict.Count - 1; i >= 0; i--) 
        {
          if (score == 0)
          {
            break;
          }
          if (score >= allergyDict.ElementAt(i).Key)
          {
            score -= allergyDict.ElementAt(i).Key;
            listOfAllergy.Add(allergyDict.ElementAt(i).Value);
          }
        }
      }
      return listOfAllergy;
    }
  }
}