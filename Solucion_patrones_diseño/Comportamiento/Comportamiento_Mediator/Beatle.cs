using System;


namespace Comportamiento_Mediator
{
    class Beatle : Participant

    {
        // Constructor

        public Beatle(string name)
          : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("Para un Beatle: ");
            base.Receive(from, message);
        }
    }
}
