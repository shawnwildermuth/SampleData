using Microsoft.EntityFrameworkCore;
using WilderMinds.SampleData.Bechdel;

namespace WilderMinds.SampleData.Tests
{
  public class BechdelTests
  {
    [Fact]
    public void CanBuildContext()
    {
      var options = new DbContextOptionsBuilder<BechdelContext>()
          .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
          .Options;

      var ctx = new BechdelContext(options);

    }

    [Fact]
    public void CanGetFilms()
    {
      var options = new DbContextOptionsBuilder<BechdelContext>()
          .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
          .Options;

      var ctx = new BechdelContext(options);

      ctx.Database.EnsureCreated();

      var results = ctx.Films.ToList();

      Assert.True(results.Count() > 0);
    }
  }
}