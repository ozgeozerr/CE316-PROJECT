using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace BerkazyHalka
{
    public class compilerClass
    {
        public static void javaProject(string javaFilePath)
        {
            string javaPath = @"C:\Users\barca\.jdks\openjdk-20\bin\java.exe";

            // COMPILE
            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = "javac";
            compileProcess.StartInfo.Arguments = javaFilePath;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.Start();
            compileProcess.WaitForExit();

            // EXECUTE
            Process executeProcess = new Process();
            executeProcess.StartInfo.FileName = javaPath;
            executeProcess.StartInfo.Arguments = $"-classpath {Path.GetDirectoryName(javaFilePath)} {Path.GetFileNameWithoutExtension(javaFilePath)}";
            executeProcess.StartInfo.UseShellExecute = false;
            executeProcess.StartInfo.RedirectStandardInput = true;
            executeProcess.StartInfo.RedirectStandardOutput = true;
            executeProcess.Start();

            // PASS THE INPUT
            executeProcess.StandardInput.WriteLine("Barca");
            executeProcess.StandardInput.Flush();

            // CAPTURE OUTPUT
            string javaOutput = executeProcess.StandardOutput.ReadToEnd();

            executeProcess.WaitForExit();

            // DISPLAY OUTPUT
            MessageBox.Show("Output: "+javaOutput, "Java Output (STUDENT)");

            compileProcess.Dispose();
            executeProcess.Dispose();
        }

        public static void cProject(string cFilePath)
        {
            string compileCommand = $"gcc {cFilePath} -o output";

            // Create a process to execute the compile command
            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = "cmd.exe";
            compileProcess.StartInfo.Arguments = $"/c {compileCommand}";
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.RedirectStandardOutput = true;
            compileProcess.StartInfo.RedirectStandardError = true;

            compileProcess.Start();

            // Wait for the process to finish
            compileProcess.WaitForExit();

            // Check if compilation was successful
            if (compileProcess.ExitCode == 0)
            {
                // Create a process to execute the compiled executable
                Process executeProcess = new Process();
                executeProcess.StartInfo.FileName = "output.exe";
                executeProcess.StartInfo.UseShellExecute = false;
                executeProcess.StartInfo.RedirectStandardInput = true;
                executeProcess.StartInfo.RedirectStandardOutput = true;

                // Start the process
                executeProcess.Start();

                // Pass input data to the process if provided
                if (!string.IsNullOrEmpty("Barca"))
                {
                    executeProcess.StandardInput.WriteLine("Barca");
                    executeProcess.StandardInput.Flush();
                    executeProcess.StandardInput.Close();
                }

                // Read output from the process
                string cOutput = executeProcess.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                executeProcess.WaitForExit();

                // Display output in a message box
                MessageBox.Show("Output: " + cOutput, "C Output (STUDENT)");
            }
            else
            {
                MessageBox.Show("Compilation failed: " + compileProcess.StandardError.ReadToEnd());
            }
        }
    }

}
