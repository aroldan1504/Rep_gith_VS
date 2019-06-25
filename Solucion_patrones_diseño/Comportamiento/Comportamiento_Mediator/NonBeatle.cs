using System;


namespace Comportamiento_Mediator
{
    class NonBeatle : Participant

    {
        // Constructor

        public NonBeatle(string name)
          : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("Para un no-Beatle: ");
            base.Receive(from, message);
        }
    }
}
