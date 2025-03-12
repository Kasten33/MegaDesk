using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        public enum DeskMaterial
        {
            Pine,
            Laminate,
            Veneer,
            Oak,
            Rosewood
        }

        private int _width;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 96 && value >= 24)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Invalid width value");
                }
            }
        }

        private int _depth;
        public int Depth
        {
            get
            {
                return _depth;
            }
            set
            {
                if (value <= 48 && value >= 12)
                {
                    _depth = value;
                }
                else
                {
                    throw new Exception("Invalid depth value.");
                }
            }
        }

        private int _drawerNumber;

        public int DrawerNumber
        {
            get
            {
                return _drawerNumber;
            }
            set
            {
                if (value <= 7 && value >= 0)
                {
                    _drawerNumber = value;
                }
                else
                {
                    throw new Exception("Invalid Drawer Amount.");
                }
            }
        }

        private int _shippingDays;

        public int ShippingDays
        {
            get
            {
                return _shippingDays;
            }
            set
            {
                if (value == 3 || value == 5 || value == 7)
                {
                    _shippingDays = value;
                }
                else
                {
                    throw new Exception("Invalid Shipping Amount.");
                }
            }
        }

        public string Material { get; set; }

        // public constructor
        public Desk() { }

        public Desk(int width, int depth, int drawerNumber, string material, int shippingDays)
        {
            this.Width = width;
            this.Depth = depth;
            this.DrawerNumber = drawerNumber;
            this.Material = material;
            this.ShippingDays = shippingDays;
        }

        public int getSurfaceArea()
        {
            return Width * Depth;
        }
    }
}