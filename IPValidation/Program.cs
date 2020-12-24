using System;
using System.Linq;
using System.Net;

namespace IPValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_valid_IP("137.255.156.100"));
            Console.WriteLine(is_valid_IP("12.34.56 .1"));
            Console.WriteLine(is_valid_IP("12.34.56.-1"));
            Console.WriteLine(is_valid_IP("0.0.0.0"));
        }
        
        public static bool is_valid_IP(string ipAddress)
        {
            if (ipAddress.Count(d => d == '.') != 3 || ipAddress.Contains(' '))
                return false;

            foreach (var d in ipAddress.Split('.'))
            {
                if (!UInt32.TryParse(d, out var number) || number > 255 || d[0] == '0' && d.Length > 1)
                    return false;
            }
            
            return true;
            
            // Or use the built-in IPAddress library 
            IPAddress ip;
            bool validIp = IPAddress.TryParse(ipAddress, out ip);
            return validIp && ip.ToString() == ipAddress;
        }
    }
}