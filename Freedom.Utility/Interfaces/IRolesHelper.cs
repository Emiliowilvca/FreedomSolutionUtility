using System.Collections.Generic;

namespace Freedom.Utility.Interfaces
{
    public interface IRolesHelper
    {
        Role ResolveRoles(IList<string> rolesCollection);
    }
}