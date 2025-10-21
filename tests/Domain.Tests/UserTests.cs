using Domain.Models;
using FluentAssertions;

namespace Domain.Tests;

public class UserTests
{
    private const string _validFirstName = "John";
    private const string _validLastName = "Doe";
    private const string _validEmail = "john.doe@example.com";
    private const string _validPasswordHash = "hashed_password_12345";

    #region Helper Methods

    private User CreateValidUser()
    {
        var result = User.Create(
            _validFirstName,
            _validLastName,
            _validEmail,
            _validPasswordHash);

        return result.Value;
    }

    #endregion

    #region Create Tests

    [Fact]
    public void Create_ValidData_ReturnsSuccessResult()
    {
        // Arrange

        // Act
        var result = User.Create(
            _validFirstName,
            _validLastName,
            _validEmail,
            _validPasswordHash);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
        result.Value.FirstName.Should().Be(_validFirstName);
        result.Value.LastName.Should().Be(_validLastName);
        result.Value.Email.Should().Be(_validEmail);
        result.Value.PasswordHash.Should().Be(_validPasswordHash);
    }

    [Fact]
    public void Create_EmptyFirstName_ReturnsFailureResult()
    {
        // Arrange
        var emptyFirstName = string.Empty;

        // Act
        var result = User.Create(
            emptyFirstName,
            _validLastName,
            _validEmail,
            _validPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_WhitespaceFirstName_ReturnsFailureResult()
    {
        // Arrange
        var whitespaceFirstName = "   ";

        // Act
        var result = User.Create(
            whitespaceFirstName,
            _validLastName,
            _validEmail,
            _validPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_FirstNameExceedsMaxLength_ReturnsFailureResult()
    {
        // Arrange
        var longFirstName = new string('a', User.FirstNameMaxLength + 1);

        // Act
        var result = User.Create(
            longFirstName,
            _validLastName,
            _validEmail,
            _validPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_FirstNameAtMaxLength_ReturnsSuccessResult()
    {
        // Arrange
        var maxLengthFirstName = new string('a', User.FirstNameMaxLength);

        // Act
        var result = User.Create(
            maxLengthFirstName,
            _validLastName,
            _validEmail,
            _validPasswordHash);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.FirstName.Should().HaveLength(User.FirstNameMaxLength);
    }

    [Fact]
    public void Create_EmptyLastName_ReturnsFailureResult()
    {
        // Arrange
        var emptyLastName = string.Empty;

        // Act
        var result = User.Create(
            _validFirstName,
            emptyLastName,
            _validEmail,
            _validPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_WhitespaceLastName_ReturnsFailureResult()
    {
        // Arrange
        var whitespaceLastName = "   ";

        // Act
        var result = User.Create(
            _validFirstName,
            whitespaceLastName,
            _validEmail,
            _validPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_LastNameExceedsMaxLength_ReturnsFailureResult()
    {
        // Arrange
        var longLastName = new string('a', User.LastNameMaxLength + 1);

        // Act
        var result = User.Create(
            _validFirstName,
            longLastName,
            _validEmail,
            _validPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_LastNameAtMaxLength_ReturnsSuccessResult()
    {
        // Arrange
        var maxLengthLastName = new string('a', User.LastNameMaxLength);

        // Act
        var result = User.Create(
            _validFirstName,
            maxLengthLastName,
            _validEmail,
            _validPasswordHash);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.LastName.Should().HaveLength(User.LastNameMaxLength);
    }

    [Fact]
    public void Create_EmptyEmail_ReturnsFailureResult()
    {
        // Arrange
        var emptyEmail = string.Empty;

        // Act
        var result = User.Create(
            _validFirstName,
            _validLastName,
            emptyEmail,
            _validPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_WhitespaceEmail_ReturnsFailureResult()
    {
        // Arrange
        var whitespaceEmail = "   ";

        // Act
        var result = User.Create(
            _validFirstName,
            _validLastName,
            whitespaceEmail,
            _validPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_EmailExceedsMaxLength_ReturnsFailureResult()
    {
        // Arrange
        var longEmail = new string('a', User.EmailMaxLength + 1);

        // Act
        var result = User.Create(
            _validFirstName,
            _validLastName,
            longEmail,
            _validPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_EmailAtMaxLength_ReturnsSuccessResult()
    {
        // Arrange
        var maxLengthEmail = new string('a', User.EmailMaxLength);

        // Act
        var result = User.Create(
            _validFirstName,
            _validLastName,
            maxLengthEmail,
            _validPasswordHash);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Email.Should().HaveLength(User.EmailMaxLength);
    }

    [Fact]
    public void Create_EmptyPasswordHash_ReturnsFailureResult()
    {
        // Arrange
        var emptyPasswordHash = string.Empty;

        // Act
        var result = User.Create(
            _validFirstName,
            _validLastName,
            _validEmail,
            emptyPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_WhitespacePasswordHash_ReturnsFailureResult()
    {
        // Arrange
        var whitespacePasswordHash = "   ";

        // Act
        var result = User.Create(
            _validFirstName,
            _validLastName,
            _validEmail,
            whitespacePasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_PasswordHashExceedsMaxLength_ReturnsFailureResult()
    {
        // Arrange
        var longPasswordHash = new string('a', User.PasswordHashMaxLength + 1);

        // Act
        var result = User.Create(
            _validFirstName,
            _validLastName,
            _validEmail,
            longPasswordHash);

        // Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }

    [Fact]
    public void Create_PasswordHashAtMaxLength_ReturnsSuccessResult()
    {
        // Arrange
        var maxLengthPasswordHash = new string('a', User.PasswordHashMaxLength);

        // Act
        var result = User.Create(
            _validFirstName,
            _validLastName,
            _validEmail,
            maxLengthPasswordHash);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.PasswordHash.Should().HaveLength(User.PasswordHashMaxLength);
    }

    #endregion
}

