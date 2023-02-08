using Moq;

namespace SocialNetwork.Tests;

public class SocialNetworkTest
{
    [Fact]
    public void ShouldPostMessage()
    {
        var console = new Mock<Output>();
        var twitter = new Twitter(console.Object);
        
        //Given: Alice as sent "I love the weather today"
        var postingStr = "Alice -> I love the weather today";
        twitter.SendCommand(postingStr);
        
        //When Bob ask for Alice's message
        var readingStr = "Alice";
        twitter.SendCommand(readingStr);
        
        //Then Bob can read Alice message "I love the weather today"
        var expectedResult = "I love the weather today";
        console.Verify(v => v.PrintLn(expectedResult));
    }
}