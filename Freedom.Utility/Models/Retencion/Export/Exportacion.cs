using System.Collections.Generic;

namespace Freedom.Utility.Models.Retencion.Export
{
    public class Exportacion
    {
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Root
    {
        public Datos datos { get; set; }
        public string estado { get; set; }
        public Recepcion recepcion { get; set; }
    }

    public class Datos
    {
        public List<Detalle> detalle { get; set; }
        public Retencion retencion { get; set; }
        public Informado informado { get; set; }
        public Transaccion transaccion { get; set; }
        public Atributos atributos { get; set; }
        public Totales totales { get; set; }
        public Informante informante { get; set; }
        public string id { get; set; }
    }

    public class Detalle
    {
        public int cantidad { get; set; }
        public string tasaAplica { get; set; }
        public int precioUnitario { get; set; }
        public string descripcion { get; set; }
        public int precioTotalExento { get; set; }
        public int precioTotalAl5 { get; set; }
        public int precioTotalAl10 { get; set; }
        public int precioTotal { get; set; }
        public int impuestoExento { get; set; }
        public int impuestoAl5 { get; set; }
        public int impuestoAl10 { get; set; }
    }

    public class Retencion
    {
        public string moneda { get; set; }
        public string fecha { get; set; }
        public bool retencionRenta { get; set; }
        public string conceptoRenta { get; set; }
        public int ivaPorcentaje5 { get; set; }
        public int ivaPorcentaje10 { get; set; }
        public int rentaCabezasBase { get; set; }
        public int rentaCabezasCantidad { get; set; }
        public int rentaToneladasBase { get; set; }
        public int rentaToneladasCantidad { get; set; }
        public double rentaPorcentaje { get; set; }
        public bool retencionIva { get; set; }
        public string conceptoIva { get; set; }
        public string conceptoIvaNombre { get; set; }
        public string conceptoRentaNombre { get; set; }
        public string monedaNombre { get; set; }
        public bool habilitadoRentaCabezas { get; set; }
        public bool habilitadoRentaToneladas { get; set; }
        public int ivaBase5 { get; set; }
        public int ivaTotal5 { get; set; }
        public int ivaBase10 { get; set; }
        public int ivaTotal10 { get; set; }
        public int ivaTotal { get; set; }
        public int rentaBase { get; set; }
        public int rentaTotal { get; set; }
        public int rentaCabezasTotal { get; set; }
        public int rentaToneladasTotal { get; set; }
        public int retencionIvaTotal { get; set; }
        public int retencionRentaTotal { get; set; }
        public int retencionTotal { get; set; }
    }

    public class Representante
    {
        public string tipoIdentificacion { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
    }

    public class Beneficiario
    {
        public string tipoIdentificacion { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
    }

    public class Informado
    {
        public string situacion { get; set; }
        public string nombre { get; set; }
        public string ruc { get; set; }
        public string dv { get; set; }
        public string domicilio { get; set; }
        public string tipoIdentificacion { get; set; }
        public string identificacion { get; set; }
        public string direccion { get; set; }
        public string correoElectronico { get; set; }
        public string pais { get; set; }
        public string telefono { get; set; }
        public string tipoIdentificacionNombre { get; set; }
        public string paisNombre { get; set; }
        public bool tieneRepresentante { get; set; }
        public bool tieneBeneficiario { get; set; }
        public Representante representante { get; set; }
        public Beneficiario beneficiario { get; set; }
    }

    public class Transaccion
    {
        public string numeroComprobanteVenta { get; set; }
        public string condicionCompra { get; set; }
        public int tipoComprobante { get; set; }
        public string fecha { get; set; }
        public string numeroTimbrado { get; set; }
        public string tipoComprobanteNombre { get; set; }
    }

    public class Atributos
    {
        public string fechaCreacion { get; set; }
        public string fechaHoraCreacion { get; set; }
        public string uuid { get; set; }
        public string version { get; set; }
    }

    public class Totales
    {
        public int impuestoTotalExento { get; set; }
        public int impuestoTotalAl5 { get; set; }
        public int impuestoTotalAl10 { get; set; }
        public int valorTotalExento { get; set; }
        public int valorTotalAl5 { get; set; }
        public int valorTotalAl10 { get; set; }
        public int impuestoTotal { get; set; }
        public int valorTotal { get; set; }
    }

    public class Informante
    {
        public string nombre { get; set; }
        public string dv { get; set; }
        public object nombreFantasia { get; set; }
        public string domicilioEmision { get; set; }
        public string telefono { get; set; }
        public string ruc { get; set; }
        public string codigoEstablecimiento { get; set; }
        public string timbradoComprobante { get; set; }
        public string puntoExpedicionComprobante { get; set; }
        public string inicioVigenciaComprobante { get; set; }
        public string establecimiento { get; set; }
    }

    public class Recepcion
    {
        public string fechaProceso { get; set; }
        public string numeroComprobante { get; set; }
        public string numeroControl { get; set; }
        public string fechaEmision { get; set; }
        public string cadenaControl { get; set; }
        public bool recepcionCorrecta { get; set; }
        public object mensajeRecepcion { get; set; }
        public object codigoProcesamiento { get; set; }
        public bool procesamientoCorrecto { get; set; }
        public object mensajeProcesamiento { get; set; }
        public string numero { get; set; }
        public string fechaRecepcion { get; set; }
        public string hash { get; set; }
    }
}