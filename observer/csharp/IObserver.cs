using System;

namespace CSharp{
    public interface IObserver{
        //Receive update from the subject
        void Update(ISubject subject){

        }
    }
}