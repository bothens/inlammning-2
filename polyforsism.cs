using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Fordon
{
    public string Name;
    public string Typ;

    public virtual void Hyraut()
    {
        Console.WriteLine("Fordon hyrs ut");
    }


}
public class Systemet: Fordon
{

    public override void Hyraut()
    {
        Console.WriteLine("systemet hjälper fordon och hyras ut");
    }

}
public class Kunder
{
    public string Name;
    public int Telefonnummer;

    public void Hyrafordon()
    {
        Console.WriteLine("kunderna hyr fordonen");
    }
}
public class Uthyrning
{
    public string Färg;
    public string pris;

    public void hyrasut()
    {
        Console.WriteLine("uthyrning ser till att fordonern hyrsut");
    }
}
   