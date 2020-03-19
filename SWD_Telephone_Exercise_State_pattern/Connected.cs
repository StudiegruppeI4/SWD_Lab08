using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Telephone_Exercise_State_pattern
{
    class Connected : TelephoneState
    {
        public override void OnEnter(Telephone phone)
        {
            Console.WriteLine($"Now entering state connected. Phone connection state is {phone.Connection}");
        }

        public override void OnExit(Telephone phone)
        {
            Console.WriteLine("Now exiting state Calling");
        }

        public override void HandleCallBtnPressed(Telephone phone)
        {
            phone.MicOn = false;
            phone.SetState(new Disconnecting());
        }

    }
}
