using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Suite.PageObject
{
    class OpReportes
    {
        public static WebDriverWait Wait => new WebDriverWait(Propiedades.Driver, TimeSpan.FromSeconds(10));

        //COMPONENTES DE FECHA
        public static IWebElement TxtDesDia => Propiedades.Driver.FindElement(By.Id("DIA_ED"));
        public static IWebElement CmbDesMes => Propiedades.Driver.FindElement(By.CssSelector("#MES_ED"));
        public static IWebElement OpcDesMes(string mes) => Propiedades.Driver.FindElement(By.CssSelector("#MES_ED > option:nth-child(" + mes + ")"));
        public static IWebElement TxtDesAnio => Propiedades.Driver.FindElement(By.Id("ANO_ED"));
        public static IWebElement TxtHasDia => Propiedades.Driver.FindElement(By.Id("DIA_EH"));
        public static IWebElement CmbHasMes => Propiedades.Driver.FindElement(By.CssSelector("#MES_EH"));
        public static IWebElement OpcHasMes(string mes) => Propiedades.Driver.FindElement(By.CssSelector("#MES_EH > option:nth-child(" + mes + ")"));
        public static IWebElement TxtHasAnio => Propiedades.Driver.FindElement(By.Name("ANO_EH"));
        public static IWebElement CmbCalendarioIni => Propiedades.Driver.FindElement(By.Id("FECHA_SEL"));
        public static IWebElement CmbCalendarioFin => Propiedades.Driver.FindElement(By.Id("FECHA_FIN"));

        //COMPONENTES DE HORA Y MINUTO
        public static IWebElement CmbDesHora => Propiedades.Driver.FindElement(By.CssSelector("#HORA_ED"));
        public static IWebElement OpcDesHora(string hora) => Propiedades.Driver.FindElement(By.CssSelector("#HORA_ED > option:nth-child(" + hora + ")"));
        public static IWebElement CmbDesMin => Propiedades.Driver.FindElement(By.Id("MIN_ED"));
        public static IWebElement OpcDesMin(string Min) => Propiedades.Driver.FindElement(By.CssSelector("#MIN_ED > option:nth-child(" + Min + ")"));
        public static IWebElement CmbHasHora => Propiedades.Driver.FindElement(By.Id("HORA_EH"));
        public static IWebElement OpcHasHora(string hora) => Propiedades.Driver.FindElement(By.CssSelector("#HORA_EH > option:nth-child(" + hora + ")"));
        public static IWebElement CmbHasMin => Propiedades.Driver.FindElement(By.Id("MIN_EH"));
        public static IWebElement OpcHasMin(string Min) => Propiedades.Driver.FindElement(By.CssSelector("#MIN_EH > option:nth-child(" + Min + ")"));

        //CAJAS DE TEXTO
        public static IWebElement TxtMedioPago => Propiedades.Driver.FindElement(By.CssSelector("#forma-registro > tbody > tr:nth-child(2) > td:nth-child(2) > input[type=text]"));
        public static IWebElement TxtCliente => Propiedades.Driver.FindElement(By.Id("B_TICKET"));

        // USUARIO
        public static IWebElement MnUser => Propiedades.Driver.FindElement(By.Id("MenuUser"));
        public static IWebElement MnSistemas => Propiedades.Driver.FindElement(By.ClassName("enlaceClave"));
        public static IWebElement MnCambiarClave => Propiedades.Driver.FindElement(By.ClassName("enlaceClave"));
        public static IWebElement MnCerraSesion => Propiedades.Driver.FindElement(By.ClassName("enlaceSesion"));

        //CAJAS DE TEXTO
        public static IWebElement TxtOferta => Propiedades.Driver.FindElement(By.Id("B_NUM_OFERTA"));
        public static IWebElement TxtArticuloCod => Propiedades.Driver.FindElement(By.Id("B_COD_ART"));
        public static IWebElement TxtArticulo => Propiedades.Driver.FindElement(By.Id("B_ARTIC"));
        public static IWebElement TxtEan => Propiedades.Driver.FindElement(By.Id("B_EAN"));
        public static IWebElement TxtCampaña => Propiedades.Driver.FindElement(By.Id("B_CAMPAIGN"));
        public static IWebElement TxtMantAutorizaciones => Propiedades.Driver.FindElement(By.Name("DES_RSN_ES"));

        //COMBOS
        public static IWebElement CmbTienda => Propiedades.Driver.FindElement(By.Name("FTIENDA"));
                                                                                                           //#frmbuscar > select:nth-child(3) > option:nth-child(92)
        public static IWebElement OpcTienda(string tienda) => Propiedades.Driver.FindElement(By.CssSelector("#frmbuscar > select:nth-child(12) > option:nth-child(" + tienda + ")"));
        public static SelectElement OpcTienda2 => new SelectElement(CmbTienda);
        public static IWebElement CmbOperador => Propiedades.Driver.FindElement(By.Name("FOPERA"));
        public static IWebElement OpcOperador(string opera) => Propiedades.Driver.FindElement(By.CssSelector("#frmbuscar > select:nth-child(13) > option:nth-child(" + opera + ")"));
        public static IWebElement CmbDepartamento => Propiedades.Driver.FindElement(By.Name("FDEPART"));
        public static SelectElement OpcDepartamento2 => new SelectElement(CmbDepartamento);
        public static IWebElement OpcDepartamento(string depart) => Propiedades.Driver.FindElement(By.CssSelector("#frmbuscar > select:nth-child(4) > option:nth-child(" + depart + ")"));
        public static IWebElement CmbMayoreo => Propiedades.Driver.FindElement(By.Name("FMAYO"));
        public static IWebElement OpcMayoreo(string mayoreo) => Propiedades.Driver.FindElement(By.CssSelector("#frmbuscar > select:nth-child(11) > option:nth-child(" + mayoreo + ")"));
        public static IWebElement CmbTiendaCod => Propiedades.Driver.FindElement(By.Id("COD_TIENDA"));
        public static SelectElement OpcTiendaCod2 => new SelectElement(CmbTiendaCod);
        public static IWebElement OpcTiendaCod(string tienda) => Propiedades.Driver.FindElement(By.CssSelector("#COD_TIENDA > option:nth-child(" + tienda + ")"));
        public static IWebElement CmbLocal => Propiedades.Driver.FindElement(By.Name("FSTORE"));
        public static IWebElement OpcLocal => Propiedades.Driver.FindElement(By.XPath("/html/body/table[3]/tbody/tr/td[2]/table/tbody/tr/td/table[1]/tbody/tr[1]/td/form/select[1]/option/text()"));
        public static IWebElement CmbOfertasEst => Propiedades.Driver.FindElement(By.Name("FESTADO"));
        public static IWebElement OpcOfertasEst(string estado) => Propiedades.Driver.FindElement(By.CssSelector("# frmbuscar > select:nth-child(2) > option:nth-child(" + estado + ")"));
        public static IWebElement CmbSeccion => Propiedades.Driver.FindElement(By.Id("FDEPART"));
        public static IWebElement CmbTipo => Propiedades.Driver.FindElement(By.Name("FCTYPE"));
        public static IWebElement OpcTipo1(string tipo) => Propiedades.Driver.FindElement(By.CssSelector("#frmbuscar > select:nth-child(2) > option:nth-child(" + tipo + ")"));
        public static IWebElement OpcTipo(string tipo) => Propiedades.Driver.FindElement(By.CssSelector("#frmbuscar > select:nth-child(2) > option:nth-child(" + tipo + ")"));
        public static IWebElement CmbMedio => Propiedades.Driver.FindElement(By.Name("FMEDIO"));
        public static IWebElement OpcMedioDotaciones => Propiedades.Driver.FindElement(By.CssSelector("#frmbuscar > select:nth-child(11) > option:nth-child(2)"));
        public static IWebElement OpcMedioRetiros => Propiedades.Driver.FindElement(By.XPath("/html/body/table[3]/tbody/tr/td[2]/table/tbody/tr/td/table[1]/tbody/tr/td/form/select[3]/option[3]"));
        public static IWebElement CmbTipo2 => Propiedades.Driver.FindElement(By.Name("FTYPE"));
        public static IWebElement OpcTipo2(string tipo) => Propiedades.Driver.FindElement(By.CssSelector("#FTYPE > option:nth-child(" + tipo + ")"));
        public static IWebElement CmbTerminal => Propiedades.Driver.FindElement(By.Name("FTERM"));
        public static IWebElement OpcTerminal(string terminal) => Propiedades.Driver.FindElement(By.CssSelector("#Filtro > tbody > tr > td > select:nth-child(11) > option:nth-child(" + terminal + ")"));


        //BOTONES
        public static IWebElement BtnBuscar => Propiedades.Driver.FindElement(By.Id("B_FECHA_E"));
        public static IWebElement BtnFiltrar => Propiedades.Driver.FindElement(By.Id("B_FECHA_E"));
        public static IWebElement BtnFiltrarArt => Propiedades.Driver.FindElement(By.Id("FILTRAR"));
        public static IWebElement BtnLimpiarArt => Propiedades.Driver.FindElement(By.Id("LIMPIAR1"));
        public static IWebElement BtnBuscarArt => Propiedades.Driver.FindElement(By.Id("FIND_ART"));
        public static IWebElement BtnBuscarCod => Propiedades.Driver.FindElement(By.Id("FIND_EAN"));
        public static IWebElement BtnLimpiarArt2 => Propiedades.Driver.FindElement(By.Id("LIMPIAR"));
        public static IWebElement BtnBuscarOferta => Propiedades.Driver.FindElement(By.XPath("/html/body/table[3]/tbody/tr/td[2]/table/tbody/tr/td/table[1]/tbody/tr[1]/td/form/input[2]"));
        public static IWebElement BtnBuscarArticulo => Propiedades.Driver.FindElement(By.XPath("/html/body/table[3]/tbody/tr/td[2]/table/tbody/tr/td/table[1]/tbody/tr[1]/td/form/input[4]"));
        public static IWebElement BtnSalir => Propiedades.Driver.FindElement(By.Name("SALIR"));
        public static IWebElement BtnBuscarCampania => Propiedades.Driver.FindElement(By.Id("getCurrentCampaignBtn"));
        public static IWebElement BtnActualizar => Propiedades.Driver.FindElement(By.Name("ACTUALIZAR"));
        public static IWebElement BtnBuscar2 => Propiedades.Driver.FindElement(By.Name("BUSCAR"));

        //LINK
        public static IWebElement LnkMantAutorizacion => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td:nth-child(1) > a"));
        public static IWebElement LnkMediosPago => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td > a"));
        public static IWebElement LnkOferta => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#num_ofer0100088671 > span")));
        public static IWebElement LnkTicket => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/table[3]/tbody/tr/td[2]/table/tbody/tr/td/table[2]/tbody/tr/td/table/tbody/tr[2]/td[1]/img")));
        public static IWebElement LnkFechaContable => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#TcktM144756289")));
        public static IWebElement LnkRegistroTicket => Propiedades.Driver.FindElement(By.CssSelector("#mostrar534389 > img"));
        public static IWebElement LnkSobrantesFaltantes => Propiedades.Driver.FindElement(By.CssSelector("#TcktM534369 > span"));
        public static IWebElement LnkRegistroTicket2 => Propiedades.Driver.FindElement(By.Id("mostrar4934888"));
        public static IWebElement LnkSobrantesFaltantes2 => Propiedades.Driver.FindElement(By.Id("mostrar4934866"));


        //OPCION
        public static IWebElement OpcTodos => Propiedades.Driver.FindElement(By.CssSelector("#cantidadCopiasArticulos > tbody > tr > td:nth-child(2) > div > div > label > strong"));
        public static IWebElement OpcCliente => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#radio_selections > input[type=radio]:nth-child(7)")));


        //ASERTS
        public static IWebElement AsrAutorizacionSupervisor => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td:nth-child(6)"));
        public static IWebElement AsrDotacionesRetiros => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td:nth-child(4)"));
        public static IWebElement AsrVentacSeccion => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(3) > td:nth-child(1)"));
        public static IWebElement AsrRegistroTickets => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td:nth-child(3)"));
        public static IWebElement AsrRegistroTickets2 => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td:nth-child(3)"));
        public static IWebElement AsrRegistroTickets3 => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td:nth-child(3)"));
        public static IWebElement AsrSobrantesFaltantes => Propiedades.Driver.FindElement(By.CssSelector("#TR144756289OP1 > td:nth-child(1)"));
        public static IWebElement AsrMantAutorizaciones => Propiedades.Driver.FindElement(By.CssSelector("#GMessaje > a"));
        public static IWebElement AsrMantAutorizaciones2 => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td:nth-child(3)"));
        public static IWebElement AsrMantMedioPago => Propiedades.Driver.FindElement(By.CssSelector("#GMessaje > a"));
        public static IWebElement AsrMantMedioPago2 => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td"));
        public static IWebElement AsrVentasxMedioPago => Propiedades.Driver.FindElement(By.CssSelector("#ListadoCuad > tbody > tr:nth-child(2) > td:nth-child(3)"));
        public static IWebElement AsrReporteCartillas => Propiedades.Driver.FindElement(By.XPath("//*[@id=\"contenedor\"]/h4"));
        public static IWebElement AsrReporteVtasPromo => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(2) > td:nth-child(1)"));
        public static IWebElement AsrSobrantesFaltantes2 => Propiedades.Driver.FindElement(By.CssSelector("#TR534369OP1 > td:nth-child(1)"));
        public static IWebElement AsrVentasxArticulo => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(3) > td:nth-child(1)"));
        public static IWebElement AsrVentasxSeccion => Propiedades.Driver.FindElement(By.CssSelector("#Listado > tbody > tr:nth-child(3) > td:nth-child(1)"));
        public static IWebElement AsrControlInventStickers => Propiedades.Driver.FindElement(By.CssSelector("#activeCampaignNotFound > p"));
        public static IWebElement AsrHabladoresPreciosBajos => Propiedades.Driver.FindElement(By.CssSelector("#num_ofer0100085159 > span"));
        public static IWebElement AsrSobrantesFaltantes3 => Propiedades.Driver.FindElement(By.CssSelector("#TR4934866OP1 > td:nth-child(1)"));


    }
}
