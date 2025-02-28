using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        string localIP = GetLocalIPAddress();
        Console.WriteLine($"Local IP Address: {localIP}");
        Console.ReadLine();
    }

    static string GetLocalIPAddress()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString(); // Return IPv4 address
            }
        }
        throw new Exception("No network adapters with an IPv4 address in the system!");
    }
}
