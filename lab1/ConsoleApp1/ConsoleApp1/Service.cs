using ConsoleApp1.AbstractFactory;
using ConsoleApp1.Builder;
using ConsoleApp1.Ent;
using ConsoleApp1.FactoryMethod;
using ConsoleApp1.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Service
    {
        EmployeeCreator<AdministrativeEmployee> employeeCreator = new AdministrativeEmployeeCreator();

        DefaultBranchPaymentFactory paymentFactory = new DefaultBranchPaymentFactory();

        ShiftAllocator getAShifter = new ShiftAllocator();
        ShiftBuilder shiftBuilder;

        CommonEvent defaultEvent = new CommonEvent()
        {
            EventName = "Default",
            EventDate = DateTime.Now,
            Duration = TimeSpan.FromHours(1),
            Subject = "Default"
        };
        //CommonEventManager eventManager;

        //Factory Method
        public Employee CreateAdministrativeEmployee(string firstName, string lastName, string email, string phoneNumber)
        {
            var adminEmpl = employeeCreator.FactoryMethod(firstName, lastName, email, phoneNumber);
            Console.WriteLine($"Employee: {adminEmpl.FirstName} {adminEmpl.LastName} with role: {adminEmpl.AdministrativeRights} was created");
            return adminEmpl;
        }

        //Abstract Factory
        public void SetSalaryAndBenefits(Employee employee, int workingHours, int salaryPerHour, int extraExpenses)
        {
            employee.Salary = paymentFactory.CreateSalary(workingHours, salaryPerHour);
            employee.Benefits = paymentFactory.CreateBenefits(extraExpenses);
        }

        public void GetSalary(Employee employee)
        {
            var sal = employee.Salary.GetSalary(employee.Benefits);
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName} got {sal}");
        }

        //Builder
        public void SetMorningShift(Employee employee)
        {
            shiftBuilder = new MorningShiftBuilder();
            getAShifter.Allocate(shiftBuilder);
            employee.Shift = shiftBuilder.Shift;
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName} works from {employee.Shift.StartTime} till {employee.Shift.EndTime}");
        }

        //Prototype + Singleton
        public void CreateEvent(string eventName, DateTime eventDate, TimeSpan duration, string subject)
        {
            var eventManager = CommonEventManager.Instance;
            CommonEvent _event = defaultEvent.Clone() as CommonEvent;
            _event.EventName = eventName;
            _event.EventDate = eventDate;
            _event.Duration = duration;
            _event.Subject = subject;
            eventManager.AddEvent(_event);
        }

        public void AddAttendant(string eventName, Employee employee)
        {
            var eventManager = CommonEventManager.Instance;
            eventManager.AddAttendant(eventName, employee);
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName} will be at {eventName}");
        }



    }
}
