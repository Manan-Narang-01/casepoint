class Program
{
    public static void main(string[] args)
    {
        string con = "Server=localhost;Port=5432;Database=intern093;User Id=postgres;Password=root";

        string createtbl = "create table t_test(id int,name varchar(20));";
        try
        {
            using (var connection = new NpgsqlConnection(con))
            {
                connection.open();
            }
            using (var cmd = new Npgslcommand(createtbl))
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created successfully");
            }
        }
        catch (Exception e)
        {

            Console.WriteLine($"error : {e.Message}");
        }
    }
}