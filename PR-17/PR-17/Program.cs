using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace PR_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task01");
            key.SetValue("inputValue", 123);
            key.Close();

            RegistryKey readKey = Registry.CurrentUser.OpenSubKey(@"PR_17\task01");
            int value = (int)readKey.GetValue("inputValue");
            readKey.Close();

            //Registry.CurrentUser.DeleteSubKeyTree(@"PR_17");
            //Console.WriteLine("Ключ PR_17 удален из реестра.");
        }
    }
}
