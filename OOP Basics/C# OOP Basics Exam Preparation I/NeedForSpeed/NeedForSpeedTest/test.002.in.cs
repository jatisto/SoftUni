﻿using NUnit.Framework;
using System;

[TestFixture]
public class T02TestOpenParticipateStartMethods
{
    private Type sut = typeof(CarManager);
    private object[] carDetails = new object[] { 1, "Performance", "BMW", "M3", 1992, 200, 5, 100, 100 };
    private object[] raceDetails = new object[] { 1, "Casual", 1000, "Dragon", 100 };
    private string expectedOutput = "Dragon - 1000\r\n" + "1. BMW M3 235PP - $50";

    [Test]
    public void TestMethod()
    {
        var register = sut.GetMethod("Register");
        var open = sut.GetMethod("Open", new Type[] { typeof(int), typeof(string), typeof(int), typeof(string), typeof(int) });
        var participate = sut.GetMethod("Participate");
        var start = sut.GetMethod("Start");
        var manager = new CarManager();

        register.Invoke(manager, carDetails);
        open.Invoke(manager, raceDetails);
        participate.Invoke(manager, new object[] { 1, 1 });
        var actualOutput = start.Invoke(manager, new object[] { 1 });
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}