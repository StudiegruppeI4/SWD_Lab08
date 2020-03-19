using System;

namespace SWD_Telephone_Exercise_State_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Telephone phone = new Telephone(new Idle(), new UnMutedState());
            User AGRI = new User(phone);

            while (true)
            {
                Console.WriteLine("Options are: 0-9 for press digit and c for press call button");

                switch (Console.ReadKey().KeyChar)
                {
                    case char n when (Char.IsDigit(n)):
                        AGRI.PressDigitBtn((int)n-48);
                        break;

                    case char n when (n == 'c' || n == 'C'):
                        AGRI.PressCallBtn();
                        break;

                    case char n when (n == 'd' || n == 'D'):
                        phone.OnDisconnectEvent();
                        break;

                    case char n when (n == 'm' || n == 'M'):
                        AGRI.PressMuteBtn();
                        break;



                    default:
                        Console.WriteLine("Remeber your options");
                        break;
                }
            }
        } 
    }
}
