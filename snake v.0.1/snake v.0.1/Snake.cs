using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_v._0._1
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(point tail, int length, Direction _direction)
       {
            direction = _direction;
            pList = new List<point>();
            for (int i = 0; i < length; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
       }
        internal void Move() //Метод движения змейки
        {
            point tail = pList.First();  
            pList.Remove(tail);//Удаляем хвост
            point head = GetNextPoint();
            pList.Add(head); //Создаем голову

            tail.Clear();
            head.Draw();
        }
        public point GetNextPoint()  //Метод нахождения места положения головы змейки
        {
            point head = pList.Last();
            point nextPoint = new point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;

        }
    }
}
