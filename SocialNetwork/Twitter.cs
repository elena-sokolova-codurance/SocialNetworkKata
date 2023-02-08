namespace SocialNetwork;

public class Twitter
{
    private readonly Output _consoleObject;
    private readonly Parser _parser;


    public Twitter(Output consoleObject, Parser parser)
    {
        _consoleObject = consoleObject;
        _parser = parser;
    }

    public void SendCommand(string postingStr)
    {
        var userName = _parser.ParseCommand(postingStr);
    }
}
