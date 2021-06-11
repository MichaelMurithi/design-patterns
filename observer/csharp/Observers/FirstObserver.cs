using System;

namespace CSharp.Observers{
    public class FirstObserver: IObserver{
        void Update(ISubject subject){
            Subject subj = subject as Subject;
            if(subj.State == 0 || subj.State >= 2){
                Console.WriteLine("First Observer: I just reacted to a state where the subject state is ",subj.State);
            }
            

        }
    }
}