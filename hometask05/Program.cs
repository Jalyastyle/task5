using System;
#region FirstTask
public class firsttask
{
    public static void Main1(string[] args)
    {
        int total = 5;
        Person[] people = new Person[total];

        for (int i = 0; i < total; i++)
        {
            people[i] = new Person()
            {
                Name = Console.ReadLine()
            };
        }

        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(people[i].ToString());
        }
        Console.ReadLine();
    }

    public class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return "Salam, Menim adim " + Name;
        }
    }
}

#endregion

#region SecondTask
public class secondtask
{
    public static void Second(string[] args)
    {
        int total = 5;
        Person[] people = new Person[total];

        for (int i = 0; i < total; i++)
        {
            people[i] = new Person(Console.ReadLine());
        }

        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(people[i].ToString());
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Salam, Menim adim" + Name;
        }

        ~Person()
        {
            Name = string.Empty;
        }
    }
}

#endregion

#region ThirdTask
public class thirdtask
{
    public static void school()
    {
        Person myPerson = new Person();
        myPerson.Greet();

        Student myStudent = new Student();
        myStudent.SetAge(18);
        myStudent.Greet();
        myStudent.ShowAge();
        myStudent.Study();

        Teacher myTeacher = new Teacher();
        myTeacher.SetAge(40);
        myTeacher.Greet();
        myTeacher.Explain();
    }
}

public class Person
{
    protected int age;

    public void Greet()
    {
        Console.WriteLine("Salam");
    }
    public void SetAge(int n)
    {
        age = n;
    }
}
public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("Men oxuyuram");
    }
    public void ShowAge()
    {
        Console.WriteLine("Menim {0} yasim var", age);
    }
}
public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("Men izah edirem.");
    }
}
#endregion

#region FourthTask
public class Fourthtask
{
    public static void Album()
    {
        PhotoBook myAlbum1 = new PhotoBook();
        Console.WriteLine(myAlbum1.GetNumberPages());

        PhotoBook myAlbum2 = new PhotoBook(18);
        Console.WriteLine(myAlbum2.GetNumberPages());

        SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook();
        Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
    }
}

public class PhotoBook
{
    protected int numPages;

    public PhotoBook()
    {
        numPages = 09;
    }

    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}

public class SuperPhotoBook : PhotoBook
{
    public SuperPhotoBook()
    {
        numPages = 727;
    }
}
#endregion

#region FifthTask
public class InheritanceObjects
{
    public static void Main(string[] args)
    {
        int total = 2;
        Person[] persons = new Person[total];

        for (int i = 0; i < total; i++)
        {
            if (i == 0)
            {
                persons[i] = new Teacher(Console.ReadLine());
            }
            else
            {
                persons[i] = new Student(Console.ReadLine());
            }
        }

        for (int i = 0; i < total; i++)
        {
            if (i == 0)
            {
                ((Teacher)persons[i]).Explain();

            }
            else
            {
                ((Student)persons[i]).Study();
            }
        }
    }

    public class Person
    {
        protected string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Salam, menim adim " + Name;
        }

        ~Person()
        {
            Name = string.Empty;
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }

        public void Explain()
        {
            Console.WriteLine("Kesildi");
        }
    }

    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine("Bitirdi");
        }
    }
}
#endregion