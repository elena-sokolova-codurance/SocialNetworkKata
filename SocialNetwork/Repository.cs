namespace SocialNetwork;

public class Repository
{
    private Dictionary<string, List<string>> _storage = new();

    public virtual void SaveMessage(string userName, string message)
    {
        var currentMessages = new List<string>();
        if (_storage.ContainsKey(userName))
        {
            currentMessages = _storage[userName];

        }
        currentMessages.Add(message);
        _storage[userName] = currentMessages;
    }

    public virtual List<string> ReadMessagesFromUser(string userName)
    {
        return _storage[userName];
    }
}