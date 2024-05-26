using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BerkazyHalka
{
    internal class trueLie
    {
        public static (string, string[]) trueFalse(string inputFilePath, string expectedOutputFilePath, string filePath, string compilerPath, string lang)
        {
            string[] inputsFromTeacher = File.ReadAllLines(inputFilePath);
            string[] expectedOutputs = ReadUntilDelimiter(expectedOutputFilePath, "-!-");

            string[] outputsFromStudent = new string[inputsFromTeacher.Length];
            string errorMsg = "This Student's File Could Not Be Compiled";
            string[] errorArray = { "No Outputs Due To Error" };
            int correct = 0;

            for (int i = 0; i < inputsFromTeacher.Length; i++)
            {
                if (lang == "Java" || lang == "java")
                {
                    outputsFromStudent[i] = compilerClass.javaProject(filePath, compilerPath, inputsFromTeacher[i]);

                    if (outputsFromStudent[i].Equals(errorMsg))
                    {
                        return (errorMsg,errorArray);
                    }
                }
                else if (lang == "C" || lang == "c")
                {
                    outputsFromStudent[i] = compilerClass.cProject(filePath, compilerPath, inputsFromTeacher[i]);

                    if (outputsFromStudent[i].Equals(errorMsg))
                    {
                        return (errorMsg, errorArray);
                    }
                }
                else if (lang == "Python" || lang == "python")
                {
                    outputsFromStudent[i] = compilerClass.pythonProject(filePath, compilerPath, inputsFromTeacher[i]);

                    if (outputsFromStudent[i].Equals(errorMsg))
                    {
                        return (errorMsg, errorArray);
                    }
                }
                else if (lang == "C++" || lang == "c++")
                {
                    outputsFromStudent[i] = compilerClass.cppProject(filePath, compilerPath, inputsFromTeacher[i]);

                    if (outputsFromStudent[i].Equals(errorMsg))
                    {
                        return (errorMsg, errorArray);
                    }
                }

                if (i < expectedOutputs.Length && compilerClass.CompareOutputs(expectedOutputs[i], outputsFromStudent[i]))
                {
                    correct++;
                }
            }
            outputLister(outputsFromStudent);
            string errorNumbers = correct + " Out of " + inputsFromTeacher.Length + " Are Correct";
            return (errorNumbers,outputsFromStudent);
        } 

        public static string[] outputLister(string[] outputList)
        {
            return outputList;
        }

        private static string[] ReadUntilDelimiter(string filePath, string delimiter)
        {
            List<string> outputs = new List<string>();
            StringBuilder currentOutput = new StringBuilder();

            foreach (var line in File.ReadLines(filePath))
            {
                if (line.Trim() == delimiter)
                {
                    if (currentOutput.Length > 0)
                    {
                        outputs.Add(currentOutput.ToString().Trim());
                        currentOutput.Clear();
                    }
                }
                else
                {
                    if (currentOutput.Length > 0)
                    {
                        currentOutput.AppendLine();
                    }
                    currentOutput.Append(line);
                }
            }

            if (currentOutput.Length > 0)
            {
                outputs.Add(currentOutput.ToString().Trim());
            }

            return outputs.ToArray();
        }
    }
}
