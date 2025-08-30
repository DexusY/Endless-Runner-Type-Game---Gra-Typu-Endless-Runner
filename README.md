<a id="readme-top"></a>

<br />
<div align="center">
  <h1 align="center">Endless Runner (C# WinForms)</h1>
  <p align="center">
    A simple 2D endless runner game built with Windows Forms (C#). Navigate the runner, avoid obstacles, and reach the goal. Includes Polish UI screens: Welcome, Menu, Question, Win, and Lose.
    <br />
  </p>
</div>

---

## Table of Contents
- [About The Project](#about-the-project)
- [How It Works](#how-it-works)
- [Example Features](#example-features)
- [Limitations](#limitations)
- [Demo](#demo)
- [Built With](#built-with)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Troubleshooting](#troubleshooting)

---

## About The Project
This repository contains a Windows Forms endless runner game written in C#.  
Project structure highlights:
- Forms:
  - EkranPowitalny (Welcome/Splash)
  - Menu (Main Menu)
  - Form1 (Game)
  - Pytanie (Question/Quiz)
  - Wygrana (Win)
  - Przegrana (Lose)
- Embedded resources for the runner sprite, obstacles, and backgrounds.

The goal is to avoid obstacles while the scene scrolls. Depending on the game rules, you may be presented with a quiz (Pytanie) and can end in a win (Wygrana) or lose (Przegrana) screen.

---

## How It Works
Core gameplay runs in Form1.cs:
- A Timer drives the game loop (update tick).
- Background parallax is simulated by moving background images left and wrapping them.
- Obstacles (PictureBox controls with images) move toward the player and reset/spawn when off-screen.
- The runner uses an animated GIF (runner.gif).
- Collision detection is performed via bounding box intersection of controls.
- Game state transitions to Wygrana/Przegrana or opens Pytanie when rules are met.
- Other forms (EkranPowitalny, Menu) handle navigation and UI.

Assets are stored in Properties/Resources and referenced by controls on the forms.

---

## Example Features
- Continuous scrolling background (tlo.png/tlo1.png/tlo2.png).
- Animated player character (runner.gif).
- Multiple obstacle sprites (przeszkoda1.png, przeszkoda2.png).
- Simple collision detection and score/progress tracking.
- Polish UI flow: Welcome → Menu → Game → Win/Lose (and optional Question).
- Separate win and lose forms with replay/menu options.

---

## Limitations
- Fixed window layout (may not scale well on high DPI or non-1080p displays).
- Basic physics and collision (AABB), no advanced mechanics.
- Single-player, local only.
- Hardcoded assets and parameters in forms; no external config.
- Windows-only (WinForms).

---

## Demo
Build or run the included Debug executable.

Quick try (Windows):
- Navigate to: ProjektNaJPWP/bin/Debug/
- Run: ProjektNaJPWP.exe
- In the Menu form, start the game and use the controls to avoid obstacles.

Controls (typical):
- Space/Up Arrow: Jump
- Esc: Return to menu (if implemented)

Sample flow:
1) EkranPowitalny shows briefly, then Menu loads.
2) Start the game (Form1).
3) Avoid obstacles until you reach the target or lose on collision.
4) On success, Wygrana appears; on collision, Przegrana appears.
5) Pytanie may appear to present a quiz/bonus step.

---

## Built With

| Technology | Description |
|------------|-------------|
| C# (.NET Framework) | Core language/runtime |
| Windows Forms | UI framework for desktop forms |
| Visual Studio | IDE and designer |

---

## Prerequisites
- Windows 10/11
- .NET Framework 4.8 Runtime (recommended) for running the executable
- Visual Studio 2019 or 2022 with “.NET desktop development” workload for building
- Git (optional, for cloning)

---

## Installation

### 1) Clone the repository
Windows (PowerShell or CMD):
```bat
cd path\to\your\workspace
git clone https://github.com/<your-user>/<your-repo>.git
cd <your-repo>
```

Or download the ZIP and extract it to your workspace.

### 2) Open the solution
- Open in Visual Studio:
  - File → Open → Project/Solution...
  - Select: ProjektNaJPWP/ProjektNaJPWP.sln

### 3) Build
Visual Studio:
- Set configuration to Debug or Release.
- Build → Build Solution (Ctrl+Shift+B).

Developer Command Prompt for VS:
```bat
cd path\to\repo\ProjektNaJPWP
MSBuild ProjektNaJPWP.sln /p:Configuration=Debug
```

The executable will be in:
- ProjektNaJPWP\ProjektNaJPWP\bin\Debug\ProjektNaJPWP.exe (or Release accordingly)

---

## Usage

Windows (from File Explorer):
- Double-click:
  - ProjektNaJPWP\ProjektNaJPWP\bin\Debug\ProjektNaJPWP.exe

Windows (from terminal):
```bat
cd path\to\repo\ProjektNaJPWP\ProjektNaJPWP\bin\Debug
ProjektNaJPWP.exe
```

In-game:
- Start from Menu.
- Use Space/Up to jump and avoid obstacles.
- Follow on-screen instructions for any questions (Pytanie) and end screens.

Notes:
- Ensure the executable is run from the compiled output folder so embedded resources load properly.
- If DPI scaling causes layout issues, try Compatibility settings or different scaling factors.

---

## Troubleshooting
- Build errors: Install the “.NET desktop development” workload in Visual Studio.
- App won’t start: Install .NET Framework 4.8 Runtime (or the version targeted by the project).
- Missing images or blank sprites: Clean and rebuild the solution; ensure Resources are embedded and not removed.
- High DPI layout issues: Right-click EXE → Properties → Compatibility → “Change high DPI settings” and test different overrides.
- SmartScreen warning: Click “More info” → “Run anyway” if you trust the source.

[Back to top](#readme-top)