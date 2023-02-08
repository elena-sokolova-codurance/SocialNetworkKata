namespace SocialNetwork;

public class Twitter
{
    private readonly Output _consoleObject;
    private readonly Parser _parser;
    private readonly Repository _repository;


    public Twitter(Output consoleObject, Parser parser, Repository repository)
    {
        _consoleObject = consoleObject;
        _parser = parser;
        _repository = repository;
    }

    public void SendCommand(string postingStr)
    {
        var parsedCommand = _parser.ParseCommand(postingStr);
        _repository.SaveMessage(parsedCommand.UserName, parsedCommand.Message);
    }
}
