using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility
{
    public class Role : IRoles
    {
        public bool SuperUser { get; set; }

        public bool Admin { get; set; }

        public bool PowerUser { get; set; }

        public bool Operator { get; set; }

        public bool Seller { get; set; }

        public bool Finance { get; set; }

        public bool Customer { get; set; }

        public bool Provider { get; set; }

        public bool Investor { get; set; }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}