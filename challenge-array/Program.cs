string[] fraudulentOrder = ["B123","B235","A345","C15","B177","G3003","C235","B179"];

foreach (var order in fraudulentOrder)
{
   if (order.StartsWith("B"))
   {
      Console.WriteLine($"Order By Letter B: {order}");
   }
}