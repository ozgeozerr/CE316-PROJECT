using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkazyHalka
{
    internal class trueLie
    {
        public static string trueFalse(string inputFilePath, string expectedOutputFilePath, string filePath, string compilerPath, string lang)
        {
            string[] inputsFromTeacher = File.ReadAllLines(inputFilePath);
            string[] expectedOutputs = File.ReadAllLines(expectedOutputFilePath);
            string[] outputsFromStudent = new string[inputsFromTeacher.Length];
            string errorMsg = "This Student's File Could Not Be Compiled";
            int correct = 0;

            for (int i = 0; i < inputsFromTeacher.Length; i++)
            {
                if(lang=="Java" || lang == "java")
                {
                    outputsFromStudent[i] = compilerClass.javaProject(filePath, compilerPath, inputsFromTeacher[i]);

                    if (outputsFromStudent[i].Equals(errorMsg))
                    {
                        return errorMsg;
                    }
                }else if(lang=="C" || lang == "c")
                {
                    outputsFromStudent[i] = compilerClass.cProject(filePath, compilerPath, inputsFromTeacher[i]);

                    if (outputsFromStudent[i].Equals(errorMsg))
                    {
                        return errorMsg;
                    }
                }

                if (compilerClass.CompareOutputs(expectedOutputs[i], outputsFromStudent[i]))
                {
                    correct++;
                }
            }
            string errorNumbers = correct+" Out of "+inputsFromTeacher.Length+" Are Correct";
            return errorNumbers;
        }
    }
}
