using Freedom.Utility.Models.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IPurchaseProductRTO : IProductMin
    {
        int Quantity { get; set; }
    }
}