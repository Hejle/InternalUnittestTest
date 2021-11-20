using System;
using System.Collections.Generic;
using System.Reflection;
using InternalUnittestTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InternalUnittestTestTests;

[TestClass]
public class UnitTest1
{
    [DataTestMethod]
    [TestData]
    public void TestMethod1(Person person)
    {
        Assert.AreEqual("Jens", person.Name);
        Assert.AreEqual(34, person.Age);
        Assert.AreEqual(35, person.InternalAge);
    }
}

internal class TestDataAttribute : Attribute, ITestDataSource
{
    public IEnumerable<object[]> GetData(MethodInfo methodInfo)
    {
        var person = new Person { Age = 34, Name = "Jens", InternalAge = 35};
        return new List<object[]>
        {
            new object[] { person }
        };
    }

    public string GetDisplayName(MethodInfo methodInfo, object[] data)
    {
        return $"{methodInfo.Name}";
    }
}