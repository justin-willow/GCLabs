using Lab17_DeckCards.Models.Interfaces;
using static System.Net.WebRequestMethods;

namespace Lab17_DeckCards.Models;

public class DeckCardsService : IDeckCardsService
{
    //Make a call to the API to generate a new deck. Capture the deck ID returned.
    //https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1


    public async Task<string> CreateNewDeckAsync()
    {
        string apiUrl = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
        using (HttpClient client = new HttpClient())
        {
            try
            {
                GenerateDeckResponse generateDeckResponse = await client.GetFromJsonAsync<GenerateDeckResponse>(apiUrl);

                if (generateDeckResponse == null)
                {
                    return null;
                }
                return generateDeckResponse.deck_id;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }
        return null;
    }

    //Draw 5 cards from the deck
    //https://deckofcardsapi.com/api/deck/<<deck_id>>/draw/?count=2
    public async Task<List<Card>> GetCardsAsync(string deckId)
    {
        string apiUrl = $"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count=5";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                DrawDeckResponse drawDeckResponse = await client.GetFromJsonAsync<DrawDeckResponse>(apiUrl);

                return drawDeckResponse.cards;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return null;
    }
}