﻿namespace Lab17_DeckCards.Models;

public class GenerateDeckResponse
{
    public bool success { get; set; }
    public string deck_id { get; set; }
    public int remaining { get; set; }
    public bool shuffled { get; set; }
}
