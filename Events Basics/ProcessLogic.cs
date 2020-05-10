using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Basics
{
    //creatin delegate for an event
    public delegate void Notify();
    class ProcessLogic
    {
        //creating the event
        public event Notify ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Process Started");
            OnProcessCompleted();
        }
        //protected virtual raises event, typcally On<event> method name
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }

    }
}
