namespace SocialNetwork;

public class Parser
{
    
    public virtual Command ParseCommand(string postingStr)
    {
        var userName = postingStr.Substring(0, postingStr.IndexOf(" "));
        var message = postingStr.Substring(postingStr.IndexOf(">") + 2);

        return new Command(userName, CommandType.Post, message);


    }
}