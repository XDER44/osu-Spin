using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace osu_Spin
{
    class Program 
    {
        private const int SPIN_TIME = 20;


        private static void Change(int X, int Y) {
            Cursor.Position = new System.Drawing.Point(X,Y);
            Thread.Sleep(SPIN_TIME);
        }


        static void Main(string[] args) { 
            Console.WriteLine("Spin the circles!");
            while (true) {
                //Console.WriteLine(Cursor.Position.ToString());
                Change(796,416);
                Change(812,746);
                Change(1163,724);
                Change(1154,393);
                Change(950,347);
            }
            
        }
    }
}
