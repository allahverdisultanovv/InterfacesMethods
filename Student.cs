using İnterfaceStaticMembers.Interfaces;

namespace İnterfaceStaticMembers
{
    internal class Student : ICodeAcademy
    {
        private string _name;
        private string _surname;
        private static int _count;
        public int Id;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name is not correct");
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length > 2)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Surname is incorrect");
                }
            }

        }

        public string CodeEmeail { get; set; }


        public static string Capitalize(string name)
        {
            name.Trim();
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }

        public static bool CheckName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                {

                    return false;
                }
            }

            return true;
        }

        public string GenerateEmeail()
        {
            return String.Concat(_name.ToLower(), ".", _surname.ToLower(), "@code.edu.az");
        }

        public Student(string name, string surname)
        {
            {
                if (CheckName(name))
                {
                    Name = Capitalize(name);
                }
                else
                {
                    Console.WriteLine("Name is incorrect");
                }
                if (CheckName(surname))
                {
                    Surname = Capitalize(surname);
                }
                else
                {
                    Console.WriteLine("Surname is incorrect");
                }

                Id = ++_count;
                CodeEmeail = GenerateEmeail();
            }
        }


    }
}
