namespace SocialNetwork;

public class Repository
{
    private Dictionary<string, List<string>> _storage = new();

    public virtual void SaveMessage(string userName, string message)
    {
        var currentMessages = _storage[userName];
        if (currentMessages == null)
        {
            currentMessages = new List<string>();
        }
        currentMessages.Add(message);
        _storage[userName] = currentMessages;
    }

    public List<string> ReadMessagesFromUser(string userName)
    {
        return _storage[userName];
    }
}