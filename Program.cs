using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PlenBotLogUploader
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Process currProcess = Process.GetCurrentProcess();
            System.Collections.Generic.List<Process> otherProcesses = Process.GetProcessesByName("PlenBotLogUploader")
                .Where(x => !x.Id.Equals(currProcess.Id))
                .ToList();
            System.Collections.Generic.List<string> args = Environment.GetCommandLineArgs().ToList();
            string localDir = $"{Path.GetDirectoryName(Application.ExecutablePath.Replace('/', '\\'))}\\";
            if (args.Count == 3)
            {
                if (args[1].ToLower().Equals("-update"))
                {
                    if (otherProcesses.Count == 0)
                    {
                        File.Copy(Application.ExecutablePath.Replace('/', '\\'), $"{localDir}{args[2]}", true);
                        _ = Process.Start($"{localDir}{args[2]}", "-finishupdate");
                        return;
                    }
                    else
                    {
                        foreach (Process process in otherProcesses)
                        {
                            try
                            {
                                process.WaitForExit(350);
                                process.Kill();
                            }
                            catch
                            {
                                // do nothing
                            }
                        }
                        File.Copy(Application.ExecutablePath.Replace('/', '\\'), localDir + args[2], true);
                        _ = Process.Start($"{localDir}{args[2]}", "-finishupdate");
                        return;
                    }
                }
            }
            else if (args.Count == 2)
            {
                if (args[1].ToLower().Equals("-finishupdate"))
                {
                    File.Delete(localDir + "PlenBotLogUploader_Update.exe");
                }
                else if (args[1].ToLower().Equals("-resetsettings"))
                {
                    using (RegistryKey registryRun = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
                    {
                        if (registryRun.GetValue("PlenBot Log Uploader") != null)
                        {
                            registryRun.DeleteValue("PlenBot Log Uploader");
                        }
                    }
                    Properties.Settings.Default.Reset();
                }
            }
            if (otherProcesses.Count == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using (FormMain formMain = new FormMain())
                {
                    Application.Run(formMain);
                }
            }
        }
    }
}
