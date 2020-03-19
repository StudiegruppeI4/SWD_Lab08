using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Telephone_Exercise_State_pattern
{
    class Calling : TelephoneState
    {
        public override void OnEnter(Telephone phone)
        {
            Console.WriteLine("Now entering state Calling");
            phone.CallNumber();
            phone.MicOn = true;
            phone.Connection = true;
            this.OnExit(phone);
        }

        public override void OnExit(Telephone phone)
        {
            Console.WriteLine("Now exiting state Calling");
            phone.SetState(new Connected());
        }


    }
}
