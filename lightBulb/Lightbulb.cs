using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightBulb
{
    public class Lightbulb
    {
        private bool state;
        private int position;
        public bool State
        {
            get { return state; }
            set { state = value; }
        }
        public void Toggle()
        {
            State = !State;
        }
        public int Position
        {
            get { return position; }
            set { position = value; }
        }
        public void PosUp()
        {
            position -= 27;
        }
        public void PosDown()
        {
            position += 27;
        }
    }
}
