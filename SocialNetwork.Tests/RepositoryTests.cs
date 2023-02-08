namespace SocialNetwork.Tests;

public class RepositoryTests
{
    [Fact]
    public void ShouldReadPostedMessageFromAlice()
    {
        var userName = "Alice";
        var message = "I love the weather today";
        var repository = new Repository();
        repository.SaveMessage(userName, message);
        var resultMessages = repository.ReadMessagesFromUser(userName);

        Assert.Equal(message, resultMessages[0]);
    }
}