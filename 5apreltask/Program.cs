namespace _5apreltask
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(companyname);

            Compamy company = new Compamy(companyId, companyName);

            bool search = true;

            while (search)
            {
                Console.WriteLine("1 - Employee elave et");
                Console.WriteLine("2 - Id ile tap");
                Console.WriteLine("0 - Cixis");

                Console.Write("Secimini daxil et: ");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:

                        int employeeId = Console.WriteLine(id);

                        string employeeName = Console.WriteLine(name)
                        
                        string employeeSurname = Console.WriteLine(Surname);

                        Employee employee = new Employee { id = employeeId, name = employeeName, Surname = employeeSurname };

                        company.Add(employee);
                        break;

                    case 2:

                        int employeeIdToFind = Console.WriteLine(id);

                        Employee employeeFound = company.FindById(employeeIdToFind);

                        if (employeeFound != null)
                        {
                            Console.WriteLine($"Employee found: {employeeFound.Name} {employeeFound.Surname}");
                        }
                        else
                        {
                            Console.WriteLine("It is not true");
                        }
                        break;

                    case 0:
                        search = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }







}
        }
        }
    }
