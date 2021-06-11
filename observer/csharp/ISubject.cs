using System;
using System.Collections.Generic;

namespace CSharp{
    public interface ISubject{
        //Attach am observer to the event
        void Attach(IObserver observer){
        }
        //Detach an observer to the event
        void Detach(IObserver observer){

        }
        //Notify observers about the event
        void Notify(IObserver observer){

        }
    }
}