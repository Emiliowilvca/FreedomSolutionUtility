﻿using Freedom.Utility.Bindable;

namespace Freedom.Utility.Models.EntityDto
{
    public class WithholdingPercentVAT5Dto : BindableBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal PercentValue { get; set; }
    }
}