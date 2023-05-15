
[TestFixture]
public class Tests
{
    [Test]
    public void Test()
    {
        Assert.That(Kata.Solution(10), Is.EqualTo(23));
    }
}