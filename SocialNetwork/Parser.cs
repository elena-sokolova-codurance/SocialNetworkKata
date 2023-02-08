namespace SocialNetwork;

public class Parser
{
    
    public virtual Command ParseCommand(string postingStr)
    {
        if (postingStr.Contains("->"))
        {
            var userName = postingStr.Substring(0, postingStr.IndexOf(" "));
            var message = postingStr.Substring(postingStr.IndexOf(">") + 2);

            return new Command(userName, CommandType.Post, message);
        }

        return new Command(postingStr, CommandType.Read);

    }
}