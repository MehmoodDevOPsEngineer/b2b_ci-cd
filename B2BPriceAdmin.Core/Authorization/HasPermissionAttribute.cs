﻿using Microsoft.AspNetCore.Authorization;

namespace B2BPriceAdmin.Core.Authorization
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false)]
    public class HasPermissionAttribute : AuthorizeAttribute
    {
        public HasPermissionAttribute(Permissions permission)
           : base(permission.ToString()) { }
    }
}
