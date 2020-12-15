namespace DotNet.DesignPattern.Intermediate
{
    using System;

    /// <summary>
    ///     Main Program Class
    /// </summary>
    class Program
    {
        /// <summary>
        ///     Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Prototype Design Pattern---------------------\r\n");
            Employee_DeepCopy emp = new Employee_DeepCopy()
            {
                Name = "Ram",
                Age = 25,
                EmploymentType = "Permanent",
                Address = new Address()
                {
                    City = "Jaipur",
                    State = "Rajasthan"
                }
            };
            Console.WriteLine("...Original...");
            Console.WriteLine(GlobalText.EmpNameLabel + emp.Name + "");
            Console.WriteLine(GlobalText.EmpAgeLabel + emp.Age + "");
            Console.WriteLine(GlobalText.EmpEmploymentTypeLabel + emp.EmploymentType + "");
            Console.WriteLine(GlobalText.EmpAddressCityLabel + emp.Address.City + "");
            Console.WriteLine(GlobalText.EmpAddressStateLabel + emp.Address.State + "");
            Employee_DeepCopy emp1 = (Employee_DeepCopy)emp.Clone();
            Console.WriteLine("...Cloned Copy...");
            Console.WriteLine(GlobalText.Emp1NameLabel + emp1.Name + "");
            Console.WriteLine(GlobalText.Emp1AgeLabel + emp1.Age + "");
            Console.WriteLine(GlobalText.Emp1EmploymentTypeLabel + emp1.EmploymentType + "");
            Console.WriteLine(GlobalText.Emp1AddressCityLabel + emp1.Address.City + "");
            Console.WriteLine(GlobalText.Emp1AddressStateLabel + emp1.Address.State + "");
            Console.WriteLine("...Make changes to the clone copy...");
            emp1.Name = "Shyam";
            emp1.Age = 26;
            emp1.EmploymentType = "Temp";
            emp1.Address.State = "Maharastra";
            emp1.Address.City = "Mumbai";
            Console.WriteLine("...Deep Copy...");
            Console.WriteLine(GlobalText.Emp1NameLabel + emp1.Name + "");
            Console.WriteLine(GlobalText.Emp1AgeLabel + emp1.Age + "");
            Console.WriteLine(GlobalText.Emp1EmploymentTypeLabel + emp1.EmploymentType + "");
            Console.WriteLine(GlobalText.Emp1AddressCityLabel + emp1.Address.City + "");
            Console.WriteLine(GlobalText.Emp1AddressStateLabel + emp1.Address.State + "");
            Console.WriteLine("...Original...");
            Console.WriteLine(GlobalText.EmpNameLabel + emp.Name + "");
            Console.WriteLine(GlobalText.EmpAgeLabel + emp.Age + "");
            Console.WriteLine(GlobalText.EmpEmploymentTypeLabel + emp.EmploymentType + "");
            Console.WriteLine(GlobalText.EmpAddressCityLabel + emp.Address.City + "");
            Console.WriteLine(GlobalText.EmpAddressStateLabel + emp.Address.State + "");
            Console.WriteLine("---------------");
            Employee_ShallowCopy empscpy = new Employee_ShallowCopy()
            {
                Name = "Varun",
                Age = 22,
                EmploymentType = "Permanent",
                Address = new Address_New()
                {
                    City = "Sikar",
                    State = "Rajasthan"
                }
            };
            Console.WriteLine("...Original...");
            Console.WriteLine(GlobalText.EmpNameLabel + empscpy.Name + "");
            Console.WriteLine(GlobalText.EmpAgeLabel + empscpy.Age + "");
            Console.WriteLine(GlobalText.EmpEmploymentTypeLabel + empscpy.EmploymentType + "");
            Console.WriteLine(GlobalText.EmpAddressCityLabel + empscpy.Address.City + "");
            Console.WriteLine(GlobalText.EmpAddressStateLabel + empscpy.Address.State + "");
            Employee_ShallowCopy emp2 = empscpy.Clone() as Employee_ShallowCopy;
            Console.WriteLine("...Shallow Copy...");
            Console.WriteLine(GlobalText.Emp1NameLabel + emp2.Name + "");
            Console.WriteLine(GlobalText.Emp1AgeLabel + emp2.Age + "");
            Console.WriteLine(GlobalText.Emp1EmploymentTypeLabel + emp2.EmploymentType + "");
            Console.WriteLine(GlobalText.Emp1AddressCityLabel + emp2.Address.City + "");
            Console.WriteLine(GlobalText.Emp1AddressStateLabel + emp2.Address.State + "");
            Console.WriteLine("...Make changes to the clone copy...");
            emp2.Name = "Tarun";
            emp2.Age = 43;
            emp2.EmploymentType = "Temp";
            emp2.Address.State = "Maharastra";
            emp2.Address.City = "Mumbai";
            Console.WriteLine("...Shallow Copy...");
            Console.WriteLine(GlobalText.Emp1NameLabel + emp2.Name + "");
            Console.WriteLine(GlobalText.Emp1AgeLabel + emp2.Age + "");
            Console.WriteLine(GlobalText.Emp1EmploymentTypeLabel + emp2.EmploymentType + "");
            Console.WriteLine(GlobalText.Emp1AddressCityLabel + emp2.Address.City + "");
            Console.WriteLine(GlobalText.Emp1AddressStateLabel + emp2.Address.State + "");
            Console.WriteLine("...Original...");
            Console.WriteLine(GlobalText.EmpNameLabel + empscpy.Name + "");
            Console.WriteLine(GlobalText.EmpAgeLabel + empscpy.Age + "");
            Console.WriteLine(GlobalText.EmpEmploymentTypeLabel + empscpy.EmploymentType + "");
            Console.WriteLine(GlobalText.EmpAddressCityLabel + empscpy.Address.City + "");
            Console.WriteLine(GlobalText.EmpAddressStateLabel + empscpy.Address.State + "");

            Console.WriteLine("\r\n-----------------Adapter Design Pattern---------------------\r\n");
            ITarget obj = new Adapter();
            foreach (string objects in obj.GetProducts())
            {
                Console.WriteLine(objects);
            }

            Console.WriteLine("\r\n-----------------Observer Design Pattern---------------------\r\n");
            ConcreteSubject subject = new ConcreteSubject();
            // Observer1 takes a subscription to the store
            ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
            subject.Subscribe(observer1);
            // Observer2 also subscribes to the store
            subject.Subscribe(new ConcreteObserver("Observer 2"));
            subject.Inventory++;
            // Observer1 unsubscribes and Observer3 subscribes to notifications.
            subject.Unsubscribe(observer1);
            subject.Subscribe(new ConcreteObserver("Observer 3"));
            subject.Inventory++;

            Console.WriteLine("\r\n-----------------Mediator Design Pattern---------------------\r\n");
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);
            Console.WriteLine(GlobalText.ClientTriggetsOperationAText);
            component1.DoA();
            Console.WriteLine();
            Console.WriteLine(GlobalText.ClientTriggetsOperationDText);
            component2.DoD();

            Console.WriteLine("\r\n-----------------Bridge Design Pattern---------------------\r\n");
            MySuperSmartTV myTv = new MySuperSmartTV();
            Console.WriteLine(GlobalText.SelectASourceToGetTVGuideAndPlayText);
            Console.WriteLine(GlobalText.SelectTVOption);
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.KeyChar)
            {
                case '1':
                    myTv.VideoSource = new LocalCabelTv();
                    break;

                case '2':
                    myTv.VideoSource = new LocalDishTv();
                    break;

                case '3':
                    myTv.VideoSource = new TvService();
                    break;
            }
            Console.WriteLine();
            myTv.ShowTvGuide();
            myTv.PlayTV();

            Console.WriteLine("\r\n--------------------------------------------------------------\r\n");
            Console.ReadLine();
        }
    }
}
