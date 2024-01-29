using System.Collections.Generic;
using System;
using TelegramBotTest_2.Game;
using System.Linq;

public class Moves
{
    private Deck deck = new Deck();
    private Random random = new Random();
    private Dictionary<string, int> playerCards = new Dictionary<string, int>();
    private Dictionary<string, int> dealerCards = new Dictionary<string, int>();

    public Dictionary<string, int> Move(string role, int iterationCard)
    {
        for (int i = 0; i < iterationCard; i++)
        {
            

            int randomIndex = random.Next(0, deck.cards.Count);
            string randomKey = deck.cards.Keys.ElementAt(randomIndex);
            int randomValue = deck.cards[randomKey];

            if (role == "Игрок")
            {
                playerCards.Add(randomKey, randomValue);
            }
            else
            {
                dealerCards.Add(randomKey, randomValue);
            }

            // Удаление использованной карты из колоды
            deck.cards.Remove(randomKey);
        }

        return role == "Игрок" ? playerCards : dealerCards;
    }

    void ClearDesk()
    {
        
    }
}
