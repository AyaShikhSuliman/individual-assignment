using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RecipeSuggestionDTO
    {
        public int Id { get; set; }
        public string? Ingredients { get; set; }
        public string? Description { get; set; }
        public string? Owner { get; set; }
        public string? Name { get; set; }

    }
}
