using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IWshRuntimeLibrary;

namespace MrGoldbergSteamCracker
{
    class Program
    {
        static void CreateSteamLoaderShortcut()
        {
            WshShell shell = new WshShell();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //Desktop Folder :D
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(desktop + @"\Power And Revolution 2022 Edition.lnk");
            shortcut.Description = "Power and Revolution 2022 Edition(Cracked by Triomonitor using MrGoldbergEmulator)";
            shortcut.TargetPath = @"D:\Games\Power and Revolution 2022 Edition\steamclient_loader.exe";
            shortcut.IconLocation = @"D:\Games\Power And Revolution 2022 Edition\_start.ico";
            shortcut.WorkingDirectory = @"D:\Games\Power And Revolution 2022 Edition";
            shortcut.Save();
            //Shortcut :D
        }
        static void ExtractColdClientToPnR2022()
        {
            if (System.IO.File.Exists("PnR2022EditionCrack.zip")) //PnR2022Edition Crack by Triomonitor using MrGoldbergEmulator :D
            {
                ZipFile.ExtractToDirectory("PnR2022EditionCrack.zip", @"D:\Games\Power and Revolution 2022 Edition");
            }
            else
            {
                throw new Exception("ZipFile Crack not Founded");
            }
        }
        static void Main(string[] args)
        {
            if (args[0].StartsWith("-apply_crack")) //Apply Crack To Current Game(PnR2022Edition) :D
            {
                Console.WriteLine("Finding Steam Game in Games Folder...");
                Thread.Sleep(5000);
                Console.Clear();
                if(Directory.Exists(@"D:\Games\Power And Revolution 2022 Edition"))
                {
                    Console.WriteLine("Applying Crack to PnR 2022 Edition...");
                    Thread.Sleep(12000);
                    ExtractColdClientToPnR2022();
                    CreateSteamLoaderShortcut();
                }
                else
                {
                    throw new Exception("PnR2022Edition Not Found");
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Use Arguments -apply_crack");
            }
        }
    }
}
