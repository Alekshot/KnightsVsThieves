using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

[TestFixture]
public class Tests
{

    // Тест для перевірки, чи втрачається здоров'я при значенні менше 1
    [Test]
    public void LoseHealthBelowOne()
    {
        // Arrange
        int initialHealth = 0;

        // Act
        int result = LoseHealth(initialHealth);

        // Assert
        Assert.AreEqual(initialHealth, result);
    }

    // Тест для перевірки, чи правильно зменшується здоров'я при значенні більше 1
    [Test]
    public void LoseHealthAboveOne()
    {
        // Arrange
        int initialHealth = 5;

        // Act
        int result = LoseHealth(initialHealth);

        // Assert
        Assert.AreEqual(initialHealth - 1, result);
    }

    [Test]
    public void TestsSimplePasses()
    {
        // Arrange
        int initialHealth = 10;

        // Act
        int result = LoseHealth(initialHealth);

        // Assert
        Assert.AreEqual(initialHealth - 1, result);
    }


    [UnityTest]
    public IEnumerator TestsWithEnumeratorPasses()
    {

        yield return null;
    }
    int LoseHealth(int healthCount)
    {
        if (healthCount < 1)
            return healthCount;

        return healthCount - 1;
    }
}
