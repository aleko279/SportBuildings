﻿using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class WebpagesRoles
    {
        public WebpagesRoles()
        {
            WebpagesUsersInRoles = new HashSet<WebpagesUsersInRoles>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }
    }
}
