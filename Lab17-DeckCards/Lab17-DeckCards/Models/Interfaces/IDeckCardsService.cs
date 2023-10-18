namespace Lab17_DeckCards.Models.Interfaces;

public interface IDeckCardsService
{
    Task<string> CreateNewDeckAsync();
    Task<List<Card>> GetCardsAsync(string deckId);
}