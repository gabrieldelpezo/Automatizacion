using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Suite.PageObject;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Suite.Funcionalidades
{
    class PpReportes
    {

        PpReportes(String Ruta)
        {
            List<string> Rutas = new List<string>(Ruta.Split('\\'));
            Propiedades.Drive(Rutas[0]);
            Propiedades.LeerArchivo(Ruta);
            Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(360);
            PpInicioSesion.InicioSesion();
            Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(360);
            switch (Rutas[0])
            {
                case "SuiteTuti":
                    OpGeneral.MnSistemas("7").Click(); //Tuti
                    break;
                case "SuiteCentral":
                    OpGeneral.MnSistemas("9").Click(); //Central
                    break;
                case "SuiteLocal":
                    OpGeneral.MnSistemas("6").Click(); //Local
                    break;
                default:
                    Console.WriteLine("Módulo de Reportes incorrecto");
                    break;
            }
            Propiedades.Insertar("Ejecution del Portal: " + Rutas[0] + ", Módulo: " + Rutas[1], Propiedades.Captura(Rutas[0]), false);
        }
 
        public static String Esperado;
        public static String Resultado;

        public static void FuncionalidadesTuti(String ruta)
        {
            List<string> Pantalla = new List<string>(ruta.Split('\\'));
            Esperado = "";
            Resultado = "";
            try
            {
                PpReportes ini = new PpReportes(ruta);
                switch (Pantalla[2])
                {
                    case "AutorizacionesSupervisor":
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(360);
                        OpGeneral.MnMenus("1").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        FiltroFecha();
                        OpReportes.BtnFiltrar.Click();
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        EsperadoFechaDDMMYYYY(); //Valor Esperado
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        Resultado = OpReportes.AsrAutorizacionSupervisor.Text.Substring(0, 10);
                        break;
                    case "DotacionesRetiros":
                        OpGeneral.MnMenus("2").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        FiltroFecha();
                        OpReportes.CmbMedio.Click();
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        OpReportes.OpcMedioDotaciones.Click();
                        Esperado = Propiedades.cadena[10]; //"DOTACION";
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        Resultado = OpReportes.AsrDotacionesRetiros.Text;
                        break;
                    case "VentasxArticulo":
                        OpGeneral.MnMenus("3").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        FiltroHoraMin();
                        OpReportes.BtnFiltrarArt.Click();
                        Console.WriteLine("No hay data para hacer Assert");
                        break;
                    case "VentasxMedioPago":
                        OpGeneral.MnMenus("4").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        FiltroFecha();
                        OpReportes.BtnFiltrarArt.Click();
                        Esperado = Propiedades.cadena[9];
                        Resultado = OpReportes.AsrVentasxMedioPago.Text;
                        break;
                    case "VentasxSeccion":
                        OpGeneral.MnMenus("5").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        FiltroFecha();
                        FiltroHoraMin();
                        OpReportes.BtnFiltrarArt.Click();
                        break;
                    case "RegistroTickets":
                        OpGeneral.MnMenus("7").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        OpReportes.CmbCalendarioIni.SendKeys(Propiedades.cadena[3]);
                        OpReportes.CmbCalendarioFin.SendKeys(Propiedades.cadena[4]);
                        OpReportes.BtnBuscar2.Click();
                        break;
                    case "SobrantesFaltantes":
                        OpGeneral.MnMenus("8").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        FiltroFecha();
                        //OpReportes.BtnBuscar2.Click();
                        OpReportes.CmbTiendaCod.Click();
                        OpReportes.OpcTiendaCod(Propiedades.cadena[9]).Click();
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        OpReportes.LnkFechaContable.Click();
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        Esperado = Propiedades.cadena[10];
                        Resultado = OpReportes.AsrSobrantesFaltantes.Text;
                        break;
                    case "MantMediosPago":
                        OpGeneral.MnMenus("11").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        OpReportes.LnkMediosPago.Click();
                        OpReportes.TxtMedioPago.Clear();
                        Esperado = Propiedades.cadena[3];
                        OpReportes.TxtMedioPago.SendKeys(Propiedades.cadena[3]);
                        OpReportes.BtnActualizar.Click();
                        Esperado = "Registro actualizado";
                        Resultado = OpReportes.AsrMantMedioPago.Text;
                        break;
                    case "MantAutorizaciones":
                        OpGeneral.MnMenus("12").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        OpReportes.LnkMantAutorizacion.Click();
                        OpReportes.TxtMantAutorizaciones.Clear();
                        OpReportes.TxtMantAutorizaciones.SendKeys(Propiedades.cadena[3]);
                        OpReportes.BtnActualizar.Click();
                        Esperado = "Registro actualizado";
                        Resultado = OpReportes.AsrMantAutorizaciones.Text;
                        break;
                    default:
                        Console.WriteLine("No esta en el set de pruebas");
                        break;
                }

                //Console.WriteLine("Valor esperado: {0}, Resultado: {1}", Esperado, Resultado);

                Assert.AreEqual(Esperado, Resultado, "Objeto de la página no coincide, en el modulo: " + ruta);
                Propiedades.Insertar("Prueba exitosa, la prueba muestra:" + Esperado, Propiedades.Captura(Pantalla[0]), false);
                Console.WriteLine("Test Passed");

            }
            catch (TimeoutException ex)
            {
                Propiedades.Insertar("TimeoutException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (OperationCanceledException ex)
            {
                Propiedades.Insertar("La operación fue cancelada TimeoutException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (StaleElementReferenceException ex)
            {
                Propiedades.Insertar("StaleElementReferenceException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (ElementNotVisibleException ex)
            {
                Propiedades.Insertar("ElementNotVisibleException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
                Propiedades.Errores(ex, ruta);
            }
            catch (NoSuchElementException ex)
            {
                Propiedades.Insertar("NoSuchElementException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (WebDriverException ex)
            {
                Propiedades.Insertar("WebDriverException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (Exception ex)
            {
                Propiedades.Insertar("Exception: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            finally
            {
                Propiedades.Driver.Close();
                Propiedades.Driver.Quit();
            }
        }


        public static void FuncionalidadesCentral(String ruta)
        {
            List<string> Pantalla = new List<string>(ruta.Split('\\'));
            Esperado = "";
            Resultado = "";
            try
            {
                PpReportes ini = new PpReportes(ruta);
                switch (Pantalla[2])
                {
                    case "AutorizacionesSupervisor":
                        OpGeneral.MnMenus("1").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.BtnFiltrar.Click();
                        EsperadoFechaDDMMYYYY(); //Valor Esperado
                        Resultado = OpReportes.AsrAutorizacionSupervisor.Text.Substring(0, 10);
                        break;
                    case "DotacionesRetiros":
                        OpGeneral.MnMenus("2").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(360);
                        FiltroFecha();
                        OpReportes.CmbMedio.Click();
                        OpReportes.OpcMedioDotaciones.Click();
                        OpReportes.CmbTienda.Click();
                        OpReportes.OpcTienda(Propiedades.cadena[9]).Click();
                        Esperado = Propiedades.cadena[11];
                        Resultado = OpReportes.AsrDotacionesRetiros.Text;
                        break;
                    case "VentasxArticulo":
                        OpGeneral.MnMenus("3").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.CmbTienda.Click();
                        OpReportes.OpcTienda2.SelectByText(Propiedades.cadena[13]);
                        OpReportes.CmbDepartamento.Click();
                        OpReportes.OpcDepartamento(Propiedades.cadena[14]).Click();
                        OpReportes.BtnFiltrarArt.Click();
                        EsperadoFechaYYYYMMDD();
                        Resultado = OpReportes.AsrVentasxArticulo.Text;
                        break;
                    case "VentasxMedioPago":
                        OpGeneral.MnMenus("4").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        break;
                    case "VentasxSeccion":
                        OpGeneral.MnMenus("5").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.CmbTienda.Click();
                        OpReportes.OpcTienda2.SelectByText(Propiedades.cadena[13]);
                        OpReportes.CmbDepartamento.Click();
                        OpReportes.OpcDepartamento2.SelectByValue(Propiedades.cadena[14]);
                        OpReportes.BtnFiltrarArt.Click();
                        EsperadoFechaYYYYMMDD();
                        Resultado = OpReportes.AsrVentacSeccion.Text;
                        break;
                    case "ConsultaKardexSticker":
                        OpGeneral.MnMenus("7").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Calendario();
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        OpReportes.CmbTiendaCod.Click();
                        OpReportes.OpcTiendaCod2.SelectByText(Propiedades.cadena[5]);
                        OpReportes.BtnBuscar2.Click();
                        break;
                    case "HabladoresPreciosBajos":
                        OpGeneral.MnMenus("8").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        break;
                    case "Habladores":
                        OpGeneral.MnMenus("10").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        OpReportes.CmbLocal.Click();
                        OpReportes.CmbTipo.Click();
                        Esperado = "";
                        Resultado = "";
                        Console.WriteLine("No hay data para hacer Assert");
                        break;
                    case "ProductosxPromociones":
                        OpGeneral.MnMenus("11").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Console.WriteLine("Error Matrix: Error al conectar al WebService Matrix");
                        break;
                    case "RegistrodeTickets":
                        OpGeneral.MnMenus("12").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Calendario();
                        OpReportes.TxtCliente.SendKeys(Propiedades.cadena[5]);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                        OpReportes.OpcCliente.Click();
                        OpReportes.BtnBuscar2.Click();
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                        OpReportes.LnkRegistroTicket.Click();
                        Esperado = Propiedades.cadena[6];
                        Resultado = OpReportes.AsrRegistroTickets2.Text;
                        Console.WriteLine("No hay data para hacer Assert");
                        break;
                    case "RegistroPromociones":
                        OpGeneral.MnMenus("13").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Console.WriteLine("No hay data para hacer Assert");
                        break;
                    case "ReporteVentasCartillasFísicas":
                        OpGeneral.MnMenus("14").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Calendario();
                        OpReportes.BtnBuscar2.Click();
                        Esperado = Propiedades.cadena[5];
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        Resultado = OpReportes.AsrReporteCartillas.Text.Replace(",", "");
                        break;
                    case "ReporteVentasPromoción":
                        OpGeneral.MnMenus("15").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Calendario();
                        OpReportes.BtnBuscar2.Click();
                        Esperado = Propiedades.cadena[5];
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        Resultado = OpReportes.AsrReporteVtasPromo.Text;
                        break;
                    case "SobrantesFaltantes":
                        OpGeneral.MnMenus("16").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.BtnBuscar2.Click();
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        OpReportes.LnkSobrantesFaltantes.Click();
                        Esperado = Propiedades.cadena[9];
                        Resultado = OpReportes.AsrSobrantesFaltantes2.Text;
                        break;
                    case "MantMediosPago":
                        OpGeneral.MnMenus("18").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Esperado = Propiedades.cadena[3];
                        Resultado = OpReportes.AsrMantMedioPago2.Text;
                        break;
                    case "MantAutorizaciones":
                        OpGeneral.MnMenus("19").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Esperado = Propiedades.cadena[3];
                        Resultado = OpReportes.AsrMantAutorizaciones2.Text;
                        break;
                    default:
                        Console.WriteLine("No esta en el set de pruebas");
                        break;
                }
                //Console.WriteLine("Valor esperado: {0}, Resultado: {1}", Esperado, Resultado);
                Assert.AreEqual(Esperado, Resultado, "Objeto de la página no coincide, en el modulo: " + ruta);
                Propiedades.Insertar("Prueba exitosa, la prueba muestra:" + Esperado, Propiedades.Captura(Pantalla[0]), false);
                Console.WriteLine("Test Passed");

            }
            catch (TimeoutException ex)
            {
                Propiedades.Insertar("TimeoutException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (OperationCanceledException ex)
            {
                Propiedades.Insertar("La operación fue cancelada TimeoutException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (StaleElementReferenceException ex)
            {
                Propiedades.Insertar("StaleElementReferenceException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (ElementNotVisibleException ex)
            {
                Propiedades.Insertar("ElementNotVisibleException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (NoSuchElementException ex)
            {
                Propiedades.Insertar("NoSuchElementException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (WebDriverException ex)
            {
                Propiedades.Insertar("WebDriverException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (Exception ex)
            {
                Propiedades.Insertar("Exception: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            finally
            {
                Propiedades.Driver.Close();
                Propiedades.Driver.Quit();
            }
        }

        public static void FuncionalidadesLocal(String ruta)
        {
            List<string> Pantalla = new List<string>(ruta.Split('\\'));
            Esperado = "";
            Resultado = "";
            try
            {
                PpReportes ini = new PpReportes(ruta);
                switch (Pantalla[2])
                {
                    case "AutorizacionSupervisor":
                        OpGeneral.MnMenus("1").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.BtnFiltrar.Click();
                        EsperadoFechaDDMMYYYY(); //Valor Esperado
                        Resultado = OpReportes.AsrAutorizacionSupervisor.Text.Substring(0, 10);
                        break;
                    case "DotacionesRetiros":
                        OpGeneral.MnMenus("2").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.BtnFiltrar.Click();
                        Esperado = Propiedades.cadena[9];
                        Resultado = OpReportes.AsrDotacionesRetiros.Text;
                        break;
                    case "VentasxArticulo":
                        OpGeneral.MnMenus("3").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.CmbDepartamento.Click();
                        OpReportes.OpcDepartamento2.SelectByValue(Propiedades.cadena[9]);
                        OpReportes.BtnFiltrarArt.Click();
                        EsperadoFechaYYYYMMDD(); //Valor Esperado
                        Resultado = OpReportes.AsrVentasxArticulo.Text.Substring(0, 10);
                        break;
                    case "VentasxSeccion":
                        OpGeneral.MnMenus("4").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.CmbDepartamento.Click();
                        OpReportes.OpcDepartamento2.SelectByValue(Propiedades.cadena[9]);
                        OpReportes.BtnFiltrarArt.Click();
                        EsperadoFechaYYYYMMDD(); //Valor Esperado
                        Resultado = OpReportes.AsrVentasxArticulo.Text.Substring(0, 10);
                        break;
                    case "ConsultaKardexSticker":
                        OpGeneral.MnMenus("6").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.BtnBuscar2.Click();
                        break;
                    case "ControlInventarioStickers":
                        OpGeneral.MnMenus("7").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Esperado = "No se encontró una campaña vigente a la fecha de hoy";
                        Resultado = OpReportes.AsrControlInventStickers.Text;
                        break;
                    case "Habladores":
                        OpGeneral.MnMenus("8").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Console.WriteLine("No hay data para hacer Assert");
                        break;
                    case "HabladoresPreciosBajos":
                        OpGeneral.MnMenus("9").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        OpReportes.TxtOferta.SendKeys(Propiedades.cadena[3]);
                        Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                        OpReportes.BtnBuscar2.Click();
                        Esperado = Propiedades.cadena[3];
                        Resultado = OpReportes.AsrHabladoresPreciosBajos.Text;
                        break;
                    case "RegistroCampaniasStickers":
                        OpGeneral.MnMenus("10").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Console.WriteLine("No hay data para hacer Assert");
                        break;
                    case "RegistroTickets":
                        OpGeneral.MnMenus("11").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.BtnBuscar2.Click();
                        OpReportes.LnkRegistroTicket2.Click();
                        Esperado = Propiedades.cadena[9];
                        Resultado = OpReportes.AsrRegistroTickets3.Text;
                        break;
                    case "RegistroPromociones":
                        OpGeneral.MnMenus("12").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        Console.WriteLine("No hay data para hacer Assert");
                        break;
                    case "SobrantesFaltantes":
                        OpGeneral.MnMenus("13").Click();
                        Propiedades.Insertar("Selección de Opción: " + Pantalla[2], Propiedades.Captura(Pantalla[0]), false);
                        FiltroFecha();
                        OpReportes.BtnBuscar2.Click();
                        OpReportes.LnkSobrantesFaltantes2.Click();
                        Esperado = Propiedades.cadena[9];
                        Resultado = OpReportes.AsrSobrantesFaltantes3.Text;
                        break;
                    default:
                        Console.WriteLine("No esta en el set de pruebas");
                        break;
                }

                //Console.WriteLine("Valor esperado: {0}, Resultado: {1}", Esperado, Resultado);

                Assert.AreEqual(Esperado, Resultado, "Objeto de la página no coincide, en el modulo: " + ruta);
                Propiedades.Insertar("Prueba exitosa, la prueba muestra:" + Esperado, Propiedades.Captura(Pantalla[0]), false); 
                Console.WriteLine("Test Passed");

            }
            catch (TimeoutException ex)
            {
                Propiedades.Insertar("TimeoutException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (OperationCanceledException ex)
            {
                Propiedades.Insertar("La operación fue cancelada TimeoutException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (StaleElementReferenceException ex)
            {
                Propiedades.Insertar("StaleElementReferenceException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (ElementNotVisibleException ex)
            {
                Propiedades.Insertar("ElementNotVisibleException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (NoSuchElementException ex)
            {
                Propiedades.Insertar("NoSuchElementException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (WebDriverException ex)
            {
                Propiedades.Insertar("WebDriverException: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            catch (Exception ex)
            {
                Propiedades.Insertar("Exception: " + Pantalla[1] + ", Opción: " + Pantalla[2] + " Error: " + ex, Propiedades.Captura(Pantalla[0]), true);
            }
            finally
            {
                Propiedades.Driver.Close();
                Propiedades.Driver.Quit();
            }
        }

        private static void FiltroFecha()
            {
                OpReportes.TxtDesDia.Clear();
                OpReportes.TxtDesDia.SendKeys(Propiedades.cadena[3]);
                OpReportes.CmbDesMes.Click();
                Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                OpReportes.OpcDesMes(Propiedades.cadena[4]).Click();
                OpReportes.TxtDesAnio.Clear();
                OpReportes.TxtDesAnio.SendKeys(Propiedades.cadena[5]);
                OpReportes.TxtHasDia.Clear();
                OpReportes.TxtHasDia.SendKeys(Propiedades.cadena[6]);
                OpReportes.CmbHasMes.Click();
                OpReportes.OpcHasMes(Propiedades.cadena[7]).Click();
                Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                OpReportes.TxtHasAnio.Clear();
                OpReportes.TxtHasAnio.SendKeys(Propiedades.cadena[8]);
            }

            public static void FiltroHoraMin()
            {
                OpReportes.CmbDesHora.Click();
                OpReportes.OpcDesHora(Propiedades.cadena[9]).Click();
                OpReportes.CmbDesMin.Click();
                Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                OpReportes.OpcDesMin(Propiedades.cadena[10]).Click();
                OpReportes.CmbHasHora.Click();
                Propiedades.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                OpReportes.OpcHasHora(Propiedades.cadena[11]).Click();
                OpReportes.CmbHasMin.Click();
                OpReportes.OpcHasMin(Propiedades.cadena[12]).Click();
            }

            public static void Calendario()
            {
                OpReportes.CmbCalendarioIni.Clear();
                OpReportes.CmbCalendarioIni.SendKeys(Propiedades.cadena[3]);
                OpReportes.CmbCalendarioFin.Clear();
                OpReportes.CmbCalendarioFin.SendKeys(Propiedades.cadena[4]);
                OpReportes.CmbCalendarioFin.SendKeys(Keys.Escape);
        }

            public static void EsperadoFechaDDMMYYYY()
            {
                Esperado = Propiedades.cadena[3].PadLeft(2, '0') + "-" +
                           Propiedades.cadena[4].PadLeft(2, '0') + "-" +
                           Propiedades.cadena[5];
            }

            public static void EsperadoFechaYYYYMMDD()
            {
                Esperado = Propiedades.cadena[5] + "-" +
                           Propiedades.cadena[4].PadLeft(2, '0') + "-" +
                           Propiedades.cadena[3].PadLeft(2, '0');
            }
        
    }
}
