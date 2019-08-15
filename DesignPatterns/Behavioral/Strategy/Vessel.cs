using DesignPatterns.Behavioral.Strategy.Movers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Vessel
    {
        private IMovingStrategy _movingStrategy;

        private string _context;

        public int SpeedOfVessel { get; set; }

        public Vessel(string contx)
        {
            SpeedOfVessel = 0;
            _context = contx;
            ChangeContext(contx);
        }

        public void ChangeContext(string newContext)
        {
            switch (newContext)
            {
                case "Engine":
                    this._context = newContext;
                    this._movingStrategy = new EngineMover();
                    this._movingStrategy.MoveVessel(this.SpeedOfVessel);
                    break;
                case "Oars":
                    this._context = newContext;
                    this._movingStrategy = new OarsMover();
                    this._movingStrategy.MoveVessel(this.SpeedOfVessel);
                    break;
                case "Sails":
                    this._context = newContext;
                    this._movingStrategy = new SailMover();
                    this._movingStrategy.MoveVessel(this.SpeedOfVessel);
                    break;
            }  
        }
    }
}
