using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v._0._1
{
    class FoodCreator
    {
        int MapWidth;
        int MapHeight;
        char sym;

        Random random = new Random();
        public FoodCreator(int MapWidth, int MapHeight, char sym)
        {
            this.MapWidth = MapWidth;
            this.MapHeight = MapHeight;
            this.sym = sym;
        }

        public point CreateFood()
        {
            int x = random.Next(2, MapWidth - 2);
            int y = random.Next(2, MapHeight - 2);
            return new point(x, y, sym);
        }
    }

}
