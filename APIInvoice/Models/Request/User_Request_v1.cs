﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIInvoice.Models.Request
{
    public class User_Request_v1
    {
        public string Username { get; set; }
        public string Password { get; set; }

        //Conventions
        public int UserTypeID { get; set; }
    }
}