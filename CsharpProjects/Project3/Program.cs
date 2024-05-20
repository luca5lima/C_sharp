// /*
// string[] fraudulentOrderIDs = new string[3];
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";
// */
// string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

// Console.WriteLine($"\nFirst: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// // fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}\n");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.\n");

//##########################################################
/*
string[] names = {"Rowena", "Robin", "Bao", "Matheus"};
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/
//##########################################################
/*
int[] inventory = {200, 450, 700, 175, 250};
int soma = 0;
int i = 0;
foreach (int product in inventory)
{
    soma = soma + product;
    i = i + 1;
    Console.WriteLine($"Bin: {i} = {product} items (Running total: {soma})");
}
Console.WriteLine($"\nWe have {soma} items in inventory.");
*/
//##########################################################

string[] orderIDs = {
    "B123",    "C234",     "A345",    
    "C15" ,    "B177",    "G3003",
    "C235",    "B179"
};

foreach (string IDs in orderIDs)
{
    if (IDs.StartsWith("B"))
    {
        Console.WriteLine($"IDs com a letra B: {IDs}");
    }
}
