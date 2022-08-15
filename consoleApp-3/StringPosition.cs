using System;

namespace consoleApp_3
{
    public class StringPosition
    {

        public string Name { get; set; }

        public int PosStartX { get; set; }

        public int PosEndX { get; set; }

        public int PosY { get; set; }


        public override string ToString()
        {
            return Name + "\t" + PosStartX + "\t" + PosEndX + "\t" + PosY; 
        }

    }

    
}

