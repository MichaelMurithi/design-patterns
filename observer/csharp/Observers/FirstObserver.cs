using System;

namespace CSharp.Observers{
    public class FirstObserver: IObserver{
        void Update(ISubject subject){
            if((subject as Subject).State == 0 || (subject as Subject).State >= 2){
                Console.WriteLine("First Observer: I just reacted to a state where the subject state is ");
            }
            else
            {
                Console.WriteLine("Second Observer: So bad I cannot react to such a state");
            }    
        }
    }
}