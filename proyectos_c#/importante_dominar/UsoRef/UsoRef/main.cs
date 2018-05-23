
using System;

public class Product
{
    private string ItemName;
    private int ItemID;

    public Product(string name, int newID)
    {
        this.ItemName = name;
        this.ItemID = newID;
    }

    public string getItemName()
    {
        return this.ItemName;    
    }
    public void setItemName(string ItemName)
    {
        this.ItemName = ItemName;
    }
    public int getItemID() 
    { 
        return this.ItemID; 
    }
    public void setItemID(int newID)
    {
        this.ItemID = newID;
    }
}

// Output: 
//Original values in Main.  Name: Fasteners, ID: 54321

//Back in Main.  Name: Stapler, ID: 12345

public class RefExample2
{
    public static void ChangeByReference(ref Product itemRef)
    {
        // The following line changes the address that is stored in  
        // parameter itemRef. Because itemRef is a ref parameter, the
        // address that is stored in variable item in Main also is changed.
        itemRef = new Product("Stapler", 99999);

        // You can change the value of one of the properties of
        // itemRef. The change happens to item in Main as well.
        itemRef.setItemID(12345);
    }

    public static void Main(string[] args)
    {
        // Declare an instance of Product and display its initial values.
        Product item = new Product("Fasteners", 54321);
       
        Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
            item.getItemName(), item.getItemID());

        // Send item to ChangeByReference as a ref argument.
        ChangeByReference(ref item);

        Console.WriteLine("Back in Main.  Name: {0}, ID: {1}\n",
            item.getItemName(), item.getItemID());
        Console.ReadKey(true);
    }
}

