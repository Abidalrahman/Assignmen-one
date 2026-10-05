int price;
int quantity;
int total = 0;
int finaltotal = 0;
string moor;

do
{
    Console.WriteLine("Enter the product price :");
    price = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the product quantity :");
    quantity = Convert.ToInt32(Console.ReadLine());
    total = price * quantity;
    Console.WriteLine($"total : {total}");
    finaltotal = total + finaltotal;
    Console.WriteLine("Do you want to add more ? (Yes , No)");
    moor=Console.ReadLine();
    moor=moor.ToLower();
} while (moor == "yes");

Console.WriteLine($"final total : {finaltotal}");