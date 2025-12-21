# csharp-winforms-math-game
# Mystics Math Game

## Overview
This project was developed as part of my **Higher Certificate in Information Systems (Software Development)** at **Eduvos**.  
It is a **desktop-based educational math game** built in C# using Windows Forms. The game combines a fantasy adventure with mathematics, allowing players to cast spells and strike monsters using number-based logic. It was designed to make practicing basic maths fun, especially for younger learners.

## Technologies
- **Language:** C#
- **Framework:** .NET (Windows Forms)
- **IDE:** Visual Studio
- **File Handling:** scoreboard.txt for saving top scores
- **UI Components:** Labels, Buttons, TextBox, ListBox

## Features
- Player name validation using letters only (Regex)
- Random enemy generation (Slime, Goblin) with HP and numeric weaknesses
- Three attack types:
  - Basic Strike — always hits
  - Prime Strike — hits if enemy HP is prime
  - Modulus Strike — hits if enemy HP is divisible by 3
- Enemy counterattacks with random damage
- Health tracking for player and enemies
- Score tracking and saving top scores to a file
- Interactive UI with labels, buttons, and a list box to log actions

## Architecture & Design
- **Object-Oriented Design:** Player, Enemy, and Attack classes; IEnemy interface
- **Enums:** Represent attack types and enemy weaknesses
- **Events & Delegates:** Handle button clicks and UI updates
- **Random & Math Classes:** Generate enemy HP and validate prime/modulus attacks
- **Collections:** Arrays or lists to store available attacks
- **Exception Handling:** Try-catch blocks for file operations and input validation
- **Preprocessor Directives:** `#define DEBUG` used for debugging
- **Namespaces:** Organized logically into game, entities, attacks, and utilities
- **File Handling:** Save/load scores from `scoreboard.txt`
- **UI Layer:** Windows Forms for user interaction

## Learning Outcomes
- Applied object-oriented programming principles in a Windows Forms application
- Implemented game logic including attack validation and enemy AI
- Handled file I/O for persisting high scores
- Used events, delegates, enums, and collections in C#
- Practiced regular expressions for input validation
- Gained experience in desktop application development with interactive UI

## Status
Completed (Academic Project)

## How to Run
1. Open the solution in **Visual Studio**.  
2. Build and run the project.  
3. Enter a valid name to start the game.  
4. Use the buttons to perform attacks and monitor player/enemy HP.  
5. Top scores are saved automatically in `scoreboard.txt`.

