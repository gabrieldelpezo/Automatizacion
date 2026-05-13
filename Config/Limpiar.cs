using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace _limpiar
{
    [TestClass]
    public class Limpiar
    {
        [TestMethod]
        public void LimpiarLogs() 
        {
            string[] folderPath = { "\\\\C78QWPIPEL1SIPE\\Datos\\SuiteCentral\\Capturas\\",
                                    "\\\\C78QWPIPEL1SIPE\\Datos\\SuiteLocal\\Capturas\\",
                                    "\\\\C78QWPIPEL1SIPE\\Datos\\SuiteTuti\\Capturas\\" };

            foreach (string path in folderPath)
            {
                try
                {
                    // Obtener todos los archivos PNG en la carpeta
                    string[] pngFiles = Directory.GetFiles(path, "*.png");

                    // Recorrer y eliminar cada archivo PNG
                    foreach (string file in pngFiles)
                    {
                        File.Delete(file);
                        //Console.WriteLine($"Archivo eliminado: {file}");
                    }
                    Console.WriteLine("En " + path  + " todos los archivos PNG han sido eliminados");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrió un error: {ex.Message}");
                }
            }


            folderPath[0] = "\\\\C78QWPIPEL1SIPE\\Datos\\SuiteCentral";
            folderPath[1] = "\\\\C78QWPIPEL1SIPE\\Datos\\SuiteLocal";
            folderPath[2] = "\\\\C78QWPIPEL1SIPE\\Datos\\SuiteTuti";

            foreach (string path in folderPath)
            {
                try
                {
                    // Obtener todos los archivos DOCX en la carpeta
                    string[] docFiles = Directory.GetFiles(path, "*.docx");

                    // Recorrer y eliminar cada archivo PNG
                    foreach (string file in docFiles)
                    {
                        File.Delete(file);
                    }
                    string sourceFile = path + "\\Capturas\\Template.docx";

                    string destinationFile = path + "\\Informe.docx";
                    File.Copy(sourceFile, destinationFile);
                    Console.WriteLine($"Archivo creado: {sourceFile}");

                    destinationFile = path + "\\Error.docx";
                    File.Copy(sourceFile, destinationFile);
                    Console.WriteLine($"Archivo creado : {destinationFile}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrió un error: {ex.Message}");
                }
            }
        }
    }
}
