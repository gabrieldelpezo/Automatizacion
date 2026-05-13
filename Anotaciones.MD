git checkout
git status
git add .
git commit -m "Actualizacion de automatizacion"
git pull
git push origin/AutomatizacionReportes

origin/test-automatizacion

git clean -fx
git pull
git merge origin/develop

C78QWPIPEL1SIPE


PAQUETES NECESARIOS


microsoft.net.test.sdk
VERSION 17.3.3
DEPENDENCIA 2.1

.NET descktop development
Universal Windows Platform develoment


Install-Package Selenium.WebDriver.ChromeDriver -Version 130.0.6723.11600

	ChromeDriver
	Versión 130.0.6723.117 (Build oficial) (64 bits)


Install-Package Selenium.WebDriver
Install-Package Selenium.Chrome.WebDriver
Install-Package NUnit
Install-Package NUnit3TestAdapter
Install-Package snapshot-selenium
install snapshot-selenium

Get-Package

//snapshot
Verify.NUnit




//NUGET
SeleniumExtras

WAIT


dotnet add package Microsoft.CodeAnalysis 
dotnet remove package Microsoft.CodeAnalysis 

/*
 *  Captura de pantalla		
 */
//nuget
System.Drawing.Common.


Id                                  Versions                                 ProjectName                                                                                                                
--                                  --------                                 ----------                                                                                                                 
Selenium.WebDriver.ChromeDriver     {130.0.6723.11600}                       CasosPruebas                                                                                                               
Selenium.Chrome.WebDriver           {85.0.0}                                 CasosPruebas                                                                                                               
Selenium.WebDriver                  {4.26.1}                                 CasosPruebas                                                                                                               
Microsoft.NET.Test.Sdk              {16.9.4}                                 CasosPruebas                                                                                                               NUnit                               {4.2.2}                                  CasosPruebas                                                                                                               
coverlet.collector                  {3.0.2}                                  CasosPrueba                                                                                                                
NUnit3TestAdapter                   {4.6.0}                                  CasosPruebas 





const selectElement = document.querySelector('##Listado > tbody > tr:nth-child(2) > td:nth-child(7)');
if (selectElement.selectedIndex === 0) {
  console.log('Selecciona una opción');
} else {
  console.log('Opción válida seleccionada');
}









using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
 
namespace Selenium_Demo
{
    class Selenium_Demo
    {
        String test_url = "https://www.google.com";
 
        IWebDriver driver;
 
        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
 
        [Test]
        public void test_search()
        {
            driver.Url = test_url;
            System.Threading.Thread.Sleep(2000);
            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));
            searchText.SendKeys("LambdaTest");
            IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));
            searchButton.Click();k
            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("Test Passed");
        }
 
        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}






using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

// Configura el WebDriver (por ejemplo, ChromeDriver)
IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://www.ejemplo.com");

// Configura WebDriverWait
WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

// Espera hasta que el elemento sea visible
IWebElement myElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("miElementoId")));

// Ahora puedes interactuar con el elemento
myElement.Click();








app.config
<?xml version="1.0" encoding="utf-8" ?>
	<configuration>
		<appSettings>
			<add key="URL" value="https://www.google.com"/>
			
		</appSettings>
	</configuration>	
	
	
ConfugurationManager.appSetting("URL");

Implicit waits
driver.manage().timeouts().implicitlyWait(TimeOut, TimeUnit.SECONDS);
Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


/**/

SelectElement drpSalutation = new SelectElement(driver.FindElement(By.Id("Salutation")));
drpSalutation.SelectByText("Mr.");



* mejor el explicito que el implicito

WebDriverWait(driver, timeout).until(ExpectedConditions.visibilityOf(element));
WebDriverWait(Propiedades.Driver, timeout).until(ExpectedConditions.elementsToBeClickable(element))

var userlength = driver.FindELEMENTS(bY.iD("USR")).Count;

Assert.AreEqual(1, userlength);
//*[@id="Listado"]/tbody/tr[1]/th[1]
//*[@id="Listado"]/tbody/tr[1]/th[2]
//*[@id="Listado"]/tbody/tr[1]/th[6]

ReportesAutorizacionSupervisor





using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        // Inicializar el controlador de Chrome
        IWebDriver driver = new ChromeDriver();
        
        // Navegar a una página web
        driver.Navigate().GoToUrl("https://www.ejemplo.com");

        // Tomar la captura de pantalla
        Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
        
        // Guardar la captura de pantalla
        string filePath = @"C:\ruta\captura.png"; // Asegúrate de que la ruta exista
        screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);

										//ScreenshotImageFormat.Jpeg

        // Cerrar el navegador
        driver.Quit();
    }
}





#ui-datepicker-div > table > tbody > tr:nth-child(4) > td.ui-datepicker-days-cell-over.ui-datepicker-current-day.ui-datepicker-today > a

#ui-datepicker-div > table > tbody > tr:nth-child(4) > td.ui-datepicker-days-cell-over.ui-datepicker-current-day.ui-datepicker-today > a

//*[@id="ui-datepicker-div"]/table/tbody/tr[4]/td[2]/a

/html/body/div[2]/table/tbody/tr[4]/td[2]/a

<a class="ui-state-default ui-state-highlight ui-state-active" href="#">19</a>


#ui-datepicker-div > table > tbody > tr:nth-child(4) > td.ui-datepicker-days-cell-over.ui-datepicker-current-day.ui-datepicker-today > a

//*[@id="ui-datepicker-div"]/table/tbody/tr[4]/td[2]/a




#ui-datepicker-div > table > tbody > tr:nth-child(3) > td:nth-child(1)
//*[@id="ui-datepicker-div"]/table/tbody/tr[3]/td[1]
/html/body/div[2]/table/tbody/tr[3]/td[1]





/*


*/


       
	   #frmbuscar > select:nth-child(11) > option:nth-child(2)  //dotacion
	   #frmbuscar > select:nth-child(11) > option:nth-child(3)  //retiro
	   
	   
	   
	   #COD_TIENDA > option:nth-child(57)
	   #COD_TIENDA > option:nth-child(57)
	   
	   
	   
	   
	   
	   
	   
	   
	   
	   Algunas excepciones comunes que podrías encontrar incluyen:

NoSuchElementException: Cuando no se encuentra un elemento.
ElementNotVisibleException: Cuando un elemento está presente en el DOM pero no es visible.
TimeoutException: Cuando un comando no se completa en el tiempo especificado.



#ocultar706495




        private IWebElement Reportes => Propiedades.driver.FindElement(By.CssSelector("#msistema-central > input[type=button]:nth-child(9)"));
        private IWebElement AutorizacionesSupervisor => Propiedades.driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(1) > td > a"));

            Reportes.Click();
            AutorizacionesSupervisor.Click();
            Propiedades.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);


using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Suite.PageObject;
using System;


namespace SuiteCentral
{
    [TestClass]
    public class Reportes
    {


        String test_url = "http://10.30.1.212:8081/ARMS/index.php";

        IWebDriver driver;


        [TestMethod]
        public void AutorizacionSupervisor()
        {



    // Local Selenium WebDriver
			driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = test_url;

                    string dato;
        string user;
        string pass;

        private IWebElement Usuario => Propiedades.driver.FindElement(By.CssSelector("#acceso-user > input[type=text]"));
        private IWebElement Contrasenia => Propiedades.driver.FindElement(By.Name("CLAVE"));
        private IWebElement Ok => Propiedades.driver.FindElement(By.Name("ENTRAR"));



        string ubicacionArchivo = "D:\\SIPECOM\\Automatizacion\\Suite\\datos.csv";
         System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionArchivo);
        string separador = ",";
        string linea = null;


        archivo.ReadLine();

            while ((linea = archivo.ReadLine()) != null)
            {
                string[] fila = linea.Split(separador);
                dato = fila[0];
                user = fila[1];
                pass = fila[2];
               // Console.WriteLine("DATO {0} USER {1} PASS {2}", dato, user, pass);
            }

			Usuario.SendKeys(user);
            Contrasenia.SendKeys(pass);
            Ok.Click();
            
            try
            {
                

                driver.FindElement(By.CssSelector("#msistema-central > input[type=button]:nth-child(9)")).Click();
                driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(1) > td > a")).Click();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
                //WebDriverWait(driver, timeout).until(ExpectedConditions.visibilityOf(element));

                var Title1 = driver.FindElement(By.XPath("//*[@id=\"Listado\"]/tbody/tr[1]/th[1]")).Displayed;
                var Title2 = driver.FindElement(By.XPath("//*[@id=\"Listado\"]/tbody/tr[1]/th[2]")).Displayed;
                var Title3 = driver.FindElement(By.XPath("//*[@id=\"Listado\"]/tbody/tr[1]/th[3]")).Displayed;
                var Title4 = driver.FindElement(By.XPath("//*[@id=\"Listado\"]/tbody/tr[1]/th[4]")).Displayed;
                var Title5 = driver.FindElement(By.XPath("//*[@id=\"Listado\"]/tbody/tr[1]/th[5]")).Displayed;
                var Title6 = driver.FindElement(By.XPath("//*[@id=\"Listado\"]/tbody/tr[1]/th[6]")).Displayed;

                Assert.IsTrue(Title1);
                Assert.IsTrue(Title2);
                Assert.IsTrue(Title3);
                Assert.IsTrue(Title4);
                Assert.IsTrue(Title5);
                Assert.IsTrue(Title6);

                Console.WriteLine("Test Passed");

            }
            catch (Exception e)
            {
                Console.WriteLine("Test Fail !!");
            }
            finally
            {
                driver.Quit();

            }

        }
    }
}







using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            {
                string ruta = "";
                string caso;
                int tamano;
                int posicion;
                int i;

                for (i = 1; i < 13; i++)
                {
                    switch (i)
                    {
                    case 1: ruta = "SuiteTuti\\PreciosFlejes\\ProcesarLoteActualizacionPrecios"; break;

                    case 2: ruta = "SuiteTuti\\PreciosFlejes\\ImpresionFlejes"; break;

                    case 3: ruta = "SuiteTuti\\PreciosFlejes\\MantInteresesFlejesDiferidos"; break;

                    //case 1: ruta = "SuiteTuti\\rutartes\\AutorizacionesSupervisor"; break;
                    
                    //case 2: ruta = "SuiteTuti\\rutartes\\DotacionesRetiros"; break;

                    //case 3: ruta = "SuiteTuti\\rutartes\\VentasxArticulo"; break;

                        case 4: ruta = "SuiteTuti\\rutartes\\VentasxSeccion"; break;

                        case 5: ruta = "SuiteTuti\\rutartes\\ConsultaKardexSticker"; break;

                        case 6: ruta = "SuiteTuti\\rutartes\\ControlInventarioStickers"; break;

                        case 7: ruta = "SuiteTuti\\rutartes\\Habladores"; break;

                        case 8: ruta = "SuiteTuti\\rutartes\\HabladoresPreciosBajos"; break;

                        case 9: ruta = "SuiteTuti\\rutartes\\RegistroCampaniasStickers"; break;

                        case 10: ruta = "SuiteTuti\\rutartes\\RegistroTickets"; break;

                        case 11: ruta = "SuiteTuti\\rutartes\\RegistroPromociones"; break;

                        case 12: ruta = "SuiteTuti\\rutartes\\SobrantesFaltantes"; break;

                        default: Console.WriteLine("Fin"); break;
                    }

                    tamano = ruta.Length;
                    posicion.LastIndexOf("\\") + 1;
                    tamano -= pocision;
                    caso = ruta.Substring(posicion, tamano);
                }
            }
        }
    }
}




Ahora, esto está usando un localizador de elementos o un nombre de identificador, y solo estoy realizando un envío, por lo que estoy ingresando el archivo



#msistema-central > input[type=button]:nth-child(6)

//*[@id="msistema-central"]/input[6]

/html/body/div/div[2]/input[6]




/*

	AZURE DEVOPS SERVER
	
*/

Team Explorer - 



/*
	git
*/
	
CREATE & CLONE
Create new Repository							git init
Create local repository							git clone repository path
Create remote Repository						git clone repository path

ADD & REMOVE
add change to INDEX								git add <filename>
add all change to INDEX							git add*
remove / delete 								git rm <filename>

COMMIT & SYNCHONISE
commit changes									git commit -m "COMMIT message"
Push changes to remote repository				git push origin master
Connet local repository to remote repository	git remote add origin <server name>
Update Local repositoryto remote repository|	git pull

BRANCHES
Create new branch								git checkout -b <branch>
Switch to master branch							git checkout master
delete branch									git branch -d <branch>
Push branch to remote repository				git push origin <branch>

MERGE
Merge changes from another branch				git merge <merge>
View change from another branch					git diff <Src branch> <Tar branch>


git branch
git status
git add .
git status
git commit -m "Nuevos cambios"
git push origin/AutomatizacionReportes


    System.Exception: Error: Reportes\AutorizacionesSupervisor 26/11/2024 10:28:28  System.IO.IOException: El nombre de archivo, el nombre de directorio o la sintaxis de la etiqueta del volumen no son correctos. : 'D:\SIPECOM\suite-arms-automatizacion\bin\Debug\netcoreapp3.1\https:\sipecomsa.sharepoint.com\sites\QA-QC\Documentos%20compartidos\Forms\AllItems.aspx?FolderCTID=0x0120005F95617590751E4089C8B5DDDC5955C9&id=%2Fsites%2FQA%2DQC%2FDocumentos%20compartidos%2FCoordinaci%C3%B3n%20QA%2FDatos%2DPruebas%2DAutomatizacion%2FSuiteArmsTuti%2FReportes\AutorizacionesSupervisor.csv'
	
	

    public static void DownloadFile(string siteUrl, string fileUrl, string localPath)
    {
        using (ClientContext context = new ClientContext(siteUrl))
        {
            // Autenticación
            context.Credentials = new NetworkCredential("username", "password", "domain");

            // Obtener el archivo
            FileInformation fileInfo = File.OpenBinaryDirect(context, fileUrl);
            using (var fileStream = new FileStream(localPath, FileMode.Create))
            {
                fileInfo.Stream.CopyTo(fileStream);
            }
        }
    }

    public static void Main(string[] args)
    {
        string siteUrl = "https://yoursharepointsite/sites/yoursite";
        string fileUrl = "/sites/yoursite/Shared Documents/yourfile.txt"; // Ruta del archivo en SharePoint
        string localPath = @"C:\path\to\your\local\file.txt"; // Ruta local donde se guardará el archivo

        DownloadFile(siteUrl, fileUrl, localPath);
        Console.WriteLine("Archivo descargado exitosamente.");
    }
	
	
	
	
	
ok,  ayudame con algo porfa, envaime un correo para darte los permisos yo en el pipeline, y otro a Infra que te de los permisos para el server donde estan los agentes, a los 2 copialo a Jonathan ya que el es el que da la luz verde:
 
el server es :
C78QWPIPEL1SIPE


seira enviar 2 correos:
•	A mi con copia a jonthan para la aprovacion de creacion de Agentes
•	A Infra con el acceso al server C78QWPIPEL1SIPE bajo la aprobacion de Jonathan

estoy realizando programación para pruebas automatizadas
 
y voy a necesitar generar pipeline y agentes para contruir un build y otro para la ejecucion de las pruebas
 
adicional quisiera consultarte si podría alojar en ese servidor los archivos con datos de pruebas
 
debido que se va a compilar 
•	Levantar el agente que a su ves inicializará las pruebas automatizadas
•	leer archivos para cada casos de pruebas
•	guardar capturas de pantallas en la misma ruta de los archivos que va a leer










   Origen: Reportes.cs línea 20
   Duración: 10 s

  Mensaje: 
Excepción método de prueba SuiteCentral.Reportes.ConsultaKardexSticker:
OpenQA.Selenium.NoSuchElementException: no such element: Unable to locate element: {"method":"css selector","selector":"#FECHA_SEL"}
  (Session info: chrome=131.0.6778.86); For documentation on this error, please visit: https://www.selenium.dev/documentation/webdriver/troubleshooting/errors#no-such-element-exception

  Seguimiento de la pila: 
WebDriver.UnpackAndThrowOnError(Response errorResponse, String commandToExecute)
WebDriver.ExecuteAsync(String driverCommandToExecute, Dictionary`2 parameters)
WebDriver.Execute(String driverCommandToExecute, Dictionary`2 parameters)
WebDriver.FindElement(String mechanism, String value)
<.ctor>b__11_0(ISearchContext context)
By.FindElement(ISearchContext context)
WebDriver.FindElement(By by)
OpReportes.get_CmbCalendarioIni() línea 48
PpReportes.PpConsultaKardexSticker() línea 95
Reportes.ConsultaKardexSticker() línea 24



#HORA_EH > option:nth-child(24)
#MIN_EH > option:nth-child(7)


		public static IWebElement MnAutorizacionesSupervisor => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(1) > td > a"));
        public static IWebElement MnDotacionesRetiros(string menu) => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(2) > td > a"));
        public static IWebElement MnVentasxArticulo(string menu) => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child("+ menu +") > td > a"));
        public static IWebElement MnVentasxMedioPago => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(4) > td > a"));
        public static IWebElement MnVentasxSeccion => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(4) > td > a"));
        public static IWebElement MnConsultaKardexSticker => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(6) > td > a"));
        public static IWebElement MnInventarioStickers => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(7) > td > a"));
        public static IWebElement MnHabladores => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(8) > td > a"));
        public static IWebElement MnHabladoresPreciosBajos => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(9) > td > a"));
        public static IWebElement MnRegistroCampañasStickers => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(10) > td > a"));
        public static IWebElement MnRegistroTickets => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(11) > td > a"));
        public static IWebElement MnRegistroPromociones => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(12) > td > a"));
        public static IWebElement MnSobrantesFaltantes => Propiedades.Driver.FindElement(By.CssSelector("body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(13) > td > a"));




PIPELINE

* Quitar la sección de pruebas

Pipeline
Proyecto

Agente pool
Azure Pipeline

Agente specificacion
vs2017 - win2016

parametros
**\*.snl

USE NUGET 4.4.1

USE NUGET RESTORE
restore
**\*.sln

BUILD SOLUTION **\*.sln
$(BuildPlatform)

Publish symbols path
$BuildSourcesDirectory)

search patter *
**\bin\**\*.pdb
index sources
verbose logging
//displayname
copy file to: $(build.artifactstagingdirectory)
//source folder
$(system.defaultworkingdirectory)
//contents
**\bin\$(BuildConfiguration)\**

//Target FolderCTID
$(build.artifactstagingdirectory)


//dysplay name
Publish Artifact: Drop
//path to publish
$(build.artifactstagingdirectory)
//artifact name
drop
//Artifact publish location
Azure Pipeline



//BUILD PIPILINE PARA PRUEBAS
//display name 
VsTest - testAssemblies

//test seleccion 
//select testing using
test assemblies

//test files
**\test*.dll
!**\*testAdapter.dll
!**\obj\**
**\Suite.dll

Searrch follder
$(SystemDefaultWorkingDirectory)

//Test result folder 
$(Agent.TemDirectory)\TestResult




//Add Artifact  --Source

 Seleccionamos el proyecto 
Suite .NET Descktop CI
 
 //Source Alias
_Suite .NET Descktop CI
 


//Contionous deployment


//PIPELINE
validar proyecto de automatizacion
usar paquete NuGet
restauracion > aolucion del build
publica el path
copia los archivos
publica el artefacto 
publica el trabajo

completar el build del proyecto 

canalizacion dos uno publicado y uno consumido



//REALEASE

create new PIPILINE
EMPTY JOB
1 job  0 tast -> Stage 1
--Agent job
VS 2019 - WIN2016






SuiteTuti\\
SuiteCentral
SuiteLocal\\



SuiteTuti\\Reportes\\AutorizacionesSupervisor
SuiteTuti\\Reportes\\DotacionesRetiros
SuiteTuti\\Reportes\\VentasxArticulo
SuiteTuti\\Reportes\\VentasxSeccion
SuiteTuti\\Reportes\\ConsultaKardexSticker
SuiteTuti\\Reportes\\ControlInventarioStickers
SuiteTuti\\Reportes\\Habladores
SuiteTuti\\Reportes\\HabladoresPreciosBajos
SuiteTuti\\Reportes\\RegistroCampaniasStickers
SuiteTuti\\Reportes\\RegistroTickets
SuiteTuti\\Reportes\\RegistroPromociones
SuiteTuti\\Reportes\\SobrantesFaltantes







string repo1 = "SuiteTuti\\Reportes\\AutorizacionesSupervisor
string repo1 = "SuiteTuti\\Reportes\\DotacionesRetiros
string repo1 = "SuiteTuti\\Reportes\\VentasxArticulo
string repo1 = "SuiteTuti\\Reportes\\VentasxSeccion
string repo1 = "SuiteTuti\\Reportes\\ConsultaKardexSticker
string repo1 = "SuiteTuti\\Reportes\\ControlInventarioStickers
string repo1 = "SuiteTuti\\Reportes\\Habladores
string repo1 = "SuiteTuti\\Reportes\\HabladoresPreciosBajos
string repo1 = "SuiteTuti\\Reportes\\RegistroCampaniasStickers
string repo1 = "SuiteTuti\\Reportes\\RegistroTickets
string repo1 = "SuiteTuti\\Reportes\\RegistroPromociones
string repo1 = "SuiteTuti\\Reportes\\SobrantesFaltantes








	   
// CER
SUITE CENTRAL
http://10.30.1.212:8081/ARMS'
http://10.30.1.212:8081/ARMS/index.php
webmaster
12qazwsx

/*
	//reportes
AutorizacionesSupervisor
DotacionesRetiros
VentasxArticulo
VentasxMedioPago
VentasxSeccion
ConsultaKardexSticker
HabladoresPreciosBajos
Habladores
ProductosxPromociones
RegistrodeTickets
RegistroPromociones
ReporteVentasCartillasFísicas
ReporteVentasPromoción
SobrantesFaltantes
MantMediosPago
MantAutorizaciones
*/

/* //precios y flejes
ProcesarLoteActualizacionPrecios
ProcesarLoteEtiquetasPreciosxMayor
ImpresionFlejes
MantUsuariosBalanza
MantEstadosProceso
MantInteresesFlejesDiferidos
*/


body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(1) Autorizaciones Supervisor
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(2) Dotaciones y Retiros
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(3) Ventas por Articulo
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(4) Ventas por Medio de Pago
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(5) Ventas por Seccion
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(7) Consulta de Kardex de Sticker
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(8) Habladores de Precios Bajos
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(9) Habladores de Precios Bajos
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(10) Habladores-1
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(11) Productos por Promociones
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(12) Registro de Tickets
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(13) Registro Promociones
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(14) Reporte de Ventas con Cartillas Físicas
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(15) Reporte de Ventas de Promoción
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(16) Sobrantes y Faltantes
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(18) Mant.  Medios de Pago
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(19) Mant. Autorizaciones


//	CER
SUITE LOCAL
http://10.30.1.231:8081/ARMS/index.php
108906
Piramide1.

/*
ProcesarLoteActualizacionPrecios
ProcesarLoteEtiquetasPreciosXMayor
ImpresionFlejes
*/



// TUTI
TUTI - SUITE ARM
URL: http://10.30.1.249:8081/ARMS/index.php
user: 95594
pass: Rherrera2019.






Visualizar las opciones:
- Autorizaciones Supervisor
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(1) > td > a
- Dotaciones y Retiros
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(2) > td
- Ventas por Artículo
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(3) > td > a
- Ventas por Medio de Pago
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(4) > td > a
- Ventas por Sección
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(5) > td > a
- Registro de Tickets
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(7) > td > a
- Sobrantes y Faltantes
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(8) > td > a
- Mant. Medios de Pago
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(10) > td > a
- Mant. Autorizaciones
body > table:nth-child(5) > tbody > tr > td:nth-child(1) > div > table > tbody > tr:nth-child(11) > td > a



REPORTES
- Autorizaciones Supervisor
- Dotaciones y Retiros
- Ventas por Artículo
- Ventas por Medio de Pago
- Ventas por Sección
- Registro de Tickets
- Sobrantes y Faltantes
- Mant. Medios de Pago
- Mant. Autorizaciones

PRECIOS Y FLEJES
- Impresión Hablador Unificado
- Procesar Cambios de precio
- Procesar Lote de Actualizacion de Precios
- Impresion de Flejes
- Impresion de Habladores
- Mant. Estados Proceso
- Mant. Intereses Flejes Diferidos


        /*  - ImpresionHabladorUnificado
            - ProcesarCambiosPrecio
            - ProcesarLoteActualizacionPrecios
            - ImpresionFlejes
            - ImpresionHabladores
            - MantEstadosProceso
            - MantInteresesFlejesDiferidos      */








//18 -dic- 2025
Automatizacion_token
--Actualizar agente para el 2026
wqeqdytemuy3jiimbncua5ql6rqklypsj4hihaihkjbwc3uilgna











public static IList<IWebElement> OpSize => propiedades.drive.FindElements(by.xpath...)
public static IList<IWebElement> OpAddtoCart => propiedades.drive.FindElements(by.xpath...)

public static void Add_producto()
{
	CONSOLE.WRITELINE(Vartype);
	for(int i =0; i<Vartype.count; i++)
	{
		console.writeline(i);
		if (varType.ElementAt(i).text.contains("Prestige"))
		{
			selection.elementAt(i).Click();
			SelectElement drpVarColor = new SelectElement(VarColour.ElementAt(i));
			drpVarColor.selectByText("dato");
			SelectElement drpVarSize = new SelectElement(VarSize.ElementAt(i));
			drpVarSize.selectByText("dato");
			Addtocart.elementAt(i).clic();
		}
	}
}
