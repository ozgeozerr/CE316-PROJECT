using System;
using System.Diagnostics;

public class barcaMythLab
{
    public static void javaProjectMyth(string javaFilePath)
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
        MessageBox.Show(javaOutput, "Java Output");

        compileProcess.Dispose();
        executeProcess.Dispose();
    }

    public static string cppProject(string cppFilePath, string cppCompilerPath, string input)
    {
        string compilerPath = cppCompilerPath;
        string compileCommand = $"{compilerPath} {cppFilePath} -o output.exe";
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
            executeProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(cppFilePath);
            executeProcess.StartInfo.UseShellExecute = false;
            executeProcess.StartInfo.RedirectStandardInput = true;
            executeProcess.StartInfo.RedirectStandardOutput = true;

            executeProcess.Start();

            // PASS THE INPUT
            if (!string.IsNullOrEmpty(input))
            {
                string[] inputs = input.Split(' ');
                foreach (string inputVar in inputs)
                {
                    executeProcess.StandardInput.WriteLine(inputVar);
                }
                executeProcess.StandardInput.Flush();
                executeProcess.StandardInput.Close();
            }
            else
            {
                return "EMPTY LINE";
            }

            // CAPTURE OUTPUT
            string cppOutput = executeProcess.StandardOutput.ReadToEnd();
            executeProcess.WaitForExit();

            // DISPLAY OUTPUT
            MessageBox.Show("Output: " + cppOutput, "C++ Output (STUDENT)");
            return cppOutput;
        }
        else
        {
            MessageBox.Show("Compilation failed:\n" + compileProcess.StandardError.ReadToEnd());
            return "This Student's File Could Not Be Compiled";
        }
    }

    public static string pythonProjectMyth(string pythonFilePath, string pythonInterpreterPath, string input)
    {
        string interpreterPath = pythonInterpreterPath;
        string executeCommand = $"{interpreterPath} {pythonFilePath}";
        MessageBox.Show("Execute Command: " + executeCommand);

        // EXECUTE
        Process executeProcess = new Process();
        executeProcess.StartInfo.FileName = "cmd.exe";
        executeProcess.StartInfo.Arguments = $"/c {executeCommand}";
        executeProcess.StartInfo.UseShellExecute = false;
        executeProcess.StartInfo.RedirectStandardInput = true;
        executeProcess.StartInfo.RedirectStandardOutput = true;
        executeProcess.StartInfo.RedirectStandardError = true;

        executeProcess.Start();

        // PASS THE INPUT
        if (!string.IsNullOrEmpty(input))
        {
            executeProcess.StandardInput.WriteLine(input);
            executeProcess.StandardInput.Flush();
        }

        // CAPTURE OUTPUT
        string pyOutput = executeProcess.StandardOutput.ReadToEnd();
        executeProcess.WaitForExit();

        if (executeProcess.ExitCode == 0)
        {
            // DISPLAY OUTPUT
            MessageBox.Show("Output: " + pyOutput, "Python Output (STUDENT)");
            return pyOutput;
        }
        else
        {
            MessageBox.Show("Execution failed:\n" + executeProcess.StandardError.ReadToEnd());
            return "This Student's Script Could Not Be Executed";
        }
    }
}