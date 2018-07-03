using System;
using System.Collections.Generic;
using System.Text;

namespace BPJ.Library.Interface
{
    public interface IPizza
    {
        //dont worry about name:each pizza model will have its own pizza name(type)
        Dictionary<string, int> ExtraIngredients();
        


    }
}
