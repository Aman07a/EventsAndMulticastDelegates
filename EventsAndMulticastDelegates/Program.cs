using System;

namespace EventsAndMulticastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an audio system
            AudioSystem audioSystem = new AudioSystem();

            // Create a rendering engine
            RenderingEngine renderingEngine = new RenderingEngine();

            // Create two players and give them Id's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DragonSilva");
            Player player3 = new Player("DragonDog");

            // // Start the audio system and the rendering engine
            // audioSystem.StartGame();
            // renderingEngine.StartGame();

            // // Spawn the players
            // player1.StartGame();
            // player2.StartGame();

            // Trigger the GameStart event
            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running....Press any key to end the game!");

            // Pause the game
            Console.Read();

            // Trigger the GameOver event
            GameEventManager.TriggerGameOver();

            // // Shut down the audio system and the rendering engine
            // renderingEngine.GameOver();
            // audioSystem.GameOver();

            // // Remove the players
            // player1.GameOver();
            // player2.GameOver();
        }
    }
}
