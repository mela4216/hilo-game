# hilo-game

Hilo Game:
In this game, we start with 300 points and gain or lose points depending on whether we guess the behavior of a card correctly. If we are correct in assuming that the next card is higher or lower, we will gain 100 points. If we are incorrect, we will lose 75 points. There won't be any negative points though.

Program.cs
We will call the director class and begin the game.

Director.cs
We will get an input from the user to see if they are still playing the game. In our doUpdates(), we will get the new card and gain points depending on the guess made. In our outputs, we will update the score and display it for the player.

Card.cs
In this class we will get a random card to be used in our game.
