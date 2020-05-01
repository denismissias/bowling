namespace bowling.Domain
{
    public class Game
    {
        private readonly int[] throws = new int[21];
        private int currentThrow;

        public int Score { get; set; }

        public void Add(int pins)
        {
            throws[currentThrow++] = pins;
            Score += pins;
        }

        public int ScoreForFrame(int theFrame)
        {
            int ball = 0;
            int score = 0;

            for (int currentFrame = 0; currentFrame < theFrame; currentFrame++)
            {
                int firstThrow = throws[ball++];
                int secondThrow = throws[ball++];

                int frameScore = firstThrow + secondThrow;

                if (frameScore == 10)
                    score += frameScore + throws[ball++];
                else
                    score += frameScore;
            }

            return score;
        }
    }
}
