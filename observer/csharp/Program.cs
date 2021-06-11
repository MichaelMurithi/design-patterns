using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new Observers.FirstObserver();
            subject.Attach(observerA);

            var ObserverB = new Observers.SecondObserver();
            subject.Attach(ObserverB);

            subject.SomeUpdateLogic();
            subject.SomeUpdateLogic();

            subject.Detach(observerA);
            subject.SomeUpdateLogic();
        }
    }
}
