namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IProductImage
    {
        int Id { get; set; }

        /// <summary>
        /// product Id
        /// </summary>
        int ProductId { get; set; }


        int CompanyId { get; set; }

        /// <summary>
        /// index in collection ex: photo1, photo2
        /// </summary>
        int PhotoIndex { get; set; }

        /// <summary>
        ///cloud storage object identification
        /// </summary>
        Guid PhotoId { get; set; }

        /// <summary>
        /// photo Object
        /// </summary>
        public byte[] PhotoObject { get; set; }
    }
}