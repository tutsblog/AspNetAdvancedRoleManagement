﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AspNetRoleCustomization.Models
{
    public class Group
    {
        public Group()
        {
            this.Roles = new HashSet<ApplicationRoleGroup>();
        }


        public Group(string name) : this()
        {
            this.Name = name;
        }


        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }
        public virtual HashSet<ApplicationRoleGroup> Roles { get; set; }
    }
}