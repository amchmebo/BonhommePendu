using BonhommePendu.Models;
using System.Security.Cryptography.X509Certificates;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois qu'un utilisateur essai une "nouvelle" lettre
    public class GuessEvent : GameEvent
    {
        public override string EventType { get { return "Guess"; } }

        // TODO: Compléter
        public GuessEvent(GameData gameData, char letter) {
            // TODO: Commencez par ICI
            Events = new List<GameEvent>();

            Events.Add(new GuessedLetterEvent(gameData, letter));

            bool foundAtLeastOneLetter = false;

            for(int i = 0; i < gameData.RevealedWord.Length; i++)
            {
                if(gameData.HasSameLetterAtIndex(letter, i))
                {
                    foundAtLeastOneLetter = true;
                    Events.Add(new RevealLetterEvent(gameData, letter, i));
                }
            }

            if (!foundAtLeastOneLetter)
            {
                Events.Add(new WrongGuessEvent(gameData));
            }
        }
    }
}
