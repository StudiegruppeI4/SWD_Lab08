using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Telephone_Exercise_State_pattern
{
    abstract class TelephoneState
    {
        public abstract void OnEnter(Telephone phone);

        public abstract void OnExit(Telephone phone);

        public virtual void HandleCallBtnPressed(Telephone phone)
        {
            Console.WriteLine($"Deafult implementation of {nameof(HandleCallBtnPressed)}");
        }

        public virtual void HandleDigitBtnPressed(Telephone phone, int digit)
        {
            Console.WriteLine($"Default implementation of {nameof(HandleDigitBtnPressed)}");
        }

        public void HandleDisconnect(Telephone phone, string errormsg)
        {
            Console.WriteLine(errormsg);
            phone.SetState(new Disconnecting());
        }


    }
}
