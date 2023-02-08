namespace SocialNetwork;

public class Command
{
    public string UserName;
    public CommandType CommandType;
    public string Message;
    
    public Command(string userName, CommandType commandType, string message = "")
    {
        UserName = userName;
        CommandType = commandType;
        Message = message;
    }
    
}

public enum CommandType
{
    Post,
    Read,
    Follow,
    Wall
}

