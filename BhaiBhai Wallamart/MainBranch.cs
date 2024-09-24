using System;
namespace BBWallmart;

class MainBranch
{
    Dictionary<string, int> item_list = new Dictionary<string, int>(); // item_name : stock_left
    List<string> suppliers_list = new List<string>(); // names_of_supplier

    public void add_item(string item)
    {
        Console.WriteLine("Which product do you want to add ?");
        suppliers s = new suppliers();

    }
}