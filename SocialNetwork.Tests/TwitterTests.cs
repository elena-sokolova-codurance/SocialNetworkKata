using Moq;

namespace SocialNetwork.Tests;

public class TwitterTests
{
    [Fact]
    public void ShouldSendCommandToParser()
    {
        var console = new Mock<Output>();
        var parser = new Mock<Parser>();
        var twitter = new Twitter(console.Object, parser.Object);

        var userName = "Alice";
        var message = "I love the weather today";
        var command = $"{userName} -> {message}";
        var parsedCommand = new Command(userName, CommandType.Post, message);

        
        parser.Setup(x => x.ParseCommand(command)).Returns(parsedCommand);
        twitter.SendCommand(command);
        
        parser.Verify(v => v.ParseCommand(command));
    }
}