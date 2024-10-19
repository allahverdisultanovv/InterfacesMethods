using İnterfaceStaticMembers;

Student student = new("Allahverdi", "SultAnov");
Student student1 = new("Taceddin", "Esedzade");
Student student2 = new("Huseyn", "Abbasov");
Student student3 = new("Azad", "AsHUrov");
Student student4 = new("Ilkin", "SultAnov");
Student student5 = new("Islam", "Eliyev");
Student student6 = new("Elcin", "Memmedov");
Student student7 = new("Eli", "SultAnov");

Group group = new("Bp217");
Group group2 = new("BP218");
Group.AddGroup(group);
Group.AddGroup(group2);
group.AddStudent(student1);
group.AddStudent(student3);
group.AddStudent(student5);
group.AddStudent(student6);
group2.AddStudent(student7);
group2.AddStudent(student2);
group2.AddStudent(student4);
group2.AddStudent(student);

Group.ShowAllGroups();
group.ShowStudents();
group.GetGroupInfo();




