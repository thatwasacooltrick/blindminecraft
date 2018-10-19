using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindMinecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            int newPosition;
            string input = "";
            character me = new character();
            while (true) {
                input = Console.ReadLine();
                switch (input) {
                    case "w":
                    case "W":
                        newPosition = me.gety() + 1;
                        me.sety(newPosition);
                        break;
                    case "a":
                    case "A":
                        newPosition = me.getx() - 1;
                        me.setx(newPosition);
                        break;
                    case "s":
                    case "S":
                        newPosition = me.gety() - 1;
                        me.sety(newPosition);
                        break;
                    case "d":
                    case "D":
                        newPosition = me.getx() + 1;
                        me.setx(newPosition);
                        break;
                    case "locate":
                        Console.WriteLine("("+me.getx()+", "+me.gety()+")");
                        break;
                }

            }
        }
    }
    class character
    {
        int x = 0;
        int y = 0;
        public int getx(){
            return this.x;
        }
        public int gety()
        {
            return this.y;
        }
        public void setx(int varyable){
            this.x = varyable;
        }
        public void sety(int varyable)
        {
            this.y = varyable;
        }
    }


}
