using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Telephone_Exercise_State_pattern
{
    class MutedState : MicrophoneState
    {
        public override void middleman(Telephone phone)
        {
            phone.SetStateMicrphone(new UnMutedState());
        }

        public override void OnEnter(Telephone phone)
        {
            Console.WriteLine("Phone is now muted");
            phone.MicOn = false;
        }

    }
}
