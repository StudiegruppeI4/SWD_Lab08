using System;

namespace SWD_Telephone_Exercise_State_pattern
{
    class Disconnecting : TelephoneState
    {
        public override void OnEnter(Telephone phone)
        {
            Console.WriteLine("Now entering state Disconnecting");
            phone.Connection = false;
            this.OnExit(phone);
        }

        public override void OnExit(Telephone phone)
        {
            Console.WriteLine("Now exiting state Disconnecting");
            phone.SetState(new Idle());
        }
    }
}