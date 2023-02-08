using Moq;

namespace SocialNetwork.Tests;

public class SocialNetworkTest
{
    [Fact]
    public void ShouldPostMessage()
    {
        var console = new Mock<Output>();
        
        //Given: Alice
        
        // When she send "I love the weather today"
        var postingStr = "Alice -> I love the weather today";
        console.Object.SendCommand(postingStr);
        // And Bob ask for Alice's message

        var readingStr = "Alice";
        console.Object.SendCommand(readingStr);
        
        // Then Bob can read Alice message "I love the weather today"
        var expectedResult = "I love the weather today";
        console.Verify(v => v.PrintLn(expectedResult));
    }
}