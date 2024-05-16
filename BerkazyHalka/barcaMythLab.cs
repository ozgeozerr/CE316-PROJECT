using System;
using System.Diagnostics;
using Python.Runtime;

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

    using System;
using System.Diagnostics;
using System.IO;

public static string CompileAndExecuteCpp(string cppFilePath, string cppCompilerPath, string input)
{
    string compilerPath = cppCompilerPath;
    string compileCommand = $"{compilerPath} {cppFilePath} -o output";

    Console.WriteLine("Compile Command: " + compileCommand);

    // Compile
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
        Console.WriteLine("Compilation successful!");

        // Execute
        Process executeProcess = new Process();
        executeProcess.StartInfo.FileName = "output.exe"; // Assuming output file is named 'output.exe'
        executeProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(cppFilePath);
        executeProcess.StartInfo.UseShellExecute = false;
        executeProcess.StartInfo.RedirectStandardInput = true;
        executeProcess.StartInfo.RedirectStandardOutput = true;

        executeProcess.Start();

        // Pass the input
        if (!string.IsNullOrEmpty(input))
        {
            executeProcess.StandardInput.WriteLine(input);
            executeProcess.StandardInput.Flush();
        }
        else
        {
            return "EMPTY LINE";
        }

        // Capture output
        string output = executeProcess.StandardOutput.ReadToEnd();
        executeProcess.WaitForExit();

        // Display output
        Console.WriteLine("Output: " + output);
        return output;
    }
    else
    {
        Console.WriteLine("Compilation failed:\n" + compileProcess.StandardError.ReadToEnd());
        return "Compilation failed";
    }
}
static string RunPythonClass(string filePath, string inputParameter) // dont forget using Python.Runtime; 
{
    string output = "";

    // Initialize Python engine
    using (Py.GIL())
    {
        // Set Python path
        dynamic sys = Py.Import("sys");
        sys.path.append(Environment.CurrentDirectory);

        // Import your Python module containing the class
        dynamic module = Py.Import(System.IO.Path.GetFileNameWithoutExtension(filePath));

        // Access the class
        dynamic pythonClass = module.YourPythonClass;

        // Instantiate the class
        dynamic pythonInstance = pythonClass(inputParameter);

        // Call methods or access attributes
        pythonInstance.YourMethod();

        // Get output
        output = pythonInstance.YourAttribute;
    }

    return output;
}

}