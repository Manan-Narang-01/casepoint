namespace _03_09_25;

public class LinqTabDemo
{
    public static void LinqdatabaseMain()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(
                "Server=localhost;Port=5432;Database=intern093;User Id=postgres;Password=root;"))
            {
                

                DataSet ds = new DataSet();

                using (NpgsqlCommand cmd = new NpgsqlCommand("select * from t_emp", con))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }

                var emplist = (from DataRow dr in ds.Tables[0].Rows

                            where dr["empname"].ToString().StartsWith("M")
                               select new
                               {
                                   empid = Convert.ToInt32(dr["empid"]),
                                   name = dr["empname"].ToString(),
                                   salary = Convert.ToDouble(dr["salary"]),
                               }).ToList();

                foreach (var emp in emplist)
                {
                    Console.WriteLine($"empid={emp.empid} name={emp.name} salary={emp.salary}");
                }
            }
        }

}
