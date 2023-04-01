namespace Freedom.Utility.AllPurpose
{

    /// <summary>
    /// Extracto cuenta de cliente
    /// </summary>
    public interface IStatement
    {
        DateTime OperationDate { get; set; }

        string DocumentNumber { get; set; }

        string Concept { get; set; }

        /// <summary>
        /// DEBE(isq),Aumentar cuenta, cargar, entrada, ex: venta, prestamos, fletes
        /// </summary>
        decimal Debit { get; set; }

        /// <summary>
        /// HABER(der),Disminuir cuenta, salida, ex: cobros, devolucion, nota credito
        /// </summary>
        decimal Credit { get; set; }

        decimal Balance { get; set; }
    }
}