using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharp{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer){
            Console.WriteLine("Subject: A new Observer is on watch....");
            this._observers.Add(observer);
        }
        public void Detach(IObserver observer){
            Console.WriteLine("Subject: Oops, so bad an observer left:(");
        }
        public void Notify(){
            Console.WriteLine("Subject: Notifying observers.. :(");

            foreach(IObserver ob in _observers){
                ob.Update(this);
            }
        }
        public void SomeUpdateLogic(){
            Console.WriteLine("Subject: Keep Silent, I am doing something important..");
            this.State = new Random().Next(0, 10);
            Thread.Sleep(15);

            Console.WriteLine("Subject: Finally, my state has changed to:", this.State);
            this.Notify();
        }
    }
}