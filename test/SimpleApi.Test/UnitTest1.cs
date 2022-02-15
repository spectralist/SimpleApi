using Xunit;
using SampleApi.Controllers;

namespace SampleApi.Test;

public class UnitTest1
{
    ValueController controller = new ValueController();
    [Fact]
      public void GetName(){


    var retValue = controller.Get(1);
    Assert.Equal("koujal",retValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}