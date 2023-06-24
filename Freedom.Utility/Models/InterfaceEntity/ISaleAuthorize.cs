namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface ISaleAuthorize : IEntity
    {
        int CompanyID { get; set; }

        int SaleId { get; set; }

        /// <summary>
        /// funcionario autorizante (Empleador - Gerente - Jefe Taller)
        /// </summary>
        int AuthorizingOfficerId { get; set; }

        /// <summary>
        /// persona autorizada para realizar gestiones del cliente (compras- ventas - servicios)
        /// </summary>
        int AuthorizedStaffId { get; set; }
    }
}