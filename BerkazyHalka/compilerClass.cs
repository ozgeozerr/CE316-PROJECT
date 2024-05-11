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
            string compilerPath = @"C:\Users\barca\mingw64\bin\gcc.exe"; // Replace this with the actual path to your compiler
            string compileCommand = $"{compilerPath} {cFilePath} -o output";
            MessageBox.Show("Compile Command: " + compileCommand);

            // COMPILE
            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = "cmd.exe";
            compileProcess.StartInfo.Arguments = $"/c {compileCommand}";
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.RedirectStandardOutput = true;
            compileProcess.StartInfo.RedirectStandardError = true;

            compileProcess.Start();
            compileProcess.WaitForExit();

            if (compileProcess.ExitCode == 0)
            {
                MessageBox.Show("Compilation successful!");

                // EXECUTE
                Process executeProcess = new Process();
                executeProcess.StartInfo.FileName = "output.exe";
                executeProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(cFilePath); // Set the working directory
                executeProcess.StartInfo.UseShellExecute = false;
                executeProcess.StartInfo.RedirectStandardInput = true;
                executeProcess.StartInfo.RedirectStandardOutput = true;

                executeProcess.Start();

                // PASS THE INPUT
                if (!string.IsNullOrEmpty("Barca"))
                {
                    executeProcess.StandardInput.WriteLine("Barca");
                    executeProcess.StandardInput.Flush();
                    executeProcess.StandardInput.Close();
                }

                // CAPTURE OUTPUT
                string cOutput = executeProcess.StandardOutput.ReadToEnd();
                executeProcess.WaitForExit();

                // DISPLAY OUTPUT
                MessageBox.Show("Output: " + cOutput, "C Output (STUDENT)");
            }
            else
            {
                MessageBox.Show("Compilation failed:\n" + compileProcess.StandardError.ReadToEnd());
            }
        }

        public static string tırnakEkleBoslukVarsa(string path)
        {
            return !string.IsNullOrWhiteSpace(path) ?
                path.Contains(" ") && (!path.StartsWith("\"") && !path.EndsWith("\"")) ?
                    "\"" + path + "\"" : path :
                    string.Empty;
        }

        //this function will be used 
        public static boolean compareOutputs(String lecturersOutput, String studentsOutput)
        {
            // Trim the spaces to avoid inconsistencies
            lecturersOutput = lecturersOutput.trim();
            studentsOutput = studentsOutput.trim();

            // Make the strings all lowercase to avoid inconsistencies
            lecturersOutput = lecturersOutput.toLowerCase();
            studentsOutput = studentsOutput.toLowerCase();

            // Compare the strings
            return studentsOutput.equals(lecturersOutput);
        }
    }

}
