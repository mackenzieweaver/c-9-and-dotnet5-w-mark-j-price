using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel
    {
        public List<string> Suppliers { get; set; }
        public List<string> Countries { get; set; }
        public List<string> Phones { get; set; }

        private Northwind db;

        public SuppliersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Suppliers";
            Suppliers = db.Suppliers.Select(s => s.CompanyName).ToList();
            Countries = db.Suppliers.Select(s => s.Country).ToList();
            Phones = db.Suppliers.Select(s => s.Phone).ToList();
        }

        [BindProperty]
        public Supplier Supplier { get; set; }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            return Page();
        }
    }
}
