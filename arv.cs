using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Personal
{
    public string Name;
    public string Adress;
    public int Id;
}

public class Chef: Personal
{

    public void Plans()
    {
        Console.WriteLine("the chef plans out the work for the staff");
    }


}
 
public class Kock: Personal
{

    public void cook()
    {
        Console.WriteLine("the kock cooks the food");
    }
}

public class Servitor: Personal
{

    public void servera()
    {
        Console.WriteLine("the servitor serve the food to the customers");
    }


}

public class Meny
{
    public string Mat;
    public string Name;

    public void look()
    {
        Console.WriteLine("menyn is for looking at food options");
    }
}
 public class Kund
{
    public string Name;
    public string Adress;
    public int Id;

    public void Order()
    {
        Console.WriteLine("the kund orders the food");
    }
}







