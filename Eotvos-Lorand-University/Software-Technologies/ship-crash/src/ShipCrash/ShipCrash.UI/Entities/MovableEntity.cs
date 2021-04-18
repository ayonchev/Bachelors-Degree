using ShipCrash.UI.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ShipCrash.UI.Entities
{
    public abstract class MovableEntity : BaseEntity, IMovable
    {
        public MovableEntity(Uri imageURI, int width = 50) : base(imageURI, width)
        {
            MovementAnimation = new Storyboard();
        }

        public Storyboard MovementAnimation { get; protected set; }

        public TimeSpan Duration { get; protected set; }

        public abstract void PositionChanged(object sender, EventArgs e);

        public void Start(Point targetCoordinates)
        {
            this.Start(targetCoordinates, Duration);
        }
        public void Start(Point targetCoordinates, TimeSpan duration)
        {
            TransformGroup group = new TransformGroup();
            TranslateTransform translate = new TranslateTransform();
            // TODO : Fix the physics of the game.
            this.Control.RenderTransformOrigin = new Point(0.5, 0.5);
            this.Control.RenderTransform = group;
            group.Children.Add(translate);
            this.Control.RenderTransform.Changed += PositionChanged;
            // TODO : Create event handler for the completed event.
            //MovementAnimation.Completed += PositionChanged;

            DoubleAnimation xAnimation = new DoubleAnimation
            {
                To = targetCoordinates.X - Canvas.GetLeft(this.Control),
                Duration = duration
            };
            DoubleAnimation yAnimation = new DoubleAnimation
            {
                To = targetCoordinates.Y - Canvas.GetTop(this.Control),
                Duration = duration
            };

            Storyboard.SetTarget(xAnimation, this.Control);
            Storyboard.SetTarget(yAnimation, this.Control);
            Storyboard.SetTargetProperty(xAnimation, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(TranslateTransform.X)"));
            Storyboard.SetTargetProperty(yAnimation, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(TranslateTransform.Y)"));

            MovementAnimation.Children.Add(xAnimation);
            MovementAnimation.Children.Add(yAnimation);
            MovementAnimation.Begin();
        }

        public void Pause()
        {
            MovementAnimation.Pause();
        }

        public void Resume()
        {
            MovementAnimation.Resume();
        }

        public virtual void RemoveAnimation()
        {
            MovementAnimation?.Remove();
            MovementAnimation = null;
            Control.RenderTransform.Changed -= PositionChanged;
        }
    }
}
