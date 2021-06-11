using System;

namespace CSharp.Observers{
    public class SecondObserver: IObserver{
        void Update(ISubject subject){
            Subject subj = subject as Subject;
            if(subj.State >= 0){
                Console.WriteLine("Second Observer: I just reacted to the state where the subject is, ", subj.State);
            }
            else
            {
                Console.WriteLine("Second Observer: So bad I cannot react to such a state");
            }    
        }
    }
}