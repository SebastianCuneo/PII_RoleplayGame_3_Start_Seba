using NUnit.Framework;
using Ucu.Poo.RoleplayGame;
namespace Library.Tests;


public class AxeTests
{

    private Axe axe;


    [SetUp]
    public void SetUp()

    {

        axe = new Axe();

    }


    [Test]
    public void DefenseValue_ShouldReturnCorrectValue()

    {
        // Arrange
        int expectedDefenseValue = 25;

        // Act
        int actualDefenseValue = axe.DefenseValue;

        // Assert
        Assert.That(actualDefenseValue, Is.EqualTo(expectedDefenseValue));

    }
} 