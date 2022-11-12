﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    // Player Class
    public class Player
    {
        // Player name
        public string PlayerName { get; set; }

        // Simple constructor
        public Player(string name)
        {
            this.PlayerName = name;
            // Subscribe to the OnGameStart and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        // At the start of the game, spawn the player.
        private void StartGame ()
        {
            Console.WriteLine($"Spawning Player with ID: {PlayerName}.");
        }

        // When the game is over, remove the player from the game.
        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID: {PlayerName}.");
        }
    }
}
