namespace RockPaperScissorsApp.Helpers
{
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LosesAgainst { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgaints(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
            {
                return GameStatus.Draw;
            } else if (LosesAgainst == opponentHand.Selection)
            {
                return GameStatus.Loss;
            } else //(WinsAgainst == opponentHand.Selection)
            {
                return GameStatus.Victory;
            }
        }
    }
}