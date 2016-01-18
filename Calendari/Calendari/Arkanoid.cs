using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calendari
{
    class ArkanoidControl
    {
        public static int STOPGAME = 0, CONTINUE = 1, REDRAW = 2;
        public static Ball b;
        public static double Movement = 5;
        public static bool Thrown = false;
        public static int Score { get; set; }
        public static List<Control> Platforms = new List<Control>();
        private static bool Finish = false;
        public static int seed { get; set; }

        public static void ThrowBall()
        {
            if (!Thrown)
                Thrown = true;
            Finish = false;
        }

        public static void Close()
        {
            Thrown = false;
            Platforms.Clear();
            Finish = true;
        }

        public static void InitBall(Label realBall)
        {
            b = new Ball(0, Calendari.ScreenHeight - realBall.Size.Height, realBall.Size.Width, realBall.Size.Height);
            b.Dir = Direction.TopRight;
        }

        public static int MoveBall(int width, int height, Label realBall, Label platform)
        {
            if (Thrown)
            {
                SetMovement();
                CheckCoords(width, height);
                CheckCollision(width, height);
                PlatformCollide(platform, realBall);
                PlatformsCollision(realBall);
            }
            else
            {
                b.X = platform.Location.X + (platform.Size.Width / 2) - (b.Width / 2);
                b.Y = platform.Location.Y - platform.Size.Height;
            }

            SetSpeed();
            realBall.Location = new Point((int)b.X, (int)b.Y);
            if (!Finish)
            {
                if (Platforms.Count == 0 && Thrown)
                {
                    return REDRAW;
                }
                else
                {
                    return CONTINUE;
                }
            }
            else
            {
                return STOPGAME;
            }
        }

        private static void SetSpeed()
        {
            Movement = 5 + (Score / 30);
            Movement = Math.Min(Movement, 13);
        }

        private static void SetMovement()
        {
            switch (b.Dir)
            {
                case Direction.BotLeft:
                    b.X -= Movement;
                    b.Y += Movement;
                    break;
                case Direction.BotRight:
                    b.X += Movement;
                    b.Y += Movement;
                    break;
                case Direction.TopLeft:
                    b.X -= Movement;
                    b.Y -= Movement;
                    break;
                case Direction.TopRight:
                    b.X += Movement;
                    b.Y -= Movement;
                    break;
            }
        }

        private static void CheckCoords(int width, int height)
        {
            if (b.X < 0)
            {
                b.X = 0;
            }
            if (b.X + b.Width > width)
            {
                b.X = width - b.Width;
            }
            if (b.Y < 0)
            {
                b.Y = 0;
            }
            if (b.Y + b.Height > height)
            {
                b.Y = height - b.Height;
            }
        }

        private static void End()
        {
            Thrown = false;
            Finish = true;
            int[] scores = Parser.GetScores();
            for (int i = 0; i < scores.Length; i++)
            {
                if (Score > scores[i])
                {
                    for (int j = scores.Length - 1; j > i; j--)
                    {
                        scores[j] = scores[j - 1];
                    }
                    scores[i] = Score;
                    break;
                }
            }
            foreach(int i in scores)
            {
                Console.WriteLine(i);
            }
            Parser.SetScores(scores);
        }

        private static void CheckCollision(int width, int height)
        {
            switch(b.Dir)
            {
                case Direction.BotLeft:
                    if (b.X - Movement <= 0)
                        b.Dir = Direction.BotRight;
                    else if (b.Y + Movement + b.Height > height)
                    {
                        b.Dir = Direction.TopRight;
                        End();
                    }                    
                    break;
                case Direction.BotRight:
                    if (b.X + Movement + b.Width >= width)
                        b.Dir = Direction.BotLeft;
                    else if (b.Y + Movement + b.Height > height)
                    {
                        b.Dir = Direction.TopRight;
                        End();
                    }
                    break;
                case Direction.TopLeft:
                    if (b.X - Movement <= 0)
                        b.Dir = Direction.TopRight;
                    else if (b.Y - Movement <= 0)
                        b.Dir = Direction.BotLeft;
                    break;
                case Direction.TopRight:
                    if (b.X + Movement + b.Width >= width)
                        b.Dir = Direction.TopLeft;
                    else if (b.Y - Movement <= 0)
                        b.Dir = Direction.BotRight;
                    break;
            }
        }

        private static void PlatformCollide(Label platform, Label ball)
        {           
            Bounds ballBounds = new Bounds { X = (int)b.X, Y = (int)b.Y, W = b.Width, H = b.Height };
            Bounds platformBounds = new Bounds { X = platform.Location.X, Y = platform.Location.Y, W = platform.Width, H = platform.Height };
            if (!InBounds(platform, ball))
            {
                return;
            }
            Direction dir = b.Dir;
            switch(WhereIsBallRespectPlatform(ballBounds, platformBounds, platform, ball))
            {
                case Where.Far:
                case Where.Outside:
                case Where.Near:
                    return;
                case Where.Top:
                    DirectionMethods.Topimize(ref dir);
                    break;
                case Where.Bot:
                    DirectionMethods.Bottomize(ref dir);
                    break;
                case Where.Left:
                    DirectionMethods.Leftimize(ref dir);
                    break;
                case Where.Right:
                    DirectionMethods.Rightimize(ref dir);
                    break;
            }
            b.Dir = dir;
        }

        private static void PlatformsCollision(Label ball)
        {
            foreach (Control platform in Platforms)
            {
                Bounds ballBounds = new Bounds { X = (int)b.X, Y = (int)b.Y, W = b.Width, H = b.Height };
                Bounds platformBounds = new Bounds { X = platform.Location.X, Y = platform.Location.Y, W = platform.Width, H = platform.Height };
                if (!InBounds(platform, ball))
                {
                    continue;
                }
                Direction dir = b.Dir;
                switch (WhereIsBallRespectPlatform(ballBounds, platformBounds, platform, ball))
                {
                    case Where.Far:
                    case Where.Outside:
                    case Where.Near:
                        return;
                    case Where.Top:
                        DirectionMethods.Topimize(ref dir);
                        platform.Visible = false;
                        Score += 15;
                        break;
                    case Where.Bot:
                        DirectionMethods.Bottomize(ref dir);
                        platform.Visible = false;
                        Score += 15;
                        break;
                    case Where.Left:
                        DirectionMethods.Leftimize(ref dir);
                        platform.Visible = false;
                        Score += 15;
                        break;
                    case Where.Right:
                        DirectionMethods.Rightimize(ref dir);
                        platform.Visible = false;
                        Score += 15;
                        break;
                }
                b.Dir = dir;
                if (!platform.Visible)
                {
                    Platforms.Remove(platform);
                    return;
                }
            }
        }

        private static bool InBounds(Control platform, Label ball)
        {            
            return platform.Bounds.IntersectsWith(ball.Bounds);
        }

        private static Where WhereIsBallRespectPlatform(Bounds obj1, Bounds obj2, Control platform, Label ball)
        {
            if (!InBounds(platform, ball))
            {
                return Where.Far & Where.Outside;
            }

            if (obj1.Y < obj2.Y && obj1.Y + obj1.H < obj2.Y + obj2.H)
            {
                return Where.Top;
            }

            if (obj1.Y > obj2.Y && obj1.Y + obj1.H > obj2.Y + obj2.H)
            {
                return Where.Bot;
            }

            if (obj1.X > obj2.X && obj1.X + obj1.W > obj2.X + obj2.W)
            {
                return Where.Right;
            }

            if (obj1.X < obj2.X && obj1.X + obj1.W < obj2.X + obj2.W)
            {
                return Where.Left;
            }            

            return Where.Near;
        }
    }

    public class Ball
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Direction Dir { get; set; }

        public Ball(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Dir = Direction.TopRight;
        }
    }

    public enum Direction
    {
        TopLeft, TopRight, BotLeft, BotRight        
    }

    public static class DirectionMethods
    {
        public static void Bottomize(ref Direction dir)
        {
            if (dir == Direction.TopLeft)
            {
                dir = Direction.BotLeft;
            }
            else if (dir == Direction.TopRight)
            {
                dir = Direction.BotRight;
            }
        }

        public static void Topimize(ref Direction dir)
        {
            if (dir == Direction.BotLeft)
            {
                dir = Direction.TopLeft;
            }
            else if (dir == Direction.BotRight)
            {
                dir = Direction.TopRight;
            }
        }

        public static void Leftimize(ref Direction dir)
        {
            if (dir == Direction.BotRight)
            {
                dir = Direction.BotLeft;
            }
            else if (dir == Direction.TopRight)
            {
                dir = Direction.TopLeft;
            }
        }

        public static void Rightimize(ref Direction dir)
        {
            if (dir == Direction.BotLeft)
            {
                dir = Direction.BotRight;
            }
            else if (dir == Direction.TopLeft)
            {
                dir = Direction.TopRight;
            }
        }
    }
    public struct Bounds
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }
    }

    public enum Where
    {
        Top, Bot, Right, Left, Inside, Outside, Far, Near
    }

    public class Planet
    {
        private static Color[] MERCURY = { Color.FromArgb(126, 119, 110), Color.FromArgb(155, 110, 79) };
        private static Color[] VENUS = { Color.FromArgb(220, 202, 158), Color.FromArgb(171, 137, 79) };
        private static Color[] EARTH = { Color.FromArgb(24, 49, 112), Color.FromArgb(50, 108, 40) };
        private static Color[] MARTH = { Color.FromArgb(52, 30, 24), Color.FromArgb(195, 105, 56) };
        private static Color[] JUPITER = { Color.FromArgb(136, 77, 40), Color.FromArgb(174, 184, 189) };
        private static Color[] SATURN = { Color.FromArgb(209, 181, 128), Color.FromArgb(160, 133, 73) };
        private static Color[] URANUS = { Color.FromArgb(63, 111, 107), Color.FromArgb(150, 200, 194) };
        private static Color[] NEPTUN = { Color.FromArgb(55, 79, 129), Color.FromArgb(170, 200, 229) };
        private static Color[] PLUTON = { Color.FromArgb(246, 198, 161), Color.FromArgb(49, 26, 15) };
        private static Color[] DEATHSTAR = { Color.FromArgb(137, 156, 147), Color.FromArgb(255, 255, 255) };

        public static Color[] GetColor(int planet)
        {
            switch(planet)
            {
                case 1:
                    return MERCURY;
                case 2:
                    return VENUS;
                case 3:
                    return EARTH;
                case 4:
                    return MARTH;
                case 5:
                    return JUPITER;
                case 6:
                    return SATURN;
                case 7:
                    return URANUS;
                case 8:
                    return NEPTUN;
                case 9:
                    return PLUTON;
                case 10:
                    return DEATHSTAR;
                default:
                    return null;
            }
        }
    }
}
