using Freedom.Utility.Interfaces;
using Freedom.Utility.Models.AllPurpose;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Freedom.Utility.Implements
{
    public class EnumExtension : IEnumExtension
    {
        public List<EnumItem> GetEnumAttibuteToList(Type Tpy)
        {
            List<EnumItem> lst = new List<EnumItem>();
            if (!Tpy.IsEnum)
            {
                throw new ArgumentException("Only Enum Types can be set");
            }
            foreach (int i in Enum.GetValues(Tpy))
            {
                string name = Enum.GetName(Tpy, i);
                string desc = name;
                FieldInfo fi = Tpy.GetField(name);

                DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
                if (attributes.Length > 0)
                {
                    string s = attributes[0].Description;
                    if (!string.IsNullOrEmpty(s))
                    {
                        desc = s;
                    }
                }
                lst.Add(new EnumItem
                {
                    Id = i,
                    EnumName = name,
                    AttributeDescription = desc
                });
            }
            return lst;
        }
    }
}