using System;


public class connect
{
    public connect()
    {
        private static string server = @"localhost:3306";
    private static string dataBase = "kingsmenu";
    private static string user = "root";
    private static string password = "1234";
}
public static string StrCon
{
    get { return $"Data Source ={server}; Integrated Security=false;Initial Catalog={dataBase}; " +
            $"User ID={user}; Password={password}"; }
}
}
