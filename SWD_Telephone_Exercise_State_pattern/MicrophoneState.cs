using System;

namespace SWD_Telephone_Exercise_State_pattern
{
    abstract class MicrophoneState
    {
        public abstract void OnEnter(Telephone phone);


        public void HandleMuteBtnPressed(Telephone e)
        {
            TelephoneState state = e.GetState();
            if(state.GetType() == typeof(Connected))
                {
                    middleman(e);
                }
            else
            {
                Console.WriteLine("Cannot control mic when not in call");
            }
        }


        public abstract void middleman(Telephone e);
    }
}