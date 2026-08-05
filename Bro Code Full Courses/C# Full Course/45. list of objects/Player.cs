using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45._list_of_objects
{
    public class Player
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
