using Freedom.Utility.Models.AllPurpose;
using System;
using System.Collections.Generic;

namespace Freedom.Utility.Interfaces
{
    public interface IEnumExtension
    {
        List<EnumItem> GetEnumAttibuteToList(Type type);
    }
}