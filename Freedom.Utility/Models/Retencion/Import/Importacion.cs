using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Freedom.Utility.Models.Retencion.Import
{
    public class Importacion
    {
        // importar al sistema(tesaka)
        //INTRODUCCIÓN
        //      El sistema permite la importación masiva de Comprobantes virtuales desde un archivo de texto.

        //      Mediante esta funcionalidad podrá obtener desde sus propias fuentes de información
        //          los datos de comprobantes para luego ser cargados dentro del presente sistema(tesaka)
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Detalle
    {
        /// <summary>
        /// Cantidad de ítems. Permite ingresar hasta dos decimales Ej.:10.55. Requerido.
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "cantidad de Detalle es obligatorio")]
        public decimal cantidad { get; set; }

        /// <summary>
        /// Se debe indicar la tasa que se aplica al ítem (exento(0), 5% o 10%). Requerido
        /// </summary>
        [StringLength(5, ErrorMessage = "El Campo tasaAplica debe tener al menos de 1 a 5 caracteres", MinimumLength = 1)]
        public string tasaAplica { get; set; }

        /// <summary>
        /// Valor del Precio de un ítem. Para el caso de importes gravados este campo es IVA Incluido.
        /// Si la operación es en moneda extranjera permite ingresar importes con hasta dos decimales Ej.: 10.55. Requerido.
        /// </summary>
        //[JsonConverter(typeof(JsonConverterZeroDecimal))]
        public decimal precioUnitario { get; set; }

        /// <summary>
        /// Descripción de la fila de detalles, requerido.
        /// </summary>
        [StringLength(50, ErrorMessage = "El Campo Descripcion debe tener al menos de 1 a 300 caracteres", MinimumLength = 1)]
        public string descripcion { get; set; } = "VENTA DE MERCADERIAS";
    }

    public class Retencion
    {
        /// <summary>
        /// Aquí debe informar en que moneda se encuentra la operación. Requerido
        /// </summary>
        [Required(ErrorMessage = "Fecha de retencion es Obligatorio")]
        public string moneda { get; set; } = "PYG";

        /// <summary>
        /// Requerido si moneda PYG.
        /// Aquí debe informar el tipo de cambio a utilizar según la moneda antes informada.
        /// Este campo debe entero, positivo y sin decimales.
        /// </summary>
        // [JsonConverter(typeof(JsonConverterZeroDecimal))]
        // [JsonIgnore]
        public decimal tipoCambio { get; set; }

        /// <summary>
        /// Aquí  debe  ingresar  la  fecha  de  la retención. Requerido.
        /// </summary>
        [Required(ErrorMessage = "Fecha de retencion es Obligatorio")]
        public string fecha { get; set; }

        /// <summary>
        /// (true/ false) Indica si se retiene renta. Requerido.
        /// </summary>
        public bool retencionRenta { get; set; } = true;

        /// <summary>
        /// Aquídebe ingresar el conceptode la retención
        /// </summary>
        [Required(ErrorMessage = "conceptoRenta es Obligatorio")]
        public string conceptoRenta { get; set; } = "COMERCIAL_INDUSTRIAL_SERVICIO_REGISTRADO.1";

        /// <summary>
        /// Aquíva  el  porcentaje  a  ser  aplicado sobre  la  base  imponible  delIVA  5. Requerido
        /// </summary>
        public decimal ivaPorcentaje5 { get; set; }

        /// <summary>
        /// Aquíva  el  porcentaje  a  ser  aplicado sobre  la  base  imponible  del  IVA  10. Requerido.
        /// </summary>
        public decimal ivaPorcentaje10 { get; set; }

        /// <summary>
        /// Aquídebe  indicar  el  monto  de  la retención  a  ser  aplicado  sobre  cada cabeza. Requerido
        /// </summary>
        public decimal rentaCabezasBase { get; set; } = 0;

        /// <summary>
        /// Aquídebe   indicar   la   cantidad   de cabezas  sobre  la  cual  se  aplicara  la retención. Requerido
        /// </summary>
        public decimal rentaCabezasCantidad { get; set; } = 0;

        /// <summary>
        /// Aquídebe  indicar el monto  de  la retención  a  ser  aplicado  sobre  cada tonelada. Requerido
        /// </summary>
        public decimal rentaToneladasBase { get; set; } = 0;

        /// <summary>
        /// Aquídebe   indicar   la   cantidad   de toneladas sobre la cual se aplicara la retención. Requerido
        /// </summary>
        public decimal rentaToneladasCantidad { get; set; } = 0;

        public decimal rentaPorcentaje { get; set; }

        public bool retencionIva { get; set; } = false;

        public string conceptoIva { get; set; } = "";
    }

    public class Representante
    {
        /// <summary>
        /// Indica el tipo de identificación del representante legal Requerido si tieneRepresentante = tru
        /// </summary>
        public string tipoIdentificacion { get; set; } = "";

        /// <summary>
        /// Se debe ingresar el número de identificación del representante legal.
        /// Requerido si tieneRepresentante = true
        /// </summary>
        public string identificacion { get; set; }

        /// <summary>
        /// Se debe ingresar el Nombre del Representante Legal.
        /// Requerido si tieneRepresentante = true
        /// </summary>
        public string nombre { get; set; }
    }

    public class Beneficiario
    {
        /// <summary>
        /// Se indica el tipo de identificación del beneficiario. Requerido si tieneBeneficiario = true
        /// </summary>
        public string tipoIdentificacion { get; set; }

        /// <summary>
        /// Se debe ingresar el número de identificación del representante legal. Requerido si tieneBeneficario = true
        /// </summary>
        public string identificacion { get; set; }

        /// <summary>
        /// se debe ingresar el nombre o razón social del beneficiario. Requerido si tieneBeneficiario  = true
        /// </summary>
        public string nombre { get; set; }
    }

    /// <summary>
    /// proveedor
    /// </summary>
    public class Informado
    {
        /// <summary>
        ///  Requerido ej. CONTRIBUYENTE, NO_CONTRIBUYENTE, NO_RESIDENTE
        /// </summary>
        [Required(ErrorMessage = "situacion es Obligatorio")]
        public string situacion { get; set; } = "CONTRIBUYENTE";

        /// <summary>
        /// Requerido si Situación = contribuyente
        /// </summary>
        [Required(ErrorMessage = "ruc es Obligatorio")]
        public string ruc { get; set; }

        /// <summary>
        /// Requerido si Situación = contribuyente
        /// </summary>
        [Required(ErrorMessage = "dv es Obligatorio")]
        public string dv { get; set; }

        /// <summary>
        /// Requerido si Situacion No-Es contribuyente
        /// CEDULA, CARNE_RESIDEN, PASAPORTE, IDENTIFICACION_TRIBUTARIA, INNOMINADO_COOPERATIV
        /// </summary>
        public string tipoIdentificacion { get; set; }

        /// <summary>
        ///En caso que el informado sea No-Contribuyente o No-resident
        /// </summary>
        public string identificacion { get; set; }

        /// <summary>
        /// Nombre del proveedor
        /// </summary>
        [Required(ErrorMessage = "nombre es Obligatorio")]
        public string nombre { get; set; }

        /// <summary>
        /// Para el caso de un informado contribuyente, aquí debe especificar cuál es su domicili
        /// </summary>
        public string domicilio { get; set; }

        /// <summary>
        /// Para un caso de un informado no contribuyente o no residente, aquí debe especificar su dirección
        /// </summary>

        public string direccion { get; set; }

        /// <summary>
        /// si no es contibyente es requerido
        /// </summary>
        public string correoElectronico { get; set; }

        /// <summary>
        /// Para un caso de un informado no residente, aquí debe especificar su país de orig
        /// </summary>
        [JsonIgnore]
        public string pais { get; set; } = "PY";

        /// <summary>
        /// Para un caso de un informado no-contribuyente o no-residente
        /// </summary>
        public string telefono { get; set; } = "";

        //public string nombreFantasia { get; set; }

        /// <summary>
        /// Indica si se informa Representante Legal cuando Situación del informado es No residente.
        /// Requerido cuando Situación = No Resident
        /// </summary>
        public bool tieneRepresentante { get; set; } = false;

        /// <summary>
        /// Indica si se informa beneficiario cuando Situación del informado es No-Residente.
        /// Requerido cuando Situación = No-Resident
        /// </summary>
        public bool tieneBeneficiario { get; set; } = false;

        [JsonIgnore]
        public Representante representante { get; set; }

        [JsonIgnore]
        public Beneficiario beneficiario { get; set; }
    }

    public class Transaccion
    {
        /// <summary>
        /// Aquídebe ingresar en número del comprobante de venta sobre la cual se practicara la retención. Requerido
        /// </summary>
        [Required(ErrorMessage = "numeroComprobanteVenta es Obligatorio")]
        public string numeroComprobanteVenta { get; set; }

        /// <summary>
        /// Aquídebe informar la condición de compra. Requerido.
        /// ej. CONTADO, CREDITO
        /// </summary>
        [Required(ErrorMessage = "condicionCompra es Obligatorio")]
        public string condicionCompra { get; set; }

        /// <summary>
        /// Requerido si condicionCompra = CREDITO
        /// </summary>
        public int cuotas { get; set; }

        /// <summary>
        /// Codificación de tipo de comprobante. Requerido.
        /// </summary>
        [Range(1, 20, ErrorMessage = "tipoComprobante es obligatorio")]
        public int tipoComprobante { get; set; }

        /// <summary>
        /// Aquí debe ingresar la fecha del comprobante de venta, Formato= yyyy-MM-dd
        /// </summary>
        [Required(ErrorMessage = "Fecha es Obligatorio")]
        public string fecha { get; set; }

        /// <summary>
        /// Aquí debe ingresar en número de timbrado del comprobante de venta. Requerido
        /// </summary>
        [Required(ErrorMessage = "numeroTimbrado es Obligatorio")]
        public string numeroTimbrado { get; set; }
    }

    public class Atributos
    {
        /// <summary>
        /// Obligatorio, Formato = "yyyy-MM-dd"
        /// </summary>
        [Required(ErrorMessage = "fechaCreacion es Obligatorio")]
        public string fechaCreacion { get; set; }

        /// <summary>
        /// No Requerido Formato= "yyyy-MM-dd HH:mm:SS"
        /// </summary>
        public string fechaHoraCreacion { get; set; }
    }

    public class Root
    {
        public List<Detalle> detalle { get; set; }

        public Retencion retencion { get; set; }

        public Informado informado { get; set; }

        public Transaccion transaccion { get; set; }

        public Atributos atributos { get; set; }
    }
}