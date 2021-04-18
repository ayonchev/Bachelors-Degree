using ShipCrash.UI.Entities.Enemies;
using ShipCrash.UI.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ShipCrash.UI.Entities.DefensiveUnits.Bullets
{
    public abstract class Bullet : MovableEntity, IAttacker
    {
        private const int DEFAULT_ATTACK_POINTS = 5;
        private const double DEFAULT_DURATION = 1200;
        private const int DEFAULT_WIDTH = 20;

        public event EventHandler<Enemy> MovementCompleted;

        public Bullet(Enemy target, Uri imageURI, int width = DEFAULT_WIDTH)
            : base(imageURI, width)
        {
            Target = target;
            AttackPoints = DEFAULT_ATTACK_POINTS;
            Duration = TimeSpan.FromSeconds(DEFAULT_DURATION);
            MovementAnimation.Completed += OnReachedTarget;
        }

        private void OnReachedTarget(object sender, EventArgs e)
        {
            MovementCompleted.Invoke(this, null);
            RemoveAnimation();
        }

        public Enemy Target { get; protected set; }

        public int AttackPoints { get; protected set; }

        // TODO : think of a way for providing base implementation of the attack method
        public void Attack(IHittable hittable)
        {
            this.LifePoints -= hittable.LifePoints;
            hittable.OnHit(this);
        }

        public override void PositionChanged(object sender, EventArgs e)
        {
            var data = sender as TranslateTransform;
            if (data == null) return;

            this.Rect = new Rect(
                Canvas.GetLeft(this.Control) + data.X,
                Canvas.GetTop(this.Control) + data.Y,
                this.Control.ActualWidth,
                this.Control.ActualHeight
            );

            if (Target.Rect.IntersectsWith(this.Rect))
            {
                this.Attack(Target);
                if(MovementCompleted != null)
                    MovementCompleted.Invoke(this, Target);
                RemoveAnimation();
            }
        }

        public override void RemoveAnimation()
        {
            if(MovementAnimation != null)
                MovementAnimation.Completed -= OnReachedTarget;
            MovementCompleted = null;
            base.RemoveAnimation();
            base.Destroy();
        }
    }
}
