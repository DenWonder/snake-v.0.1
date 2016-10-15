using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);

            HorizontalLine upLine = new HorizontalLine(0,78,0,'*');
            upLine.drow();
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '*');
            DownLine.drow();

            VerticalLine LeftLine = new VerticalLine( 0, 24, 0, '*');
            LeftLine.drow();
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '*');
            RightLine.drow();
            point p = new point(4,5,'0');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.drow();

            Console.ReadLine();
        }
    }
}
