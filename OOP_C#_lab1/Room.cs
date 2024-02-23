using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__lab1
{
    internal class Room
    {
        private double width;
        private double length;
        private double ceilingHeight;
        private int numberOfWindows;
        private static int totalRoomsCreated;

        public Room()
        {
            width = 0;
            length = 0;
            ceilingHeight = 0;
            numberOfWindows = 0;
            totalRoomsCreated++;
        }

        public Room(double width, double length, double ceilingHeight, int numberOfWindows)
        {
            if (width <= 0 || length <= 0 || ceilingHeight <= 0 || numberOfWindows < 0)
            {
                throw new ArgumentException("Недопустимі значення полів.");
            }

            this.width = width;
            this.length = length;
            this.ceilingHeight = ceilingHeight;
            this.numberOfWindows = numberOfWindows;
            totalRoomsCreated++;
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Недопустиме значення ширини.");
                }
                width = value;
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Недопустиме значення довжини.");
                }
                length = value;
            }
        }

        public double CeilingHeight
        {
            get { return ceilingHeight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Недопустиме значення висоти стелі.");
                }
                ceilingHeight = value;
            }
        }

        public int NumberOfWindows
        {
            get { return numberOfWindows; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Недопустиме значення кількості вікон.");
                }
                numberOfWindows = value;
            }
        }

        public static int TotalRoomsCreated
        {
            get { return totalRoomsCreated; }
        }

        public double CalculateArea()
        {
            return width * length;
        }

        public double CalculateVolume()
        {
            return CalculateArea() * ceilingHeight;
        }

        public string GetState()
        {
            return $"Ширина: {width} м, Довжина: {length} м, Висота стелі: {ceilingHeight} м, Кількість вікон: {numberOfWindows}";
        }
    }
}
