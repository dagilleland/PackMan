using Moq;
using PackMan.Telemetry;
using Xunit;

public class UpdateCheckerTests
{
    [Fact]
    public void CheckForUpdates_ReturnsTrue_WhenNewerVersionIsAvailable()
    {
        // Arrange
        string currentVersion = "1.0.0";
        var mockUpdateChecker = new Mock<IUpdateChecker>();
        mockUpdateChecker
            .Setup(x => x.CheckForUpdates("myusername", "myrepository", currentVersion))
            .Returns(true);

        // Act
        bool updateAvailable = mockUpdateChecker.Object.CheckForUpdates("myusername", "myrepository", currentVersion);

        // Assert
        Assert.True(updateAvailable);
    }

    [Fact]
    public void CheckForUpdates_ReturnsFalse_WhenNoNewerVersionIsAvailable()
    {
        // Arrange
        string currentVersion = "2.0.0";
        var mockUpdateChecker = new Mock<IUpdateChecker>();
        mockUpdateChecker
            .Setup(x => x.CheckForUpdates("myusername", "myrepository", currentVersion))
            .Returns(false);

        // Act
        bool updateAvailable = mockUpdateChecker.Object.CheckForUpdates("myusername", "myrepository", currentVersion);

        // Assert
        Assert.False(updateAvailable);
    }
}
