using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArApiProvider.Models
{
    public class WallBlock
    {
        [Key]
        public int Id { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Rotation { get; set; }
    }
}
