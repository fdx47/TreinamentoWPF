namespace TreinamentoWPF;

public class AppSettings
{
    public ConnectionStrings ConnectionStrings { get; set; }
}
public class ConnectionStrings
{
    public ConnectionStringDetails DefaultConnection { get; set; }
}

public class ConnectionStringDetails
{
    public string Conn { get; set; }
}
