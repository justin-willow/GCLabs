﻿namespace Lab17_DeckCards.Models;

public class DrawDeckResponse
{
    public bool success { get; set; }
    public string deck_id { get; set; }
    public List<Card> cards { get; set; }
    public int remaining { get; set; }
}