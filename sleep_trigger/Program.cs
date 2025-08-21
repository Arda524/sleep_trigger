using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;


namespace sleep_trigger
{
    class Program
    {
        [DllImport("powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                   _                             __  __                      _       
     /\           | |                           |  \/  |     /\             (_)      
    /  \   _ __ __| | __ ___      ____ _ _ __   | \  / |    /  \   _ __ ___  _ _ __  
   / /\ \ | '__/ _` |/ _` \ \ /\ / / _` | '_ \  | |\/| |   / /\ \ | '_ ` _ \| | '_ \ 
  / ____ \| | | (_| | (_| |\ V  V / (_| | | | | | |  | |  / ____ \| | | | | | | | | |
 /_/    \_\_|  \__,_|\__,_| \_/\_/ \__,_|_| |_| |_|  |_| /_/    \_\_| |_| |_|_|_| |_|
");
            Console.WriteLine("--------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("🔹 Available Commands:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" sleep → Suspend (Sleep Mode)");
            Console.WriteLine(" off   → Shutdown");
            Console.WriteLine(" reboot→ Restart");
            Console.WriteLine(" clear → Clear console");
            Console.WriteLine(" quit  → Exit");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nSay Magic Word> ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower().Trim();

                switch(input)
                {
                    case "sleep":
                        Console.WriteLine("Putting the laptop to sleep...");

                        Thread.Sleep(1000); // Sleep for 1 second
                        SetSuspendState(false, false, false);
                        break;

                    case "off":
                        Console.WriteLine("Shutting down the computer...");

                        Thread.Sleep(1000); // Sleep for 1 second
                        Process.Start("shutdown", "/s /t 0");
                        break;

                    case "reboot":
                        Console.WriteLine("Restarting the computer...");
                        Thread.Sleep(1000); // Sleep for 1 second
                        Process.Start("shutdown", "/r /t 0");
                        break;

                    case "quit":
                        Console.WriteLine("Exiting the program...");
                        return;

                    case "clear":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@"
                   _                             __  __                      _       
     /\           | |                           |  \/  |     /\             (_)      
    /  \   _ __ __| | __ ___      ____ _ _ __   | \  / |    /  \   _ __ ___  _ _ __  
   / /\ \ | '__/ _` |/ _` \ \ /\ / / _` | '_ \  | |\/| |   / /\ \ | '_ ` _ \| | '_ \ 
  / ____ \| | | (_| | (_| |\ V  V / (_| | | | | | |  | |  / ____ \| | | | | | | | | |
 /_/    \_\_|  \__,_|\__,_| \_/\_/ \__,_|_| |_| |_|  |_| /_/    \_\_| |_| |_|_|_| |_|
");
                        Console.WriteLine("--------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine("🔹 Available Commands:");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" sleep → Suspend (Sleep Mode)");
                        Console.WriteLine(" off   → Shutdown");
                        Console.WriteLine(" reboot→ Restart");
                        Console.WriteLine(" clear → Clear console");
                        Console.WriteLine(" quit  → Exit");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------------");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n❌ Invalid command. Try: sleep, off, reboot, quit");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------------");
                        break;
                }
            }
        }
    }
    
}
