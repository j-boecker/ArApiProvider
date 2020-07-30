using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ArApiProvider.Data;
using ArApiProvider.Models;

namespace ArApiProvider.Pages
{
    public class RoomPlansModel : PageModel
    {
        private readonly ArApiProvider.Data.RoomsDbContext _context;

        public RoomPlansModel(ArApiProvider.Data.RoomsDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            RoomPlanList = _context.Set<RoomPlan>().ToList();
            return Page();
        }

        public List<RoomPlan> RoomPlanList { get; set; }
        [BindProperty]
        public RoomPlan RoomPlan { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RoomPlans.Add(RoomPlan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
