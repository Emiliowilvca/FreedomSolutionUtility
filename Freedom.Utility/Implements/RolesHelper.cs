using Freedom.Utility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Freedom.Utility.Implements
{
    public class RolesHelper : IRolesHelper
    {
        public Role ResolveRoles(IList<string> rolesCollection)
        {
            // List<string> rolesColecction = typeof(Role).GetProperties().Select(p => p.Name).ToList();
            Role role = new Role();
            IEnumerable<PropertyInfo> namesCollection = typeof(Role).GetProperties();
            foreach (PropertyInfo property in namesCollection.Where(x => x.PropertyType == typeof(bool)))
            {
                Type type = role.GetType();
                PropertyInfo pInfo = type.GetProperty(property.Name);
                bool value = rolesCollection.Contains(property.Name);
                pInfo.SetValue(role, value);
            }
            return role;
        }

        public IList<string> RolesToList(Role role)
        {

            return role.GetType().GetProperties().Select(p => p.Name).ToList();

            //return typeof(Role).GetProperties().Select(p => p.Name).ToList();
        }
    }
}