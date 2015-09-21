using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CPUMinerGUI {
    class MinerSpawner  {

        public static void Spawn(string file, string command, Action<string>onData, Action<string>onError) {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.CreateNoWindow = true;
            psi.ErrorDialog = false;
            psi.FileName = file;
            psi.Arguments = command;

            using (Process process = Process.Start(psi))
            using (ManualResetEvent mreOut = new ManualResetEvent(false),
                mreErr = new ManualResetEvent(false)) {
                process.OutputDataReceived += (o, ee) => { if (ee.Data == null) mreOut.Set(); else onData(ee.Data); };
                process.BeginOutputReadLine();
                process.ErrorDataReceived += (o, ee) => { if (ee.Data == null) mreErr.Set(); else onError(ee.Data); };
                process.BeginErrorReadLine();

                //string line;
                //while (input != null && null != (line = input.ReadLine()))
                //    process.StandardInput.WriteLine(line);

                process.StandardInput.Close();

                process.WaitForExit();

                mreOut.WaitOne();
                mreErr.WaitOne();
                //return process.ExitCode;
            }
        }
    }
}
