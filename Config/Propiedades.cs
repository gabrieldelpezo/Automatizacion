using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xceed.Words.NET;

namespace Suite
{
    class Propiedades
    {
        //Contendor para los datos de los casos de pruebas
        public readonly static string[] cadena = new String[25];

        //Driver
        public static IWebDriver Driver{ get; set; }

        public static void Drive(string url)
        {
            //Inicializa el driver
            var chromeOption = new ChromeOptions();
            chromeOption.AddArgument("-no-sandbox"); // Desactiva el modo sandbox
            //chromeOption.AddArgument("--headless"); // Ejecuta Chrome en modo sin interfaz gráfica
            chromeOption.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe"; 
            Driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application\ChromeDriver.exe", chromeOption);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(360);
            switch (url)
            {
                case "SuiteTuti":
                    Driver.Url = "http://10.30.1.249:8081/ARMS/index.php";
                    break;
                case "SuiteCentral":
                    Driver.Url = "http://10.30.1.212:8081/ARMS/index.php";
                    break;
                case "SuiteLocal":
                    Driver.Url = "http://10.30.1.231:8081/ARMS/index.php";
                    break;
                default:
                    Console.WriteLine("URL no asignada al casso de prueba");
                    break;
            }
        }


        public static (String, String, String, String, String, String, String, String, 
                       String, String, String, String, String, String, String, String) 
                       LeerArchivo (String Ruta)
        {

            //Consulta el respectivo archivo de datos según el caso de prueba
            string ubicacionArchivo = "\\\\C78QWPIPEL1SIPE\\Datos\\" + Ruta + ".csv";
            
        //Consulta el respectivo archivo de datos según el caso de prueba
            System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionArchivo);
            string separador = ",";
            string linea;
            int contar = 25;

            //Salta a la siaguiente Linea de datos
            archivo.ReadLine();

            while ((linea = archivo.ReadLine()) != null)
            {
                string[] fila = linea.Split(separador);
                
                cadena[0] = fila[0];
                if (cadena[0] == "1")
                {
                    for (int i = 1; i < contar; i++)
                    {
                        cadena[i] = fila[i];
                        if (cadena[i] == "EOL")
                        {
                            break;
                        }
                    }

                    archivo.Close();
                    break;
                }
            }

            //Console.WriteLine("DATO: {0} USER: {1} PASS: {2} LUGAR: {3}", cadena[0], cadena[1], cadena[2], cadena[3]);

            //Retorna Valores leidos del Archivo
            return (cadena[1], cadena[2], cadena[3], cadena[4], cadena[5], cadena[6], cadena[7], cadena[8], 
                cadena[9], cadena[10], cadena[11], cadena[12], cadena[13], cadena[14], cadena[15], cadena[16]);
        }

        public static void Errores(Exception ex, String ruta)
        {
            DateTime fechaHoraActual = DateTime.Now;
            string formatoPersonalizado = fechaHoraActual.ToString("-yyyyMMdd-HHmmss");
            String pantalla = "\\\\C78QWPIPEL1SIPE\\Datos\\" + ruta;
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            screenshot.SaveAsFile(pantalla + formatoPersonalizado + ".png");
            throw new Exception("Reporte de Error: " + ruta + " " + fechaHoraActual + "  " + ex);
        }

        public static string Captura (String ruta)
        { 
            DateTime fechaHoraActual = DateTime.Now;
            string formatoPersonalizado = "\\" + fechaHoraActual.ToString("yyyyMMddHHmmss");
            String pantalla = "\\\\C78QWPIPEL1SIPE\\Datos\\" + ruta + "\\Capturas\\" + formatoPersonalizado + ".png";
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            screenshot.SaveAsFile(pantalla);
            return (pantalla);
        }


        public static void Insertar(string Text, string ImagePath, bool err)
        {
            List<string> path = new List<string>(ImagePath.Split('\\'));
            string filePath = "\\\\C78QWPIPEL1SIPE\\Datos\\" + path[4] + "\\Informe.docx";

            do
            {
                if (filePath == "\\\\C78QWPIPEL1SIPE\\Datos\\" + path[4] + "\\Error.docx") //(.docx)
                {
                    throw new Exception("Reporte de Error: " + Text);
                    err = false;
                }
                    

                // Crear un nuevo documento
                using var document = DocX.Load(filePath);
                {
                    // Insertar texto
                    var paragraph = document.InsertParagraph(Text);
                    paragraph.FontSize(12).Bold().Italic();

                    // Insertar imagen
                    if (File.Exists(ImagePath))
                    {
                        var image = document.AddImage(ImagePath);
                        var picture = image.CreatePicture();
                        picture.Width = 460; // Ancho deseado
                        picture.Height = 300; // Alto deseado
                        document.InsertParagraph(""); // Salto de línea
                        document.InsertParagraph("").InsertPicture(picture, 0);
                    }
                    else
                    {
                        Console.WriteLine($"La imagen no existe: {ImagePath}");
                    }
                    // Guardar el documento
                    document.Save();
                    Console.WriteLine($"Documento creado en: {filePath}");

                    filePath = "\\\\C78QWPIPEL1SIPE\\Datos\\" + path[4] + "\\Error.docx";
                }


            } while ( err );
            File.Delete(ImagePath);
        }
    }
}
