﻿namespace CryptonightProfitSwitcher
{
    public class Coin : Mineable
    {
        public string TickerSymbol { get; set; }
        public override string Id => TickerSymbol;
    }
}