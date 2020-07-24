using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArApiProvider.Models
{
    public class RoomPlan
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Creator { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<WallBlock> WallBlocks { get; set; }
    }
}
