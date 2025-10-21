using Domain.Models;
using FluentAssertions;

namespace Domain.Tests;

public class EventTests
{
    private const string _validTitle = "Valid Event Title";
    private const string _validDescription = "Valid event description";
    private const string _validLocation = "Valid Location";
    private const int _validCapacity = 50;
    private readonly DateTime _futureDate = DateTime.UtcNow.AddDays(7);
    private readonly Guid _organizerId = Guid.NewGuid();

    #region Helper Methods

    private Event CreateValidEvent()
    {
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            _futureDate,
            _validLocation,
            true,
            _validCapacity);

        return result.Value;
    }

    #endregion

    #region Create Tests

    [Fact]
    public void Create_ValidData_ReturnsSuccessResult()
    {
        // Arrange

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            _futureDate,
            _validLocation,
            true,
            _validCapacity);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
        result.Value.Title.Should().Be(_validTitle);
        result.Value.Description.Should().Be(_validDescription);
        result.Value.Date.Should().Be(_futureDate);
        result.Value.Location.Should().Be(_validLocation);
        result.Value.Capacity.Should().Be(_validCapacity);
        result.Value.IsPublic.Should().BeTrue();
        result.Value.OrganizerId.Should().Be(_organizerId);
    }

    [Fact]
    public void Create_NullCapacity_ReturnsSuccessResult()
    {
        // Arrange
        int? capacity = null;

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            _futureDate,
            _validLocation,
            true,
            capacity);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Capacity.Should().BeNull();
    }

    [Fact]
    public void Create_EmptyTitle_ReturnsFailureResult()
    {
        // Arrange
        var emptyTitle = string.Empty;

        // Act
        var result = Event.Create(
            _organizerId,
            emptyTitle,
            _validDescription,
            _futureDate,
            _validLocation,
            true);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_WhitespaceTitle_ReturnsFailureResult()
    {
        // Arrange
        var whitespaceTitle = "   ";

        // Act
        var result = Event.Create(
            _organizerId,
            whitespaceTitle,
            _validDescription,
            _futureDate,
            _validLocation,
            true);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_TitleExceedsMaxLength_ReturnsFailureResult()
    {
        // Arrange
        var longTitle = new string('a', Event.TitleMaxLength + 1);

        // Act
        var result = Event.Create(
            _organizerId,
            longTitle,
            _validDescription,
            _futureDate,
            _validLocation,
            true);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_TitleAtMaxLength_ReturnsSuccessResult()
    {
        // Arrange
        var maxLengthTitle = new string('a', Event.TitleMaxLength);

        // Act
        var result = Event.Create(
            _organizerId,
            maxLengthTitle,
            _validDescription,
            _futureDate,
            _validLocation,
            true);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Title.Should().HaveLength(Event.TitleMaxLength);
    }

    [Fact]
    public void Create_DescriptionExceedsMaxLength_ReturnsFailureResult()
    {
        // Arrange
        var longDescription = new string('a', Event.DescriptionMaxLength + 1);

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            longDescription,
            _futureDate,
            _validLocation,
            true);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_DescriptionAtMaxLength_ReturnsSuccessResult()
    {
        // Arrange
        var maxLengthDescription = new string('a', Event.DescriptionMaxLength);

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            maxLengthDescription,
            _futureDate,
            _validLocation,
            true);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Description.Should().HaveLength(Event.DescriptionMaxLength);
    }

    [Fact]
    public void Create_PastDate_ReturnsFailureResult()
    {
        // Arrange
        var pastDate = DateTime.UtcNow.AddDays(-1);

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            pastDate,
            _validLocation,
            true);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_EmptyLocation_ReturnsFailureResult()
    {
        // Arrange
        var emptyLocation = string.Empty;

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            _futureDate,
            emptyLocation,
            true);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_WhitespaceLocation_ReturnsFailureResult()
    {
        // Arrange
        var whitespaceLocation = "   ";

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            _futureDate,
            whitespaceLocation,
            true);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_LocationExceedsMaxLength_ReturnsFailureResult()
    {
        // Arrange
        var longLocation = new string('a', Event.LocationMaxLength + 1);

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            _futureDate,
            longLocation,
            true);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_LocationAtMaxLength_ReturnsSuccessResult()
    {
        // Arrange
        var maxLengthLocation = new string('a', Event.LocationMaxLength);

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            _futureDate,
            maxLengthLocation,
            true);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Location.Should().HaveLength(Event.LocationMaxLength);
    }

    [Fact]
    public void Create_NegativeCapacity_ReturnsFailureResult()
    {
        // Arrange
        var capacity = -5;

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            _futureDate,
            _validLocation,
            true,
            capacity);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_ZeroCapacity_ReturnsFailureResult()
    {
        // Arrange
        var capacity = 0;

        // Act
        var result = Event.Create(
            _organizerId,
            _validTitle,
            _validDescription,
            _futureDate,
            _validLocation,
            true,
            capacity);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    #endregion

    #region UpdateTitle Tests

    [Fact]
    public void UpdateTitle_ValidTitle_ReturnsSuccessAndUpdatesTitle()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var newTitle = "Updated Title";

        // Act
        var result = eventInstance.UpdateTitle(newTitle);

        // Assert
        result.IsSuccess.Should().BeTrue();
        eventInstance.Title.Should().Be(newTitle);
    }

    [Fact]
    public void UpdateTitle_EmptyTitle_ReturnsFailureAndDoesNotUpdate()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var originalTitle = eventInstance.Title;

        // Act
        var result = eventInstance.UpdateTitle(string.Empty);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
        eventInstance.Title.Should().Be(originalTitle);
    }

    [Fact]
    public void UpdateTitle_TitleExceedsMaxLength_ReturnsFailureAndDoesNotUpdate()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var originalTitle = eventInstance.Title;
        var longTitle = new string('a', Event.TitleMaxLength + 1);

        // Act
        var result = eventInstance.UpdateTitle(longTitle);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
        eventInstance.Title.Should().Be(originalTitle);
    }

    #endregion

    #region UpdateDescription Tests

    [Fact]
    public void UpdateDescription_ValidDescription_ReturnsSuccessAndUpdatesDescription()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var newDescription = "Updated description";

        // Act
        var result = eventInstance.UpdateDescription(newDescription);

        // Assert
        result.IsSuccess.Should().BeTrue();
        eventInstance.Description.Should().Be(newDescription);
    }

    [Fact]
    public void UpdateDescription_DescriptionExceedsMaxLength_ReturnsFailureAndDoesNotUpdate()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var originalDescription = eventInstance.Description;
        var longDescription = new string('a', Event.DescriptionMaxLength + 1);

        // Act
        var result = eventInstance.UpdateDescription(longDescription);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
        eventInstance.Description.Should().Be(originalDescription);
    }

    [Fact]
    public void UpdateDescription_EmptyDescription_ReturnsSuccess()
    {
        // Arrange
        var eventInstance = CreateValidEvent();

        // Act
        var result = eventInstance.UpdateDescription(string.Empty);

        // Assert
        result.IsSuccess.Should().BeTrue();
        eventInstance.Description.Should().Be(string.Empty);
    }

    #endregion

    #region UpdateDate Tests

    [Fact]
    public void UpdateDate_FutureDate_ReturnsSuccessAndUpdatesDate()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var newDate = DateTime.UtcNow.AddDays(30);

        // Act
        var result = eventInstance.UpdateDate(newDate);

        // Assert
        result.IsSuccess.Should().BeTrue();
        eventInstance.Date.Should().Be(newDate);
    }

    [Fact]
    public void UpdateDate_PastDate_ReturnsFailureAndDoesNotUpdate()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var originalDate = eventInstance.Date;
        var pastDate = DateTime.UtcNow.AddDays(-1);

        // Act
        var result = eventInstance.UpdateDate(pastDate);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
        eventInstance.Date.Should().Be(originalDate);
    }

    #endregion

    #region UpdateLocation Tests

    [Fact]
    public void UpdateLocation_ValidLocation_ReturnsSuccessAndUpdatesLocation()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var newLocation = "New Location";

        // Act
        var result = eventInstance.UpdateLocation(newLocation);

        // Assert
        result.IsSuccess.Should().BeTrue();
        eventInstance.Location.Should().Be(newLocation);
    }

    [Fact]
    public void UpdateLocation_EmptyLocation_ReturnsFailureAndDoesNotUpdate()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var originalLocation = eventInstance.Location;

        // Act
        var result = eventInstance.UpdateLocation(string.Empty);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
        eventInstance.Location.Should().Be(originalLocation);
    }

    [Fact]
    public void UpdateLocation_LocationExceedsMaxLength_ReturnsFailureAndDoesNotUpdate()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var originalLocation = eventInstance.Location;
        var longLocation = new string('a', Event.LocationMaxLength + 1);

        // Act
        var result = eventInstance.UpdateLocation(longLocation);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
        eventInstance.Location.Should().Be(originalLocation);
    }

    #endregion

    #region UpdateCapacity Tests

    [Fact]
    public void UpdateCapacity_ValidCapacity_ReturnsSuccessAndUpdatesCapacity()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var newCapacity = 100;

        // Act
        var result = eventInstance.UpdateCapacity(newCapacity);

        // Assert
        result.IsSuccess.Should().BeTrue();
        eventInstance.Capacity.Should().Be(newCapacity);
    }

    [Fact]
    public void UpdateCapacity_NullCapacity_ReturnsSuccessAndUpdatesCapacity()
    {
        // Arrange
        var eventInstance = CreateValidEvent();

        // Act
        var result = eventInstance.UpdateCapacity(null);

        // Assert
        result.IsSuccess.Should().BeTrue();
        eventInstance.Capacity.Should().BeNull();
    }

    [Fact]
    public void UpdateCapacity_NegativeCapacity_ReturnsFailureAndDoesNotUpdate()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var originalCapacity = eventInstance.Capacity;

        // Act
        var result = eventInstance.UpdateCapacity(-10);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
        eventInstance.Capacity.Should().Be(originalCapacity);
    }

    [Fact]
    public void UpdateCapacity_ZeroCapacity_ReturnsFailureAndDoesNotUpdate()
    {
        // Arrange
        var eventInstance = CreateValidEvent();
        var originalCapacity = eventInstance.Capacity;

        // Act
        var result = eventInstance.UpdateCapacity(0);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
        eventInstance.Capacity.Should().Be(originalCapacity);
    }

    #endregion

    #region UpdateVisibility Tests

    [Fact]
    public void UpdateVisibility_SetToPublic_ReturnsSuccessAndUpdatesVisibility()
    {
        // Arrange
        var eventInstance = CreateValidEvent();

        // Act
        var result = eventInstance.UpdateVisibility(true);

        // Assert
        result.IsSuccess.Should().BeTrue();
        eventInstance.IsPublic.Should().BeTrue();
    }

    [Fact]
    public void UpdateVisibility_SetToPrivate_ReturnsSuccessAndUpdatesVisibility()
    {
        // Arrange
        var eventInstance = CreateValidEvent();

        // Act
        var result = eventInstance.UpdateVisibility(false);

        // Assert
        result.IsSuccess.Should().BeTrue();
        eventInstance.IsPublic.Should().BeFalse();
    }

    #endregion
}