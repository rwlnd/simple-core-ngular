using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace simple_core_ngular.Pages
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "RazorPages meets Angular meets Dotnet Core 2.0.0 meets Docker";
        }


    }
}
