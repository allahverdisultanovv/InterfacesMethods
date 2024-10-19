namespace İnterfaceStaticMembers
{
    internal class Group
    {
        public static Group[] Groups = new Group[0];
        public static int GroupCount;
        public int GroupId;
        public string GroupName;
        public Student[] Students = new Student[0];

        public Student GetStudent(int id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)

                {
                    return Students[i];
                }

            }
            return null;
        }
        public void GetGroupInfo()
        {
            Console.WriteLine($"{GroupName},  {Students.Length}");
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public void Search(string name)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name == name)
                {
                    Console.WriteLine($"{Students[i].Name} , {Students[i].Surname}");
                }
            }
        }
        public void RemoveStudent(int id)
        {
            int findIndex = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    findIndex = i;
                }
            }
            for (int i = findIndex; i < Students.Length - 1; i++)
            {
                Students[i] = Students[i + 1];
            }
            Array.Resize(ref Students, Students.Length - 1);
        }
        public void ShowStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"{Students[i].Name} , {Students[i].Surname}");
            }
        }


        public Group(string name)
        {
            GroupName = name;
            GroupId = ++GroupCount;
        }



        public static void ShowAllGroups()
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                Console.WriteLine($"{Groups[i].GroupName}");
            }
        }
        public static void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }
        public static void RemoveGroup(int groupId)
        {
            int findIndex = 0;
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].GroupId == groupId)
                {
                    findIndex = i;
                }
            }
            for (int i = findIndex; i < Groups.Length - 1; i++)
            {
                Groups[i] = Groups[i + 1];
            }
            Array.Resize(ref Groups, Groups.Length - 1);
        }
    }
}
