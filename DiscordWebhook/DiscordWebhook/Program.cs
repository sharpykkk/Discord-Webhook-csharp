using System;
using System.Management;

namespace DiscordWebhook
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WeebHook dcWeb = new WeebHook())
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                foreach (ManagementObject managementObject in mos.Get())
                {
                    String OSName = managementObject["Caption"].ToString();
                    dcWeb.ProfilePicture = ""; //url profile picture
                    dcWeb.UserName = ""; //webhook username 
                    dcWeb.WebHook = ""; //webhook url
                    dcWeb.SendMessage("Hello World!"); //webhook message
                }
            }
            Console.ReadKey();
        }
    }
}
