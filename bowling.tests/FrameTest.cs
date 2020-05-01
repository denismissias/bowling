using bowling.domain;
using NUnit.Framework;

namespace bowling.tests
{
    public class FrameTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestScoreNoThrows()
        {
            Frame frame = new Frame();
            Assert.AreEqual(0, frame.Score);
        }

        [Test]
        public void TestAddOneThrow()
        {
            Frame frame = new Frame();
            frame.Add(5);
            Assert.AreEqual(5, frame.Score);
        }
    }
}
