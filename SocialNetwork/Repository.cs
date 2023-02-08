namespace SocialNetwork;

public class Repository
{
    
    public virtual void SaveMessage(string userName, string message)
    {
        throw new NotImplementedException();
    }

    public List<string> ReadMessagesFromUser(string userName)
    {
        return null;
    }
}