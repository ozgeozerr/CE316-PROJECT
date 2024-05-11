using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace BerkazyHalka
{
    public class compilerClass
    {
        public static string javaProject(string javaFilePath, string javaCompilerPath, string input)
        {
            string javaPath = javaCompilerPath;

            // COMPILE
            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = "javac";
            compileProcess.StartInfo.Arguments = javaFilePath;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.Start();
            compileProcess.WaitForExit();

            if (compileProcess.ExitCode == 0 )
            {
                // EXECUTE
                Process executeProcess = new Process();
                executeProcess.StartInfo.FileName = javaPath;
                executeProcess.StartInfo.Arguments = $"-classpath {Path.GetDirectoryName(javaFilePath)} {Path.GetFileNameWithoutExtension(javaFilePath)}";
                executeProcess.StartInfo.UseShellExecute = false;
                executeProcess.StartInfo.RedirectStandardInput = true;
                executeProcess.StartInfo.RedirectStandardOutput = true;
                executeProcess.Start();

                if (!string.IsNullOrEmpty(input))
                {
                    executeProcess.StandardInput.WriteLine(input);
                    executeProcess.StandardInput.Flush();
                    executeProcess.StandardInput.Close();
                }
                else
                {
                    return "EMPTY LINE";
                }

                // CAPTURE OUTPUT
                string javaOutput = executeProcess.StandardOutput.ReadToEnd();

                executeProcess.WaitForExit();

                // DISPLAY OUTPUT
                MessageBox.Show("Output: " + javaOutput, "Java Output (STUDENT)");

                compileProcess.Dispose();
                executeProcess.Dispose();

                return javaOutput;
            }
            else
            {
                MessageBox.Show("Compilation failed:\n" + compileProcess.StandardError.ReadToEnd());
                return "This Student's File Could Not Be Compiled";
            }
        }

        public static string cProject(string cFilePath, string cCompilerPath, string input)
        {
            string compilerPath = cCompilerPath; // Replace this with the actual path to your compiler
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
                if (!string.IsNullOrEmpty(input))
                {
                    executeProcess.StandardInput.WriteLine(input);
                    executeProcess.StandardInput.Flush();
                }
                else
                {
                    return "EMPTY LINE";
                }

                // CAPTURE OUTPUT
                string cOutput = executeProcess.StandardOutput.ReadToEnd();
                executeProcess.WaitForExit();

                // DISPLAY OUTPUT
                MessageBox.Show("Output: " + cOutput, "C Output (STUDENT)");
                return cOutput;
            }
            else
            {
                MessageBox.Show("Compilation failed:\n" + compileProcess.StandardError.ReadToEnd());
                return "This Student's File Could Not Be Compiled";
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
        public static bool CompareOutputs(string lecturersOutput, string studentsOutput)
        {
            // Trim the spaces to avoid inconsistencies
            lecturersOutput = lecturersOutput.Trim();
            studentsOutput = studentsOutput.Trim();

            // Make the strings all lowercase to avoid inconsistencies
            lecturersOutput = lecturersOutput.ToLower();
            studentsOutput = studentsOutput.ToLower();

            // Compare the strings
            return studentsOutput.Equals(lecturersOutput);
        }
    }

}
