using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ObserverPattern
{
    public class ObserverPattern : IRunPattern
    {
        public void Run()
        {
            Manager manager = new Manager();

            Employee mark = new Employee("Mark");
            Employee jack = new Employee("Jack");
            Employee lacey = new Employee("Lacey");

            manager.AddEmployee(new NotificationHandle(mark.RecieveCommand));
            manager.AddEmployee(new NotificationHandle(jack.RecieveCommand));
            manager.AddEmployee(new NotificationHandle(lacey.RecieveCommand));

            manager.publishCommand("To buy a pizza for me!");
        }
    }

    public delegate void NotificationHandle(ISendCommand obj);

    public interface ISendCommand
    {
        string GetCmd();
    }

    public class Manager : ISendCommand
    {
        public string command;
        public NotificationHandle notificatEvent;

        public void publishCommand(string cmd)
        {
            command = cmd;
            notificatEvent.Invoke(this);
        }

        public string GetCmd()
        {
            return command;
        }

        public void AddEmployee(NotificationHandle handle)
        {
            notificatEvent += handle;
        }

        public void RemoveEmployee(NotificationHandle handle)
        {
            notificatEvent -= handle;
        }
    }

    public interface IRecieveCommand
    {
        void RecieveCommand(ISendCommand obj);
    }

    public class Employee : IRecieveCommand
    {
        public string _name;

        public Employee(string name)
        {
            _name = name;
        }

        public void RecieveCommand(ISendCommand man)
        {
            string cmd = man.GetCmd();
            Console.WriteLine(_name + " recieved command : " + cmd);
        }
    }
}
