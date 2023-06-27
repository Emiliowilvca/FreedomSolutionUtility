namespace Freedom.Frontend.Models.BaseBindableInterface
{
    public interface IPayOffCalculator
    {
        /// <summary>
        /// Monto inicial del prestamo
        /// </summary>
        decimal LoanAmount { get; set; }

        /// <summary>
        /// Valor de la entrega
        /// </summary>
        decimal AmountDelivery { get; set; }

        /// <summary>
        /// Saldo a Financiar
        /// </summary>
        decimal BalanceOwed { get; }

        /// <summary>
        /// Tipo de Plazo (15,30,60 dias)
        /// </summary>
        int TermType { get; set; }

        /// <summary>
        /// Cantidad de Cuotas
        /// </summary>
        int FeesCount { get; set; }

        DateTime StartDate { get; set; }

        string MoneyName { get; set; }

        string MoneySymbol { get; set; }

        string CompanyName { get; set; }

        string ShopName { get; set; }

        string ShopAddress { get; set; }

        string ShopPhone { get; set; }

        string UserName { get; set; }

        string BoxName { get; set; }

        string BusinessName { get; set; }

        int OperationTypeId { get; set; }

        string OperationTypeName { get; set; }

    }
}