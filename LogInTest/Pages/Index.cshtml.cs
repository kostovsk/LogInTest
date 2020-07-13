using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogInTest.Models;
using LogInTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LogInTest.Pages
{
   public class IndexModel : PageModel
   {
      private readonly ILogger<IndexModel> _logger;

      public List<User> Users {get; private set; }

      UserFactory Get_User = new UserFactory();

      public IndexModel(ILogger<IndexModel> logger)
      {
         _logger = logger;
      }

      public void OnGet()
      {
         Users = Get_User.Get_List_Of_Users_Json();
      }

   }
}
