using ToDoList;
using ToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList
{
  class ToDoList
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Start();
    }

    public static void Start()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? Add/View");
      string userResponse = Console.ReadLine();

      if (userResponse.ToUpper() == "ADD")
      {
        Console.WriteLine("Enter the description of your to-do item: ");
        Item newItem = new Item(Console.ReadLine());
      }
      else if (userResponse.ToUpper() == "VIEW")
      {
      List<Item> viewStuff = (Item.GetAll());
      
      foreach (Item thisItem in viewStuff)
      {
        Console.WriteLine(thisItem.Description);
      }
      }
      else
      {
        Console.WriteLine("Please enter either 'Add' or 'View'");
      }
      Start();
    }
  }
}