using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Card> _cards = new List<Card>();
        bool _isPlaying = true;
        int _winPoints = 100;
        int _losePoints = 75;
        int _totalScore = 300;

        int currentCard;
        int newCard;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            for (int i = 0; i < 1; i++)
            {
                Card card = new Card();
                _cards.Add(card);
            }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            foreach (Card card in _cards)
            {
                card.getNewCard();
                currentCard = card.cardNumber;
            }
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Pull a card? [y/n] ");
            string newCard = Console.ReadLine();
            _isPlaying = (newCard == "y");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }
            foreach (Card card in _cards)
            {
                card.getNewCard();
                newCard = card.cardNumber;

            }
            Console.Write("Do you think the next card will be higher or lower (h/l): ");
            string yourGuess = Console.ReadLine();
            Console.WriteLine($"The next card is: {newCard}");

            if (yourGuess.Equals("h") && currentCard < newCard)
            {
                _totalScore += _winPoints;
            }
            /// works
            else if (yourGuess.Equals("h") && currentCard > newCard)
            {
                _totalScore -= _losePoints;
                if (_totalScore < 0)
                {
                    _totalScore = 0;
                }
            }
            /// works
            else if (yourGuess.Equals("l") && currentCard > newCard)
            {
                _totalScore += _winPoints;

            }
            else if (yourGuess.Equals("l") && currentCard < newCard)
            {
                _totalScore -= _losePoints;
                if (_totalScore < 0)
                {
                    _totalScore = 0;
                }
            }
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }
            currentCard = newCard;

            string values = "";
            foreach (Card card in _cards)
            {
                values += $"{card.cardNumber} ";
            }

            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_totalScore > 0);
        }
    }
}

