using System;


namespace Unit02.Game
{
    /// <summary>
    /// A small cube with a different number of spots on each of its six sides.
    /// 
    /// The responsibility of Die is to keep track of its currently rolled value and the points its
    /// worth.
    /// </summary> 
    public class Card
    {
        public int cardNumber;

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Generates a new random value and calculates the points for the die.
        /// </summary>
        public void getNewCard()
        {
            Random random = new Random();
            cardNumber = random.Next(1, 14);
            
        }

    }
}