// string[] fraudulentOrderIDs = ["A123","B456","C789"];
// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// /* Reassign Value */

// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");

// /* Length */
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


string[] names = ["Alice", "Bob", "Charlie", "Diana"];
foreach (string item in names)
{
   Console.WriteLine(item);
}
int[] barang = [200, 450, 700, 175, 250 ];
int total = 0;
int bin = 0;
foreach (var item in barang)
{
   bin++;
   total += item;
   Console.WriteLine($"Bin : {bin} = {item} items (Running Total: {total})");
}
Console.WriteLine($"We Have {total} items in stock.");