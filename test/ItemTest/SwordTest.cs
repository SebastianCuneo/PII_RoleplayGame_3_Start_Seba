using NUnit.Framework;
using Ucu.Poo.RoleplayGame;
namespace Library.Tests;


public class SwordTests
{

    private Sword sword;


    [SetUp]
    public void SetUp()

    {

        sword = new Sword();

    }


    [Test]
    public void DefenseValue_ShouldReturnCorrectValue()

    {
        // Arrange
        int expectedDefenseValue = 25;

        // Act
        int actualDefenseValue = sword.DefenseValue;

        // Assert
        Assert.That(actualDefenseValue, Is.EqualTo(expectedDefenseValue));

    }
} 