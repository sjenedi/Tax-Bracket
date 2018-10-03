using System;

/**
 * @author Sami Jenedi
 * class Program will compute a basic, estimated tax for a given single filer’s income.
 */
public class Program
{
  public static void Main()
  {
    // Retrieve the tax and display the tax.
    Console.WriteLine("2017 income tax: {0:C}",
    ComputeTax(GetIncome()));
  }
  static decimal GetIncome()
  {
    Console.Write("Enter 2017  income: $");
    decimal income = Convert.ToDecimal(Console.ReadLine());

    return income;
  }

  static decimal ComputeTax(decimal income)
  {
    decimal tax;

    if (income > 0 && income <= 9325)
    {
      tax = income * 0.10m;
    }
    else if (income > 9325 && income <= 37950)
    {
      tax = ((income - 9325) * 0.15m) + (9325 * 0.10m);
    }
    else if (income > 37950 && income <= 91900)
    {
      tax = ((income - 37950) * 0.25m) + ((37950 - 9325) * 0.15m) +
        (9325 * 0.10m);
    }
    else if (income > 91900 && income <= 191650)
    {
      tax = ((income - 91900) * 0.28m) + ((91900 - 37950) * 0.25m) +
        ((37950 - 9325) * 0.15m) + (9325 * 0.10m);
    }
    else if (income > 191650 && income <= 416700)
    {
      tax = ((income - 191650) * 0.33m) + ((191650 - 91900) * 0.28m) +
        ((91900 - 37950) * 0.25m) +
        ((37950 - 9325) * 0.15m) + (9325 * 0.10m);
    }
    else if (income > 416700 && income <= 418400)
    {
      tax = ((income - 416700) * 0.35m) + ((416700 - 191650) * 0.33m) + 
        ((191650 - 91900) * 0.28m) + ((91900 - 37950) * 0.25m) +
        ((37950 - 9325) * 0.15m) + (9325 * 0.10m);
    }
    else
    {
      tax = ((income - 418400) * 0.396m) + ((418400 - 416700) * 0.35m) + 
        ((416700 - 191650) * 0.33m) + ((191650 - 91900) * 0.28m) +
        ((91900 - 37950) * 0.25m) + ((37950 - 9325) * 0.15m) + (9325 * 0.10m);
    }
    return tax;
  }
}

