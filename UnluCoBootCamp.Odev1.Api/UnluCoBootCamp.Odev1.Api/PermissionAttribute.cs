using System;

namespace UnluCoBootCamp.Odev1.Api
{

    public class PermissionAttribute : Attribute
    {
        public string Permission { get; }

        public PermissionAttribute(string permission)
        {
            Permission = permission;
        }
    }
}
