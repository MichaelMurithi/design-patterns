using System;

namespace CSharp.Observers{
    public class SecondObserver: IObserver{
        void Update(ISubject subject){
            Console.WriteLine("Second observer: I have been notified");
            if((subject as Subject).State >= 0){
                Console.WriteLine("Second Observer: I just reacted to the state where the subject is, ");
            }
            else
            {
                Console.WriteLine("Second Observer: So bad I cannot react to such a state");
            }    
        }
    }
}