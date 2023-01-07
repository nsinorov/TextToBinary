using System;

string input = Console.ReadLine();

byte[] data = System.Text.Encoding.ASCII.GetBytes(input);

foreach (byte b in data)
{
    Console.Write(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
}
Console.WriteLine();
