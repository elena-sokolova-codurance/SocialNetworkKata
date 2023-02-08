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
        var command = "I love the weather today";
        var parsedCommand = new Command();

        parser.Setup(x => x.ParseCommand(command)).Returns(parsedCommand);
        twitter.SendCommand(command);
        
        parser.Verify(v => v.ParseCommand(command));
    }
}