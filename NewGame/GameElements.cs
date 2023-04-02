namespace NewGame
{
    public class GameElements
    {
        public string nickname { get; set; }

        private float balance;
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public float factor { get; set; } = 1f;

        public bool IsUpgrade1Bought { get; set; }
        public bool IsUpgrade2Bought { get; set; }
        public bool IsUpgrade3Bought { get; set; }
    }
}
