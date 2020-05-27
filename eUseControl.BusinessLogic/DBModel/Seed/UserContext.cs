﻿using eUseControl.Models.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.DBModel.Seed
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("name=eUseControl")
        {

        }public virtual DbSet<USessionData> Users { get; set; }
    }
}
