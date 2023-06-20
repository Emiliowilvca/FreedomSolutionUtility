using System.Text.Json.Serialization;

namespace Freedom.Utility.Models.Retencion.Import
{

    // importar al sistema(tesaka)
    /// <summary>
    /// El sistema permite la importación masiva de Comprobantes virtuales desde un archivo de texto.
    ///  Mediante esta funcionalidad podrá obtener desde sus propias fuentes de información
    ///  los datos de comprobantes para luego ser cargados dentro del presente sistema(tesaka)
    /// </summary>
    public class ImportacionRetencion
    {
        [JsonPropertyName("detalle")]
        public List<Detalle> Detalle { get; set; }

        [JsonPropertyName("retencion")]
        public Retencion Retencion { get; set; }

        [JsonPropertyName("informado")]
        public Informado Informado { get; set; }

        [JsonPropertyName("transaccion")]
        public Transaccion Transaccion { get; set; }

        [JsonPropertyName("atributos")]
        public Atributos Atributos { get; set; }
    }

    public class Detalle
    {
        /// <summary>
        /// Cantidad de ítems. Permite ingresar hasta dos decimales Ej.:10.55. *Requerido.
        /// </summary>
        [JsonPropertyName("cantidad")] 
        public decimal Cantidad { get; set; }

        /// <summary>
        /// Se debe indicar la tasa que se aplica al ítem (exento(0), 5% o 10%). Requerido
        /// </summary>
        [JsonPropertyName("tasaAplica")]
        public string TasaAplica { get; set; }

        /// <summary>
        /// Valor del Precio de un ítem. Para el caso de importes gravados este campo es IVA Incluido.
        /// Si la operación es en moneda extranjera permite ingresar importes con hasta dos decimales Ej.: 10.55. Requerido.
        /// </summary>
        //[JsonConverter(typeof(JsonConverterZeroDecimal))]
        [JsonPropertyName("precioUnitario")]
        public decimal PrecioUnitario { get; set; }

        /// <summary>
        /// Descripción de la fila de detalles, requerido. *Requerido. MAX lenht=300
        /// </summary>
        [JsonPropertyName("descripcion")]
        public string Descripcion { get; set; } = "VENTA DE MERCADERIAS";
    }

    public class Retencion
    {
        /// <summary>
        /// Aquí debe informar en que moneda se encuentra la operación. Requerido
        /// </summary>
        [JsonPropertyName("moneda")]
        public string Moneda { get; set; } = "PYG";

        /// <summary>
        /// Requerido si moneda PYG.
        /// Aquí debe informar el tipo de cambio a utilizar según la moneda antes informada.
        /// Este campo debe entero, positivo y sin decimales.
        /// </summary>
        [JsonPropertyName("tipoCambio")]
        public decimal? TipoCambio { get; set; }

        /// <summary>
        /// Aquí  debe  ingresar  la  fecha  de  la retención. Requerido.
        /// </summary>
        [JsonPropertyName("fecha")]
        public string Fecha { get; set; }

        /// <summary>
        /// (true/ false) Indica si se retiene renta. Requerido.
        /// </summary>
        [JsonPropertyName("retencionRenta")]
        public bool RetencionRenta { get; set; } = true;

        /// <summary>
        /// Aquídebe ingresar el conceptode la retención
        /// </summary>
        [JsonPropertyName("conceptoRenta")]
        public string ConceptoRenta { get; set; }

        /// <summary>
        /// Aquíva  el  porcentaje  a  ser  aplicado sobre  la  base  imponible  delIVA  5. Requerido
        /// </summary>
        [JsonPropertyName("ivaPorcentaje5")]
        public decimal IvaPorcentaje5 { get; set; }

        /// <summary>
        /// Aquíva  el  porcentaje  a  ser  aplicado sobre  la  base  imponible  del  IVA  10. Requerido.
        /// </summary>
        [JsonPropertyName("ivaPorcentaje10")]
        public decimal IvaPorcentaje10 { get; set; }

        /// <summary>
        /// Aquídebe  indicar  el  monto  de  la retención  a  ser  aplicado  sobre  cada cabeza. Requerido
        /// </summary>
        [JsonPropertyName("rentaCabezasBase")]
        public decimal RentaCabezasBase { get; set; } = 0;

        /// <summary>
        /// Aquídebe   indicar   la   cantidad   de cabezas  sobre  la  cual  se  aplicara  la retención. Requerido
        /// </summary>
        [JsonPropertyName("rentaCabezasCantidad")]
        public decimal RentaCabezasCantidad { get; set; } = 0;

        /// <summary>
        /// Aquídebe  indicar el monto  de  la retención  a  ser  aplicado  sobre  cada tonelada. Requerido
        /// </summary>
        [JsonPropertyName("rentaToneladasBase")]
        public decimal RentaToneladasBase { get; set; } = 0;

        /// <summary>
        /// Aquídebe   indicar   la   cantidad   de toneladas sobre la cual se aplicara la retención. Requerido
        /// </summary>
        [JsonPropertyName("rentaToneladasCantidad")]
        public decimal RentaToneladasCantidad { get; set; } = 0;
      
        [JsonPropertyName("rentaPorcentaje")]
        public decimal RentaPorcentaje { get; set; }

        [JsonPropertyName("retencionIva")]
        public bool RetencionIva { get; set; } = false;

        [JsonPropertyName("conceptoIva")]
        public string ConceptoIva { get; set; }
    }

    /// <summary>
    /// proveedor
    /// </summary>
    public class Informado
    {
        /// <summary>
        ///  Requerido ej. CONTRIBUYENTE, NO_CONTRIBUYENTE, NO_RESIDENTE
        /// </summary>
        [JsonPropertyName("situacion")]
        public string Situacion { get; set; } = "CONTRIBUYENTE";

        /// <summary>
        /// Requerido si Situación = contribuyente
        /// </summary>
        [JsonPropertyName("ruc")]
        public string Ruc { get; set; }

        /// <summary>
        /// Requerido si Situación = contribuyente
        /// </summary>
        [JsonPropertyName("dv")]
        public string Dv { get; set; }

        /// <summary>
        /// Requerido si Situacion No-Es contribuyente
        /// CEDULA, CARNE_RESIDEN, PASAPORTE, IDENTIFICACION_TRIBUTARIA, INNOMINADO_COOPERATIV
        /// </summary>
        [JsonPropertyName("tipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        /// <summary>
        ///En caso que el informado sea No-Contribuyente o No-resident
        /// </summary>
        [JsonPropertyName("identificacion")]
        public string Identificacion { get; set; }

        /// <summary>
        /// Nombre del proveedor *Requerido
        /// </summary>
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        /// <summary>
        /// Para el caso de un informado contribuyente, aquí debe especificar cuál es su domicili
        /// </summary>
        [JsonPropertyName("domicilio")]
        public string Domicilio { get; set; }

        /// <summary>
        /// Para un caso de un informado no contribuyente o no residente, aquí debe especificar su dirección
        /// </summary>

        [JsonPropertyName("direccion")]
        public string Direccion { get; set; }

        /// <summary>
        /// si no es contibyente es requerido
        /// </summary>
        [JsonPropertyName("correoElectronico")]
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Para un caso de un informado no residente, aquí debe especificar su país de orig
        /// </summary>
        [JsonIgnore]
        [JsonPropertyName("pais")]
        public string Pais { get; set; } = "PY";

        /// <summary>
        /// Para un caso de un informado no-contribuyente o no-residente
        /// </summary>
        [JsonPropertyName("telefono")]
        public string Telefono { get; set; } = "";

        //public string nombreFantasia { get; set; }

        /// <summary>
        /// Indica si se informa Representante Legal cuando Situación del informado es No residente.
        /// Requerido cuando Situación = No Resident
        /// </summary>
        [JsonIgnore]
        [JsonPropertyName("tieneRepresentante")]
        public bool TieneRepresentante { get; set; } = false;

        /// <summary>
        /// Indica si se informa beneficiario cuando Situación del informado es No-Residente.
        /// Requerido cuando Situación = No-Resident
        /// </summary>
        [JsonIgnore]
        [JsonPropertyName("tieneBeneficiario")]
        public bool TieneBeneficiario { get; set; } = false;

        [JsonIgnore]
        [JsonPropertyName("representante")]
        public Representante Representante { get; set; }

        [JsonIgnore]
        [JsonPropertyName("beneficiario")]
        public Beneficiario Beneficiario { get; set; }
    }

    public class Transaccion
    {
        /// <summary>
        /// Aquídebe ingresar en número del comprobante de venta sobre la cual se practicara la retención. *Requerido
        /// </summary>
        [JsonPropertyName("numeroComprobanteVenta")]
        public string NumeroComprobanteVenta { get; set; }

        /// <summary>
        /// Aquídebe informar la condición de compra. Requerido.
        /// ej. CONTADO, CREDITO
        /// </summary>
        [JsonPropertyName("condicionCompra")]
        public string CondicionCompra { get; set; }

        /// <summary>
        /// Requerido si condicionCompra = CREDITO
        /// </summary>
        [JsonPropertyName("cuotas")]
        public int Cuotas { get; set; }

        /// <summary>
        /// Codificación de tipo de comprobante. Requerido. Range(1-20)
        /// </summary>
        [JsonPropertyName("tipoComprobante")]
        public int TipoComprobante { get; set; }

        /// <summary>
        /// Aquí debe ingresar la fecha del comprobante de venta, Formato= yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("fecha")]
        public string Fecha { get; set; }

        /// <summary>
        /// Aquí debe ingresar en número de timbrado del comprobante de venta. Requerido
        /// </summary>
        [JsonPropertyName("numeroTimbrado")]
        public string NumeroTimbrado { get; set; }
    }

    public class Atributos
    {
        /// <summary>
        /// Obligatorio, Formato = "yyyy-MM-dd"
        /// </summary>
        [JsonPropertyName("fechaCreacion")]
        public string FechaCreacion { get; set; }

        /// <summary>
        /// No Requerido Formato= "yyyy-MM-dd HH:mm:SS"
        /// </summary>
        [JsonPropertyName("fechaHoraCreacion")]
        public string FechaHoraCreacion { get; set; }
    }

    public class Representante
    {
        /// <summary>
        /// Indica el tipo de identificación del representante legal Requerido si tieneRepresentante = tru
        /// </summary>
        [JsonPropertyName("tipoIdentificacion")]
        public string TipoIdentificacion { get; set; } = "";

        /// <summary>
        /// Se debe ingresar el número de identificación del representante legal.
        /// Requerido si tieneRepresentante = true
        /// </summary>
        [JsonPropertyName("identificacion")]
        public string Identificacion { get; set; }

        /// <summary>
        /// Se debe ingresar el Nombre del Representante Legal.
        /// Requerido si tieneRepresentante = true
        /// </summary>
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
    }

    public class Beneficiario
    {
        /// <summary>
        /// Se indica el tipo de identificación del beneficiario. Requerido si tieneBeneficiario = true
        /// </summary>
        [JsonPropertyName("tipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        /// <summary>
        /// Se debe ingresar el número de identificación del representante legal. Requerido si tieneBeneficario = true
        /// </summary>
        [JsonPropertyName("identificacion")]
        public string Identificacion { get; set; }

        /// <summary>
        /// se debe ingresar el nombre o razón social del beneficiario. Requerido si tieneBeneficiario  = true
        /// </summary>
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
    }
}