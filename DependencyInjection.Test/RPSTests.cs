using RockPaperScissorsGame;
namespace DependencyInjection.Test
{
    public class RPSTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RockBeatsScissors()
        {
            GameManager gm = new GameManager(new ForcedPlayer(Choice.Rock), new ForcedPlayer(Choice.Scissors));
            Assert.AreEqual(GameStatus.Player1Wins, gm.PlayRound());
        }
    }
}