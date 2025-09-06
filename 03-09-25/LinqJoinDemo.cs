namespace _03_09_25;
public class Student{
    public int Id {get; set; }
    public string Name {get; set; }
    public string Age {get; set; }
    public int StdId{get; set; }
}

public class Standard{
    public int StdId {get; set; }
    public string StdName {get; set; }
}

public class LinqJoinDemo
{
     public static List<Student> Students = new List<Student>{
        new Student(){ Id=1, Name="John", Age="13", StdId=1 },
        new Student(){ Id=2, Name="Steve", Age="15", StdId=1 },
        new Student(){ Id=3, Name="Bill", Age="18", StdId=2 },
        new Student(){ Id=4, Name="Ram", Age="20", StdId=2 },
        new Student(){ Id=5, Name="Ron", Age="18", StdId=3 },
        new Student(){ Id=6, Name="Rob", Age="15", StdId=4 },
        new Student(){ Id=7, Name="Tom", Age="18", StdId=3 },
        new Student(){ Id=8, Name="Manan", Age="22" }
    };

  public static List<Standard> Standards = new List<Standard>{
        new Standard(){ StdId=1, StdName="First" },
        new Standard(){ StdId=2, StdName="Second" },
        new Standard(){ StdId=3, StdName="Third" },
        new Standard(){ StdId=4, StdName="Fourth" },
    };


    public static void LinqJoinsMain(){


        var joindata= Students.Join(
            Standards,
            student=>student.StdId,
            standard=>standard.StdId,
            (student,standard)=>new{student,standard}
        );

        foreach(var data in joindata){
            Console.WriteLine($"Student: {data.student.Name}, Standard: {data.standard.StdName}");
        }

        var joindata= from s in Students 
                        join std in Standards on s.StdId equals std.StdId
                        into Obj
                        from std in Obj.DefaultIfEmpty()
                        select new{
                            studentname=s.Name,
                            standardname=std?.StdName ?? "No standard"
                            }; 

        foreach(var data in joindata){
            Console.WriteLine($"Student: {data.studentname}, Standard: {data.standardname}");
        }
    }

}
