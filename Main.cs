using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suite.Funcionalidades;

namespace Central
{
    [TestClass]
    public class Administracion
    {
        [TestMethod]
        public void LineasNegocio() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\LineasNegocio"); }
        /*[TestMethod]
        public void TiendasAlmacenes() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\TiendasAlmacenes"); }*/
        [TestMethod]
        public void CodigosImpuesto() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\CodigosImpuesto"); }
        [TestMethod]
        public void MantenimientoToken() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\MantenimientoToken"); }
        [TestMethod]
        public void PCAutorizados() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\PCAutorizados"); }
        [TestMethod]
        public void PerfilesUsuario() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\PerfilesUsuario"); }
        [TestMethod]
        public void UsuarioArms() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\UsuarioArms"); }
        [TestMethod]
        public void ConfiguracionRegional() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\ConfiguracionRegional"); }
        [TestMethod]
        public void LogAccesos() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\LogAccesos"); }
        [TestMethod]
        public void ModulosArms() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\ModulosArms"); }
        [TestMethod]
        public void ParametrosArms() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\ParametrosArms"); }
        [TestMethod]
        public void PerfilesPredeterOperTienda() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\PerfilesPredeterOperTienda"); }
        [TestMethod]
        public void SistemaArms() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Administracion\\SistemaArms"); }
        [TestMethod]
        public void RegistroCotizaciones() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Cotizaciones\\RegistroCotizaciones"); }
       /* [TestMethod]
        public void MantenimientoClientes() { PpAdministracion.FuncionalidadesCentral("SuiteCentral\\Cotizaciones\\MantenimientoClientes"); }*/
    }

    [TestClass]
    public class ArqueosCierre
    {
        [TestMethod]
        public void InformeCierreDiaHistoricos() { PpArqueosCierres.FuncionalidadesCentral("SuiteCentral\\ArqueosCierre\\InformeCierreDiaHistoricos"); }
        [TestMethod]
        public void InformeResumenTienda() { PpArqueosCierres.FuncionalidadesCentral("SuiteCentral\\ArqueosCierre\\InformeResumenTienda"); }
        [TestMethod]
        public void InformeCierreDiaHistoricoAnterior() { PpArqueosCierres.FuncionalidadesCentral("SuiteCentral\\ArqueosCierre\\InformeCierreDiaHistoricoAnterior"); }
        [TestMethod]
        public void MonitorCuadre() { PpArqueosCierres.FuncionalidadesCentral("SuiteCentral\\ArqueosCierre\\MonitorCuadre"); }
        [TestMethod]
        public void RegistroDepositosCierreDia() { PpArqueosCierres.FuncionalidadesCentral("SuiteCentral\\ArqueosCierre\\RegistroDepositosCierreDia"); }
        [TestMethod]
        public void RegistroDepositosParciales() { PpArqueosCierres.FuncionalidadesCentral("SuiteCentral\\ArqueosCierre\\RegistroDepositosParciales"); }
    }

    [TestClass]
    public class Cotizaciones
    {
        [TestMethod]
        public void RegistroCotizaciones() { PpCotizaciones.FuncionalidadesCentral("SuiteCentral\\Cotizaciones\\RegistroCotizaciones"); }
        [TestMethod]
        public void MantenimientoCliente() { PpCotizaciones.FuncionalidadesCentral("SuiteCentral\\Cotizaciones\\MantenimientoCliente"); }
    }

    [TestClass]
    public class Devoluciones
    {
        [TestMethod]
        public void RegistrarDevolucion() { PpDevoluciones.FuncionalidadesCentral("SuiteCentral\\Devoluciones\\RegistrarDevolucion"); }
        [TestMethod]
        public void ListadoNotasCredito() { PpDevoluciones.FuncionalidadesCentral("SuiteCentral\\Devoluciones\\ListadoNotasCredito"); }
    }

    [TestClass]
    public class Eyes
    {
        /*[TestMethod]
        public void MonitorMensajes() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\MonitorMensajes"); }*/
        [TestMethod]
        public void MonitorProcesos() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\MonitorProcesos"); }
        /*[TestMethod]
        public void MonitorEstadoTiendas() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\MonitorEstadoTiendas"); }*/
        [TestMethod]
        public void ConfiguracionDispositivosPinpad() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\ConfiguracionDispositivosPinpad"); }
        /*[TestMethod]
        public void InpresorasFlejes() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\InpresorasFlejes"); }*/
        [TestMethod]
        public void MantConfiguradorConciliacionesPinpad() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\MantConfiguradorConciliacionesPinpad"); }
        [TestMethod]
        public void MantEstadosProcesos() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\MantEstadosProcesos"); }
        [TestMethod]
        public void MantProcesos() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\MantProcesos"); }
        [TestMethod]
        public void MantSeveridadMensajes() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\MantSeveridadMensajes"); }
        [TestMethod]
        public void LogArmsServer() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\LogArmsServer"); }
        [TestMethod]
        public void LogTransacciones() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\LogTransacciones"); }
        [TestMethod]
        public void SyscardLog() { PpEyes.FuncionalidadesCentral("SuiteCentral\\Eyes\\SyscardLog"); }
    }

    [TestClass]
    public class OperadorCentral
    {
        [TestMethod]
        public void EmitirCodigoAutorizacion() { PpOperadorCentral.FuncionalidadesCentral("SuiteCentral\\OperadorCentral\\EmitirCodigoAutorizacion"); }
        [TestMethod]
        public void RegistroOperadores() { PpOperadorCentral.FuncionalidadesCentral("SuiteCentral\\OperadorCentral\\RegistroOperadores"); }
        [TestMethod]
        public void LogOperadores() { PpOperadorCentral.FuncionalidadesCentral("SuiteCentral\\OperadorCentral\\LogOperadores"); }
    }

    [TestClass]
    public class PreciosFlejes
    {
        [TestMethod]
        public void ProcesarLoteActualizacionPrecios() { PpPreciosFlejes.FuncionalidadesCentral("SuiteCentral\\PreciosFlejes\\ProcesarLoteActualizacionPrecios"); }
        [TestMethod]
        public void ProcesarLoteEtiquetasPreciosxMayor() { PpPreciosFlejes.FuncionalidadesCentral("SuiteCentral\\PreciosFlejes\\ProcesarLoteEtiquetasPreciosxMayor"); }
        [TestMethod]
        public void ImpresionFlejes() { PpPreciosFlejes.FuncionalidadesCentral("SuiteCentral\\PreciosFlejes\\ImpresionFlejes"); }
        [TestMethod]
        public void MantUsuariosBalanza() { PpPreciosFlejes.FuncionalidadesCentral("SuiteCentral\\PreciosFlejes\\MantUsuariosBalanza"); }
        [TestMethod]
        public void MantEstadosProceso() { PpPreciosFlejes.FuncionalidadesCentral("SuiteCentral\\PreciosFlejes\\MantEstadosProceso"); }
        [TestMethod]
        public void MantInteresesFlejesDiferidos() { PpPreciosFlejes.FuncionalidadesCentral("SuiteCentral\\PreciosFlejes\\MantInteresesFlejesDiferidos"); }
    }

    [TestClass]
    public class Reportes
    {
        [TestMethod]
        public void AutorizacionesSupervisor() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\AutorizacionesSupervisor"); }
        [TestMethod]
        public void DotacionesRetiros() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\DotacionesRetiros"); }
        [TestMethod]
        public void VentasxArticulo() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\VentasxArticulo"); }
        [TestMethod]
        public void VentasxMedioPago() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\VentasxMedioPago"); }
        [TestMethod]
        public void VentasxSeccion() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\VentasxSeccion"); }
        [TestMethod]
        public void ConsultaKardexSticker() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\ConsultaKardexSticker"); }
        [TestMethod]
        public void HabladoresPreciosBajos() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\HabladoresPreciosBajos"); }
        [TestMethod]
        public void Habladores() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\Habladores"); }
        [TestMethod]
        public void ProductosxPromociones() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\ProductosxPromociones"); }
        [TestMethod]
        public void RegistrodeTickets() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\RegistrodeTickets"); }
        [TestMethod]
        public void RegistroPromociones() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\RegistroPromociones"); }
        [TestMethod]
        public void ReporteVentasCartillasFísicas() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\ReporteVentasCartillasFísicas"); }
        [TestMethod]
        public void ReporteVentasPromoción() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\ReporteVentasPromoción"); }
        [TestMethod]
        public void SobrantesFaltantes() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\SobrantesFaltantes"); }
        [TestMethod]
        public void MantMediosPago() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\MantMediosPago"); }
        [TestMethod]
        public void MantAutorizaciones() { PpReportes.FuncionalidadesCentral("SuiteCentral\\Reportes\\MantAutorizaciones"); }
    }


    [TestClass]
    public class TipoCER
    {
        [TestMethod]
        public void RecargasElectronica() { PpTipoCer.FuncionalidadesCentral("SuiteCentral\\TipoCER\\RecargasElectronica"); }
        [TestMethod]
        public void RegistroBines() { PpTipoCer.FuncionalidadesCentral("SuiteCentral\\TipoCER\\RegistroBines"); }
        [TestMethod]
        public void RegistroOpcionesPagoBines() { PpTipoCer.FuncionalidadesCentral("SuiteCentral\\TipoCER\\RegistroOpcionesPagoBines"); }
        [TestMethod]
        public void RegistroDepartamentos() { PpTipoCer.FuncionalidadesCentral("SuiteCentral\\TipoCER\\RegistroDepartamentos"); }
        [TestMethod]
        public void MantBinesGrupoRestriccion() { PpTipoCer.FuncionalidadesCentral("SuiteCentral\\TipoCER\\MantBinesGrupoRestriccion"); }
        [TestMethod]
        public void MantCuentaBancos() { PpTipoCer.FuncionalidadesCentral("SuiteCentral\\TipoCER\\MantCuentaBancos"); }
        [TestMethod]
        public void MantIdentificadorTarjetas() { PpTipoCer.FuncionalidadesCentral("SuiteCentral\\TipoCER\\MantIdentificadorTarjetas"); }
        /*[TestMethod]
        public void MantRangosBines() { PpTipoCer.FuncionalidadesCentral("SuiteCentral\\TipoCER\\MantRangosBines"); }*/
        [TestMethod]
        public void MantRangosInternacionales() { PpTipoCer.FuncionalidadesCentral("SuiteCentral\\TipoCER\\MantRangosInternacionales"); }
    }


    [TestClass]
    public class Race
    {
        [TestMethod]
        public void InformesContabilidad() { PpRace.FuncionalidadesCentral("SuiteCentral\\RACE\\InformesContabilidad"); }
        [TestMethod]
        public void InformesVentas() { PpRace.FuncionalidadesCentral("SuiteCentral\\RACE\\InformesVentas"); }
    }

    [TestClass]
    public class Motos
    {
        [TestMethod]
        public void CartaVenta() { PpMotos.FuncionalidadesCentral("SuiteCentral\\Motos\\CartaVenta"); }
    }

}
