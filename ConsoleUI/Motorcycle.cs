using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("I love cruising on my motorcycle!");
    }
    
    public override void DriveVirtual()
    {
        Console.WriteLine("I'm driving a motorcycle w/ the wind in my face!"); 
    }
}