namespace crud;

public class EmployeeService
{
    private string connectionstring = "Server=localhost;Port=5432;Database=intern093;User Id=postgres;Password=root";
    public void AddEmployee(Employee emp)
    {
        using var conn = new NpgsqlConnection(connectionstring);
        conn.open();
        using var conn = new NpgsqlCommand("INSERT INTO t1(c_id,c_name,c_balance) VALUES(@id,@name,@balance)");
        cmd.Paramteres.AddWithValue("id", emp.EmpId);
        cmd.Paramteres.AddWithValue("name", emp.EmpName);
        cmd.Paramteres.AddWithValue("balance", emp.EmpBalance);
        cmd.ExecuteNonQuery();

    }

    public List<Employee> GetAllEmployee()
    {
        var list = new List<Employee>();
        using var conn = new NpgsqlConnection(connectionstring);
        conn.open();
        using var conn = new NpgsqlCommand("SELECT * FROM t1");
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new Employee
            {
                EmpId = reader.GetInt32(0),
                EmpName = reader.GetString(1),
                EmpBalance = reader.GetInt32(0)

            });

        }
        return list;

    }

    public Employee GetEmployee()
    {
        var list = new List<Employee>();
        using var conn = new NpgsqlConnection(connectionstring);
        conn.open();
        using var conn = new NpgsqlCommand("SELECT * FROM t1 WHERE c_id=@id");
        cmd.Paramteres.AddWithValue("c_id", emp.EmpId);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new Employee
            {
                EmpId = reader.GetInt32(0),
                EmpName = reader.GetString(1),
                EmpBalance = reader.GetInt32(0)

            });

        }
        return null;

    }

    public void UpdateEmployee(Employee emp)
    {
        using var conn = new NpgsqlConnection(connectionstring);
        conn.open();
        using var conn = new NpgsqlCommand("Update t1 SET c_name=@name,c_balance=@balance WHERE c_id=@id");
        cmd.Paramteres.AddWithValue("id", emp.EmpId);
        cmd.Paramteres.AddWithValue("name", emp.EmpName);
        cmd.Paramteres.AddWithValue("balance", emp.EmpBalance);
        int rowaffected=cmd.ExecuteNonQuery();
        return rowaffected > 0;
    }

    public void DeleteEmployee(Employee emp)
    {
        using var conn = new NpgsqlConnection(connectionstring);
        conn.open();
        using var conn = new NpgsqlCommand("DELETE FROM t1 WHERE c_id=@id");
        cmd.Paramteres.AddWithValue("id", emp.EmpId);
        int rowaffected=cmd.ExecuteNonQuery();
        return rowaffected > 0;

    }

}