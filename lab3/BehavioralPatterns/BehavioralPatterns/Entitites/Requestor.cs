using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralPatterns.St;

namespace BehavioralPatterns.Entitites
{
    class Requestor
    {
        private IState _state;

        public string Name { get; set; }
        public int Priority { get; set; }
        public string TypeOfFlight { get; set; }
        public Group Group { get; set; }

        public Requestor()
        {
            this._state = new PendingState();
        }

        public void Call()
        {
            _state.Proceed(this);
        }

        public IState State
        {
            get { return _state; }
            set { _state = value; }
        }

    }
}
