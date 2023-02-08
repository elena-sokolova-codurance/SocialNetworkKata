using System.Data;

namespace SocialNetwork.Tests;

public class ParserTests
{
    [Fact]
    public void ShouldParsePostCommandStr()
    {
        var parser = new Parser();
        var userName = "Alice";
        var message = "I love the weather today";
        var commandStr = $"{userName} -> {message}";
        var expectedCommand = new Command(userName, CommandType.Post, message);
        
        var parsedCommand = parser.ParseCommand(commandStr);
        
        Assert.Equal(expectedCommand, parsedCommand);


    }
}