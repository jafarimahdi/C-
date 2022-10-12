using System;


namespace FleetOfThings
{
    public class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }


        public string giveName()
        {
            return this.Name;
        }


        public void Complete()
        {
            this.Completed = true;
        }


        public bool isCompleted()
        {
            return this.Completed;
        }
    }
}

