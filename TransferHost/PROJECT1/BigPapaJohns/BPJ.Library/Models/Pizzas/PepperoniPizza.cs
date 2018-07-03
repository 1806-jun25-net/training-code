using BPJ.Library.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BPJ.Library
{
    public class PepperoniPizza : IPizza
    {

        [XmlAttribute]
        // public string pepperoni;
        // public int SlicesOfPep;
        public Dictionary<string, int> MediumPepperoniDict = new Dictionary<string, int>()
       
        {{ "PepperoniSlices",20},{ "PizzaSauceOz",4},{"Cheese(oz)",4}
        };
        
        public Dictionary<string, int> ExtraIngredients()
        {

            MediumPepperoniDict.Add("PepperoniSlices", 20);
            return MediumPepperoniDict;

        }
    }
}
