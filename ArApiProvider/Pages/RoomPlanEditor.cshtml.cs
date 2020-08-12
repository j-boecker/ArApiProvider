using System;
using System.Collections.Generic;
using System.Linq;

using ArApiProvider.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ArApiProvider.Pages
{
    public class RoomPlanEditorModel : PageModel
    {

        private readonly Data.RoomsDbContext _context;

        public RoomPlanEditorModel(Data.RoomsDbContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public int RoomId { get; set; }
        public RoomPlan RoomPlan { get; set; }
        public List<WallBlock> WallBlockList { get; set; }
        public void OnGet()
        {
            RoomPlan = _context.Set<RoomPlan>().Include(x=> x.WallBlocks).FirstOrDefault(x => x.Id == RoomId);
            if (RoomPlan?.WallBlocks != null)
            {
                WallBlockList = new List<WallBlock>(RoomPlan.WallBlocks.ToList());
            }
            else
            {
                WallBlockList = new List<WallBlock>();
            }
        }
    }
}