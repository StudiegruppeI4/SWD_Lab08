using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Telephone_Exercise_State_pattern
{
    class Idle : TelephoneState
    {
        public override void OnEnter(Telephone phone)
        {
            phone.CurrentNumbers.Clear();
            Console.WriteLine("Now entering state idle");
        }
        public override void OnExit(Telephone phone)
        {
            Console.WriteLine("Now exiting state idle");
        }

        public override void HandleDigitBtnPressed(Telephone phone, int digit)
        {
            
            Console.WriteLine($"Now adding {digit} to number");
            phone.AddDigitToDisplay(digit);
            string output = "";
            foreach (int number in phone.CurrentNumbers)
            {
                output += number;
            }
            Console.WriteLine(output);
        }

        public override void HandleCallBtnPressed(Telephone phone)
        {
            Console.WriteLine($"Calling {phone.CurrentNumbers}");
            phone.SetState(new Calling());
        }

    }
}
