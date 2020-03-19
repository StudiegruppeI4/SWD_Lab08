using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Telephone_Exercise_State_pattern
{
    class Telephone
    {
        //Attributes
        private TelephoneState state_;
        private MicrophoneState micState_;
        private SpeakerState speakerState_;


        //Properties
        public List<int> CurrentNumbers { get; set; } = new List<int>();
        public bool Connection { get; set; } = false;
        public bool MicOn { get; set; } = true;
        public bool SpeakerOn { get; set; } = false;

        //Events
        public event EventHandler<List<int>> CallBtnEvent;
        public event EventHandler<int> DigitBtnEvent;
        public event EventHandler<string> DisconnectEvent;
        public event EventHandler MuteBtnEvent;
        //Functions

        public Telephone(TelephoneState initialState, MicrophoneState micstate)
        {
            micState_ = micstate;
            state_ = initialState;
            DigitBtnEvent += DigitBtnPresed;
            CallBtnEvent += CallBtnPressed;
            DisconnectEvent += Disconnect;
            MuteBtnEvent += MuteBtnPressed;
        }

        public TelephoneState GetState()
        {
            return this.state_;
        }

        public void SetStateMicrphone(MicrophoneState state)
        {
            micState_ = state;
            micState_.OnEnter(this);
        }


        public void OnMuteBtnEvent()
        {
            MuteBtnEvent?.Invoke(this, null);
        }

        public void MuteBtnPressed(object e, EventArgs a)
        {
            micState_.HandleMuteBtnPressed(this);
        }


        public void OnDisconnectEvent()
        {
            DisconnectEvent?.Invoke(this, "Another user disconnected your call");
        }

        public void Disconnect(object e, string args)
        {
            state_.HandleDisconnect(this, args);
        }

        public void OnCallBtnEvent()
        {
            if (CurrentNumbers.Count == 8)
            {
                CallBtnEvent?.Invoke(this, CurrentNumbers);
            }
            else
            {
                CurrentNumbers.Clear();
            }
        }

        public void OnDigitBtnEvent(int digit)
        {
            DigitBtnEvent?.Invoke(this, digit);
        }



        public void SetState(TelephoneState state)
        {
            state_ = state;
            state_.OnEnter(this);
        }

        //State actions
        public void CallBtnPressed(object e, List<int> numbers)
        {
            state_.HandleCallBtnPressed(this);
        }

        public void DigitBtnPresed(object e, int digit)
        {
            state_.HandleDigitBtnPressed(this, digit);
        }

        public void AddDigitToDisplay(int digit)
        {
            CurrentNumbers.Add(digit);
        }

        public void CallNumber()
        {
            Console.WriteLine($"Connecting to {CurrentNumbers}");
        }

    }
}
