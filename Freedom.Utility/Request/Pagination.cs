namespace Freedom.Utility.Request
{
     
    public class Pagination
    {
        /// <summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining elements.
        /// Omite un número específico de elementos en una secuencia y luego devuelve los elementos restantes.
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        /// Devuelve un número especificado de elementos contiguos desde el inicio de una secuencia.
        /// </summary>
        public int ItemsPerPage { get; set; } = 20;

        /// <summary>
        /// Select a Current Company
        /// </summary>
        public int CompanyId { get; set; } = 1;

        public string SearchText { get; set; }

        public int SearchId { get; set; }
    }
}