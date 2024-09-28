// File: MyWebApi.Tests/UnitTest1.cs
using MyProject.API.Services;
using Xunit;

public class UnitTest1
{
    private readonly MathService _mathService;

    public UnitTest1()
    {
        // Arrange: Initialize the service to be tested
        _mathService = new MathService();
    }

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        // Act
        int result = _mathService.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct()
    {
        // Act
        int result = _mathService.Multiply(2, 3);

        // Assert
        Assert.Equal(6, result);
    }
}
