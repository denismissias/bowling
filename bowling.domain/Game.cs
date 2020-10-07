using System;

namespace bowling.domain
{
    public class Game
    {
        private bool isFirstThrow = true;
        private readonly Scorer scorer = new Scorer();
        
        public int Score
        {
            get
            {
                return GetScoreForFrame(CurrentFrame);
            }
        }

        public int CurrentFrame { get; private set; }

        public void Add(int pins)
        {
            scorer.AddThrow(pins);
            AdjustCurrentFrame(pins);
        }

        private void AdjustCurrentFrame(int pins)
        {
            if (LastBallInFrame(pins))
                AdvanceFrame();
            else
                isFirstThrow = false;
        }

        private bool LastBallInFrame(int pins)
        {
            return Strike(pins) || (!isFirstThrow);
        }

        private bool Strike(int pins)
        {
            return isFirstThrow && pins == 10;
        }

        private void AdvanceFrame()
        {
            CurrentFrame++;

            if (CurrentFrame > 10)
                CurrentFrame = 10;
        }

        public int GetScoreForFrame(int theFrame)
        {
            return scorer.GetScoreForFrame(theFrame);
        }
    }
}
