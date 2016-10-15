using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v._0._1
{
    class Figure
    {
 protected List<point> pList;
        public void drow()
        {
            foreach (point p in pList)
            {
                p.Draw();
            }
        }
    }
}
