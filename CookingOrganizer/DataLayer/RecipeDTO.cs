using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DataLayer
{
    public class RecipeDTO
    {

        public int Id { get; set; }
        public string ?Ingredients { get; set; }
        public string ?Description { get; set; }
        public string ?Owner { get; set; }
        public Image ?Image { get; set; }
        public byte[] ?ImageInBytes { get; set; }
        public string ?Name { get; set; }


    }
}
