# Endless Zombie Shooter (Unity)

This repository contains a set of example scripts that implement the core logic for a simple endless shooter game in Unity.

## Features

- Touch-based player movement and shooting (Android/iOS ready)
- Endless zombie spawning from the top of the screen
- Power-up barrels that require damage to collect a stronger weapon
- Soldier power-ups that can add or remove allies based on the value
- Random boss encounters after a delay

All models and graphics can be simple placeholders from the Unity Asset Store.

## Getting Started

1. Create a new 3D project in **Unity 6000.1.12f1** or any newer version.
2. Copy the contents of this repository into your project's `Assets` folder. The `Scripts` folder contains all C# scripts used in the example.
3. Create prefabs for the player, enemies, bullets, power-ups, and bosses.
4. Attach the corresponding scripts to these prefabs and assign the required fields in the Inspector.
5. Build the project for Android or iOS to test touch controls.

The game places the player at the bottom of the screen. Zombies spawn from the top and move downward. Defeat enemies, collect power-ups, and survive as long as possible to increase your score. The included player controller works with both the classic Input manager and the new Input System introduced in recent Unity versions.

## Scripts Overview

| Script | Purpose |
| --- | --- |
| `PlayerController.cs` | Handles touch movement and shooting. |
| `EnemySpawner.cs` | Spawns zombies at regular intervals. |
| `PowerUpBarrel.cs` | Barrel that grants a stronger weapon once destroyed. |
| `SoldierPowerUp.cs` | Gives or removes ally soldiers when collected. |
| `BossSpawner.cs` | Spawns powerful bosses after a random delay. |

These scripts are intentionally simple and can be extended with health management, scoring, animations, and additional gameplay logic.
