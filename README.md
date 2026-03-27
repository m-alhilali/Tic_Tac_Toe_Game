# Tic-Tac-Toe Game (C# Windows Forms)

A classic **Tic-Tac-Toe** desktop application built using **C#** and **Windows Forms**. This project demonstrates the implementation of game logic, UI event handling, and custom graphics in the .NET environment.

## 🚀 Features

* [cite_start]**Custom Player Selection:** Allows selecting which player starts the game (Player 1 or Player 2) via a ComboBox [cite: 394, 421-424].
* [cite_start]**Dynamic UI Updates:** Real-time tracking of player turns and visual display of the game status[cite: 77, 245, 252].
* [cite_start]**Win Detection Logic:** An automated system that checks for winning patterns across rows, columns, and diagonals [cite: 187-212].
* [cite_start]**Visual Feedback:** Highlights the winning line in `GreenYellow` to clearly indicate the end of the match [cite: 142-144].
* [cite_start]**Draw Detection:** Effectively handles "Draw" scenarios once all 9 moves are completed without a winner [cite: 274-283].
* [cite_start]**Custom Graphics (GDI+):** Uses the `Paint` event and `Pen` class to draw the game grid lines directly on the form [cite: 287-326].
* [cite_start]**Game Reset:** A dedicated function to clear the board, reset the play count, and restart the session [cite: 355-387].

## 🛠️ Technical Implementation

### Core Components
* [cite_start]**Enums & Structs:** Used `enum` for `enWinner` and `enPlayer` to maintain clean, readable code, and a `struct` called `sStateGame` to track the current state [cite: 26-61].
* [cite_start]**Tag-Based Logic:** Utilizes the `.Tag` property of `Button` controls to identify the state of each cell ("X", "O", or "?")[cite: 128, 220, 350].
* [cite_start]**Centralized Event Handling:** All game buttons share a single `button_Click` event, which casts the `sender` to a `Button` type for processing [cite: 334-335].

### Graphics Logic
[cite_start]The grid is rendered dynamically using the `Form1_Paint` method [cite: 287-326]:
```csharp
// Example of the drawing logic used in the project
e.Graphics.DrawLine(pen, 580, 100, 580, 400); // Vertical Line
e.Graphics.DrawLine(pen, 700, 200, 280, 200); // Horizontal Line
