﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DAL
{
    public class NotesContext : System.Data.Entity.DbContext
    {
        public NotesContext() : base("DefaultConnection")
        {}

        public System.Data.Entity.DbSet<WebApplication1.Models.Note> Notes { get; set; }
    }
}