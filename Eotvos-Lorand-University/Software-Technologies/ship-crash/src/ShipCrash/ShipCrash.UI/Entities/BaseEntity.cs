using ShipCrash.UI.Entities.Interfaces;
using ShipCrash.UI.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ShipCrash.UI.Entities
{
    public abstract class BaseEntity : IHittable
    {
        private const int DEFAULT_CONTROL_WIDTH = 50;
        private int lifePoints = 0;
        private Rect rectangle;
        public static Action<BaseEntity, Point> EntityAdded { get; set; }
        public static Action<BaseEntity> EntityDestroyed { get; set; }
        public Uri ImageURI { get; protected set; }
        public int Width { get; protected set; }
        public Image Control { get; protected set; }
        public Point Coordinates { get; protected set; }

        public Rect Rect
        {
            get
            {
                if(rectangle.Width == 0 && rectangle.Height == 0)
                {
                    rectangle = new Rect(
                        Coordinates.X, 
                        Coordinates.Y, 
                        Control.Source.Width, Control.Source.Height
                    );
                }
                return rectangle;
            }
            protected set
            {
                this.rectangle = value;
            }
        }

        public int LifePoints 
        {
            get => this.lifePoints;
            protected set
            {
                this.lifePoints = value;
                if (lifePoints <= 0)
                    Destroy();
            } 
        }

        // TODO: replace the subscriber instance with the delegate pointing to the event handler
        protected BaseEntity(Uri imageURI, int width = DEFAULT_CONTROL_WIDTH)
        {
            ImageURI = imageURI;
            Width = width;
            CreateControl();
        }

        protected virtual void Destroy()
        {
            EntityDestroyed(this);
            //EntityAdded = null;
            //EntityDestroyed = null;
        }
        public void SetCoordinates(Point coordinates)
        {
            Coordinates = coordinates;
            EntityAdded(this, coordinates);
        }
        public virtual void OnHit(IAttacker attacker)
        {
            LifePoints -= attacker.AttackPoints;
        }
        private void CreateControl()
        {
            Control = new Image();
            Control.Width = Width;

            BitmapImage btmImg = new BitmapImage();
            btmImg.BeginInit();
            btmImg.UriSource = ImageURI;
            
            btmImg.DecodePixelWidth = Width;
            btmImg.EndInit();
            Control.Source = btmImg;
        }
    }
}
