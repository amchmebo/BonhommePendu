using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer peu importe si la lettre est dans le mot ou pas!
    public class GuessedLetterEvent : GameEvent
    {
        public override string EventType { get { return "GuessedLetter"; } }

        // Ajouter une lettre
        public char Letter { get; set; }

        public GuessedLetterEvent(GameData gameData, char letter)
        {
            //assigner la lettre à la propriété
            Letter = letter;
            //ajouter la lettre à la liste du game data
            gameData.GuessedLetters.Add(Letter);
        }
    }
}
