namespace AlienCell.Server.DB
{

public class DBConnectionOptions
{
    public string Host { get; set; }
    public string Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Database { get; set; }

    public string ConnectionString
    {
        get => $"server={this.Host};uid={this.Username};pwd={this.Password};database={this.Database}";
    }
}

}

