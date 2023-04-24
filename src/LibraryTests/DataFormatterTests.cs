using TestDateFormat;
using NUnit.Framework;

namespace TestDateFormat;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCorrectDateFormat()
    {
        const string input = "10/11/1990";
        const string expected = "1990-11-10";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestLongerLenghtDate()
    {
        const string input = "10/11/19900";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestShorterLenghtDate()
    {
        const string input = "10/11/199";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestEmptyDate()
    {
        const string input = "";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestWrongSeparator()
    {
        const string input = "10-11-1990";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

}