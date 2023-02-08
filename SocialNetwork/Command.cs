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

    protected bool Equals(Command other)
    {
        return UserName == other.UserName && CommandType == other.CommandType && Message == other.Message;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Command)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(UserName, (int)CommandType, Message);
    }
}

public enum CommandType
{
    Post,
    Read,
    Follow,
    Wall
}

