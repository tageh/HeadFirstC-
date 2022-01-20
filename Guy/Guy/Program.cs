using System;

namespace Guy;

public class Program
{
    public static void Main(string[] args)
    {
        Guy Joe = new Guy("Joe", 100);

        Joe.WriteMyInfo();

        Joe.GiveCash(-20);

        Joe.ReciveCash(910);
        Joe.WriteMyInfo();


    }
}