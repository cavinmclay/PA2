//main
//Extra(s):
//Can convert any currency to any currency

string userInput = GetMenuChoice();

while(userInput != "3"){
    MenuRoute(userInput);
    userInput = GetMenuChoice();
}

System.Console.WriteLine("Thank you for using our application!"); 

static string GetMenuChoice(){
    System.Console.WriteLine("\nWelcome to the program. Please choose from the options below.\n1 Currency Exchange \n2 Shipping Invoice \n3 Exit");
    return Console.ReadLine();
}

//main

static void MenuRoute(string userInput)
{
    if (userInput == "1")
    {
        CurrencyExchange();
    }

    else if (userInput == "2")
    {
        ShippingInvoice();
    }

    else if (userInput == "3")
    {

    }

    else 
    {
        System.Console.WriteLine("Invalid input, please try again");
    }

}

static void CurrencyExchange()
{
    System.Console.WriteLine("Welcome to the currency exchange!");
    double yenToUSD = 0.0064;
    double yuanToUSD = 0.14;
    double poundToUSD = 1.22;
    double doubloonsToUSD = 8.40;
    double dinarToUSD = 0.0074;

    System.Console.WriteLine("\n1 Japanese Yen \n2 Chinese Yuan \n3 British Pound \n4 Doubloon \n5 Algerian Dinar \n6 USD");
    System.Console.WriteLine("\nConvert from :");
        int startCurrency = int.Parse(Console.ReadLine());
    System.Console.WriteLine("\nConvert to :");
        int endCurrency = int.Parse(Console.ReadLine());
    System.Console.WriteLine("\nWhat amount would you like to convert");
        int amountConverted = int.Parse(Console.ReadLine());

double usdAmount = 0;
switch (startCurrency)
{
    case 1:
        usdAmount = amountConverted * yenToUSD;
        break;
    case 2:
        usdAmount = amountConverted * yuanToUSD;
        break;
    case 3:
        usdAmount = amountConverted * poundToUSD;
        break;
    case 4:
        usdAmount = amountConverted * doubloonsToUSD;
        break;
    case 5:
        usdAmount = amountConverted * dinarToUSD;
        break;
    case 6:
        usdAmount = amountConverted;
        break;
    default:
        System.Console.WriteLine("Invalid input, please try again");
    return;

}

double result = 0;
switch (endCurrency)
{
    case 1:
        result = usdAmount / yenToUSD;
        break;
    case 2:
        result = usdAmount / yuanToUSD;
        break;
    case 3:
        result = usdAmount / poundToUSD;
        break;
    case 4:
        result = usdAmount / doubloonsToUSD;
        break;
    case 5:
        result = usdAmount / dinarToUSD;
        break;
    case 6:
        result = usdAmount;
        break;
    default:
        System.Console.WriteLine("Invalid input, please try again");
        return;
}
System.Console.WriteLine($"Your converted amount is: {result}");

    
}

static void ShippingInvoice()
{
    double ton = 220.40;
    double perishable = 230;
    double expressShipping = 1.25;
    System.Console.WriteLine("\nHow many total tons is your order?");
        int totalTons = int.Parse(Console.ReadLine());
    System.Console.WriteLine("\nIs your order perishable? \n1.Yes \n2.No");
        int totalPerishable = int.Parse(Console.ReadLine());
    System.Console.WriteLine("\nIs your order express shipping? \n1.Yes \n2.No");
        int totalExpress = int.Parse(Console.ReadLine());

double firstnum = 0;
switch (totalPerishable)
{
    case 1:
        firstnum = ton * totalTons + totalTons * perishable;
        break;
    case 2:
        firstnum = ton * totalTons;
        break;
    default:
        System.Console.WriteLine("Invalid input, please try again.");
        return;
}

double shippingTotal = 0;
switch (totalExpress)
{
    case 1:
        shippingTotal = firstnum * expressShipping;
        break;
    case 2:
        shippingTotal = firstnum;
        break;
    default:
        System.Console.WriteLine("Invalid input, please try again.");
        return;
}

System.Console.WriteLine("Has any amount been paid towards this order? 1.Yes 2.No");
int paid = int.Parse(Console.ReadLine());
switch(paid){
    case 1:
    System.Console.WriteLine("What amount has been paid?");
    double amount = double.Parse(Console.ReadLine());
        if(amount > shippingTotal){
            System.Console.WriteLine("\nThere was an error when calculating your remaining total. You seem to have entered more than the total amount. Please try again");
            return;
        }
    shippingTotal -= amount;

        System.Console.WriteLine($"\nThe remaining cost of your order is {shippingTotal}");
        break;
    case 2:
        System.Console.WriteLine($"The total cost of your order is {shippingTotal}");
        break;
    default:
        System.Console.WriteLine("Invalid input, please try again.");
        return;
}

}