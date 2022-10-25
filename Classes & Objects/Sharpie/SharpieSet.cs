using System;
using System.Collections.Generic;

namespace Sharpie
{
    public class SharpieSet
    {
        public List<Sharpie> listOfSharpies = new List<Sharpie>() { };
        public List<Sharpie> removedSharpies = new List<Sharpie>() { };


        public SharpieSet()
        {
        }

        public void AddSharpie(Sharpie newSharpie)
        {
            listOfSharpies.Add(newSharpie);
        }


        public int CountUsable()
        {
            int UseableSharpie = 0;

            foreach (var item in listOfSharpies)
            {
                if (item.ReturnInk() > 0)
                {
                    UseableSharpie++;
                }
            }
            return UseableSharpie;
        }


        public void RemoveSharpies()
        {
            foreach (var item in listOfSharpies)
            {
                if (item.ReturnInk() > 0)
                {
                    removedSharpies.Add(item);
                }
            }


        }
    }
}

