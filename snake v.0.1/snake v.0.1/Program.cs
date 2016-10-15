﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake_v._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);
            //Отрисовка границ игрового поля
            HorizontalLine upLine = new HorizontalLine(0,78,0,'*');
            upLine.drow();
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '*');
            DownLine.drow();

            VerticalLine LeftLine = new VerticalLine( 0, 24, 0, '*');
            LeftLine.drow();
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '*');
            RightLine.drow();


            //Отрисовка точек
            point p = new point(4,5,'0'); //Начальное положение и, конечно же, символ отображения
            Snake snake = new Snake(p, 5, Direction.RIGHT); //Длинна и направление
            snake.drow(); //Отрисовка объекта "Змейка"
            snake.Move(); //Реализация движения змейки
            Thread.Sleep(300); //Пауза в отображении для нагляности и пущего реализма.
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Console.ReadLine(); //Команда завершение работы программы после её выполнения.
        }
    }
}
