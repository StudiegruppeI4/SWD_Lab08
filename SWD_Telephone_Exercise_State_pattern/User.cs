using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Telephone_Exercise_State_pattern
{




    class User
    {
        private Telephone phone;

        public User(Telephone newPhoneWhoDis)
        {
            phone = newPhoneWhoDis;
        }

        public void PressDigitBtn(int digit)
        {
            if (digit >= 0 && digit < 10)
            {
                phone.OnDigitBtnEvent(digit);
            }
        }

        public void PressCallBtn()
        {
            phone.OnCallBtnEvent();
        }

        public void PressMuteBtn()
        {
            phone.OnMuteBtnEvent();
        }

    }
}
