using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    internal interface IManageRecipe
    {
        public bool CreateRecipe(string ingredients, string owner, string description, Image image, string name);
        public bool UpdateRecipe(Recipe recipe);
        public bool DeleteRecipe(Recipe recipe);
    }
}
