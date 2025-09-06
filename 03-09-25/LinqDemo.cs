namespace _03_09_25;

public class LinqDemo
{
    public static bool IsTeenAger(this Students std){
        return std.Age>12 && std.Age<20;
    }

    public class Students {

        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public static void LinqObjMain(){

        List<Students> StudentsData=new List<Students>(){
            new Students(){ StudentId=1, Name="John", Age=13 },
            new Students(){ StudentId=2, Name="Steve", Age=15 },
            new Students(){ StudentId=3, Name="Bill", Age=18 },
            new Students(){ StudentId=4, Name="Ram", Age=20 },
            new Students(){ StudentId=5, Name="Ron", Age=18 },
            new Students(){ StudentId=6, Name="Rob", Age=15 },
            new Students(){ StudentId=7, Name="Tom", Age=18 },
            new Students(){ StudentId=8, Name="manan", Age=22 }
        };


        var filterResult= from s in StudentsData select s;

        var filterResult= StudentsData.Select(s=>s);

        var filterResult = from s in StudentsData
                               where s.Age > 15
                               select s;

        var filterResult = StudentsData.Where(s=>s.Age>15 && s.Age<19).Select(s=>s);

        Func<Students,bool> isAdult= delegate(Students std){
            return std.Age>=18;
        };

        var filterResult= from s in StudentsData where isAdult(s) select s;

        var filterResult = StudentsData.Where(isAdult).Select(s=>s);


        var filterResult=from s in StudentsData where s.IsTeenAger() select s;

        var filterResult = StudentsData.Where(s=>s.IsTeenAger()).Select(s=>s);

        var filterResult = from s in StudentsData orderby s.Age select s;

        var filterResult = StudentsData.OrderBy(s=>s.Age).Select(s=>s);


        var filterResult = from s in StudentsData orderby s.Age descending, s.Name  select s;

        var filterResult = StudentsData.OrderByDescending(s=>s.Age).ThenBy(s=>s.Name).Select(s=>s);


        var filterResult= (from s in StudentsData where s.Age>18 select s).FirstOrDefault(); 
        var filterResult= (from s in StudentsData where s.Age>18 select s).LastOrDefault(); 
        var filterResult= (from s in StudentsData where s.Age==18 select s).SingleOrDefault();

        var filterResult = from s in StudentsData
                   select new
                   {
                       Name = s.Name,
                       Age = s.Age
                   };


        Console.WriteLine("\nAll Students: \n");

        Console.WriteLine($"StudentId: {filterResult.StudentId}, Name: {filterResult.Name}, Age: {filterResult.Age}");

        foreach(var std in filterResult){
           
            Console.WriteLine($", Name: {std.Name}, Age: {std.Age}");
        }





        var data= from s in StudentsData group s by s.Age;

        var data = StudentsData.GroupBy(s=>s.Age);

        foreach(var agegroup in data){

            Console.WriteLine($"\nAge Group: {agegroup.Key}\n");
            Console.WriteLine($"Total Students:{agegroup.Count()}");
            Console.WriteLine($"Average Age: {agegroup.Average(s=>s.Age)}");
            Console.WriteLine($"Sum Age: {agegroup.Sum(s=>s.Age)}\n");

            foreach(Students std in agegroup){   
            Console.WriteLine($"StudentId: {std.StudentId}, Name: {std.Name}, Age: {std.Age}");
            }
        }
    }


}
