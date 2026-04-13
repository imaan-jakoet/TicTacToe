# Tic-Tac-Toe

A classic Tic-Tac-Toe game implemented in C# using a modular, layered architecture. This project demonstrates clean coding practices by separating the core game mechanics from the presentation layer.

## Features
- **Layered Architecture:** Separate projects for Business Logic and the UI.
- **Robust Game Logic:** Handles board state, turn validation, and win/draw detection.
- **Extensible Design:** Easily swap out the interface (e.g., Console to WPF/Web) without changing the core logic.

##  Project Structure
The solution is divided into two primary components:
- **Business/**: The engine of the game. Contains the logic for the 3x3 grid, player moves, and determining the winner.
- **TicTacToe/**: The entry point and interface layer that interacts with the user and displays the game state.

##  Technical Stack
- **Language:** C# 12.0+
- **Framework:** .NET 8.0 / .NET Core
- **Architecture:** Layered / Separation of Concerns (SoC)

##  Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (Version 8.0 or later recommended)

### Installation & Execution
1. **Clone the repository:**
   ```bash
   git clone [https://github.com/imaan-jakoet/TicTacToe.git](https://github.com/imaan-jakoet/TicTacToe.git)
   
2. Navigating to the directory:
   cd TicTacToe
   
3. Restore dependencies:
   dotnet restore

4. Run the application:
   dotnet run --project TicTacToe
