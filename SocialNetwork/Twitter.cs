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
        
        if(parsedCommand.CommandType == CommandType.Post)
            _repository.SaveMessage(parsedCommand.UserName, parsedCommand.Message);

        if (parsedCommand.CommandType == CommandType.Read)
        {
            var messages = _repository.ReadMessagesFromUser(parsedCommand.UserName);
            if(messages.Count > 0)
                _consoleObject.PrintLn(messages[0]);
        }

    }
}
