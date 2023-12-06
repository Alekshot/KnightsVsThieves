using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

[TestFixture]
public class Tests
{

    // ���� ��� ��������, �� ���������� ������'� ��� ������� ����� 1
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

    // ���� ��� ��������, �� ��������� ���������� ������'� ��� ������� ����� 1
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
