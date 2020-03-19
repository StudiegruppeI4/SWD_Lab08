using System;

namespace SWD_Telephone_Exercise_State_pattern
{
    class UnMutedState : MicrophoneState
    {
        public override void middleman(Telephone phone)
        {
            phone.SetStateMicrphone(new MutedState());
        }

        public override void OnEnter(Telephone phone)
        {
            Console.WriteLine("Phone is now unmuted");
            phone.MicOn = true;
        }
    }
}