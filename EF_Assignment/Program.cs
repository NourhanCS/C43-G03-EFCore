using EF_Assignment.Contexts;
using EF_Assignment.Entities;
using System.Net;

namespace EF_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();

            #region Insert
            #region Add for instructor
            //Instructor Ins01 = new Instructor()
            //{
            //    Name = "Omar",
            //    Bonus = 20,
            //    Salary = 20000,
            //    HourRate = 20,
            //    Address = "Cairo"
            //};
            //Instructor Ins02 = new Instructor()
            //{
            //    Name = "Ali",
            //    Bonus = 20,
            //    Salary = 50000,
            //    HourRate = 20,
            //    Address = "Giza"
            //};

            //Console.WriteLine(context.Entry(Ins01).State);

            //context.Add(Ins01);
            //context.Add(Ins02);

            //Console.WriteLine(context.Entry(Ins01).State);

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(Ins01).State);

            #endregion

            #region Add for Student
            {
                //Student Stu01 = new Student()
                //{
                //    FirstName = "Yousef",
                //    LastName="Mohammed",

                //    Address = "Cairo",
                //    Age=25

                //};
                //Student Stu02 = new Student()

                //{
                //    FirstName = "Mohammed",

                //    LastName="Omar",

                //    Address = "Giza",

                //    Age=30

                //};

                //Console.WriteLine(context.Entry(Stu01).State);

                //context.Add(Stu01);
                //context.Add(Stu02);

                //Console.WriteLine(context.Entry(Stu01).State);

                //context.SaveChanges();

                //Console.WriteLine(context.Entry(Stu01).State);
                #endregion

                #region Add for Course 
                //Course C01 = new Course()
                //{
                //    Name = "C#",
                //    Description="CS 1234",
                //    Duration=100

                //};
                //Course C02 = new Course()

                //{
                //    Name = "C++",
                //    Description = "CS ENG",
                //    Duration = 100

                //};

                //Console.WriteLine(context.Entry(C01).State);

                //context.Add(C01);
                //context.Add(C02);

                //Console.WriteLine(context.Entry(C01).State);

                //context.SaveChanges();

                //Console.WriteLine(context.Entry(C01).State);
                #endregion

                #region Add for Department
                //Department Dept01 = new Department()
                //{
                //    Name = "ITI",
                //    HiringDate = DateTime.UtcNow,

                //};
                //Department Dept02 = new Department()
                //{
                //    Name = "CS",
                //    HiringDate = DateTime.UtcNow,

                //};

                //Console.WriteLine(context.Entry(Dept01).State);

                //context.Add(Dept01);
                //context.Add(Dept02);

                //Console.WriteLine(context.Entry(Dept01).State);

                //context.SaveChanges();

                //Console.WriteLine(context.Entry(Dept01).State);

                #endregion

                #region Add for Topic
                //Topic Topic01 = new Topic()
                //{
                //    Name = "Operating System"


                //};
                //Topic Topic02 = new Topic()
                //{
                //    Name = "Data Structure"


                //};

                //Console.WriteLine(context.Entry(Topic01).State);

                //context.Add(Topic01);
                //context.Add(Topic02);

                //Console.WriteLine(context.Entry(Topic01).State);

                //context.SaveChanges();

                //Console.WriteLine(context.Entry(Topic01).State);

                #endregion

                #endregion

                #region Select
                var instructor =(from ins  in context.Instructors
                                 where ins.Id==1
                                 select ins).FirstOrDefault();
                Console.WriteLine(instructor?.Name??"No Data");
                #endregion

                #region Update
                instructor.Name = "Ahmed";
                Console.WriteLine(context.Entry(instructor).State);
                context.SaveChanges();
                #endregion

                #region Delete
                Console.WriteLine(context.Entry(instructor).State);
                context.Remove(instructor);

                Console.WriteLine(context.Entry(instructor).State);
                context.SaveChanges();


                #endregion



            }
        }
    }
}
