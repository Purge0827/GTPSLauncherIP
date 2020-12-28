using System;
using System.IO;

namespace GTPSLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GTPSLauncherPC by iFanpS";
            Console.WriteLine("GTPSLauncher by iFanpS and ITWILIGHT");
            Console.WriteLine("RUN ADMINISTRATOR first to use this program");
            Console.WriteLine("Do not include url, include your private server IP's");
            String ipaddress = Console.ReadLine();
            Console.WriteLine("GTPS IP is: " + ipaddress + "?");
            String[] hostEntries = new String[2];
            String path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
            hostEntries[0] = ipaddress + " growtopia1.com";
            hostEntries[1] = ipaddress + " growtopia2.com";
            for(int i = 0; i < 2; i++)
            {
                File.AppendAllText(path, hostEntries[i]+"\n");
            }
            Console.WriteLine("[ + ] Host edited, please click any key to close.");
            Console.ReadLine();
        }
    }
}

