// test testme.cs
using System;
namespace test;

{
    
}
using FluentAssertions;
using Moq;
using AutoFixture;
using testme;

public class test
{
    [Fact]

    public void oneplusoneshouldreturntwo()
    {
        var a = new A();
        var result = a.f1(1);
        result.Should().Be(2);
    }

    [Fact]

    public void twoplustwoshouldreturnfour()
    {
        var a = new A();
        var result = a.f2(2);
        result.Should().Be(4);
    }

    [Fact] 

    public void threeplusthreeshouldreturnsix()
    {
        var a = new A();
        var result = a.f3(3);
        result.Should().Be(6);
    }

    [Fact]

    public void fourplusfourshouldreturneight()
    {
        var a = new A();
        var result = a.f4(4);
        result.Should().Be(8);
    }   

    [Fact]

    public void fivedividedbytwoshouldreturntwoandahalf()
    {
        var a = new A();
        var result = a.f5(5,2);
        result.Should().Be(2.5);
    }

    [Fact]
    public void sixplusfiveshouldreturneleven()
    {
        var a = new A();
        var result = a.f6(6);
        result.Should().Be(11);
    }

    [Fact]
    public void sevenplusmorestuffshouldreturnsevenplusmorestuff()
    {
        var a = new A();
        var result = a.f7("seven plus");
        result.Should().Be("seven plus more stuff");
    }

    [Fact]
    public void eightpluseightshouldreturnsixteen()
    {
        var a = new A();
        var result = a.f8(8);
        result.Should().Be(16);
    }


}