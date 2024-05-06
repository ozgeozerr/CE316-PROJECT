using System;
using System.Diagnostics;

public class barcaMythLab
{
    public static void javaProjectMyth(string javaFilePath)
    {
        string javaPath = @"C:\Users\barca\.jdks\openjdk-20\bin\java.exe"; // Change this path as per your Java installation

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
}