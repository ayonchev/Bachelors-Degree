using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ShipCrash.UI.Entities.DefensiveUnits;
using ShipCrash.UI.Entities.Interfaces;
using ShipCrash.UI.Managers;


namespace ShipCrash.UI.Entities.Enemies
{
    public abstract class Enemy : MovableEntity, IAttacker
    {
        public Enemy(List<DefensiveUnit> targets, Uri imageURI) : base(imageURI)
        {
            Targets = targets;
        }

        public static Island MainTarget { get; set; }
        public List<DefensiveUnit> Targets { get; protected set; }

        public int AttackPoints { get; protected set; }

        public void Attack(IHittable hittable)
        {
            this.LifePoints -= hittable.LifePoints;
            hittable.OnHit(this);
        }
        public override void PositionChanged(object sender, EventArgs e)
        {
            var data = sender as TranslateTransform;
            if (data == null) return;

            // TODO : Remove System.Diagnostics namespace
            this.Coordinates = new Point(
                Canvas.GetLeft(this.Control) + data.X,
                Canvas.GetTop(this.Control) + data.Y);
            //Trace.WriteLine(
            //    $"x: {Canvas.GetLeft(this.Control) + data.X}, y: {Canvas.GetTop(this.Control) + data.Y}");
            this.Rect = new Rect(
                Canvas.GetLeft(this.Control) + data.X,
                Canvas.GetTop(this.Control) + data.Y,
                this.Control.ActualWidth,
                this.Control.ActualHeight
            );

            if(MainTarget.Rect.IntersectsWith(this.Rect))
            {
                this.Attack(MainTarget);
                return;
            }

            BaseEntity hitEntity = Targets.FirstOrDefault(t => t.Rect.IntersectsWith(this.Rect));

            if (hitEntity != null)
            {
                this.Attack(hitEntity);
            }
        }

        protected override void Destroy()
        {
            RemoveAnimation();
            base.Destroy();
        }
    }
}
