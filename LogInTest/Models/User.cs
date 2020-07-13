﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInTest.Models

{
   public class User
   {
      public string Email { get; set; }  

      public string FullName { get; set; }

      public string Password { get; set; }


   }
}