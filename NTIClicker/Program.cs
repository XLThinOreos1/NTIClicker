global using Raylib_cs;

// Initialize the window
Raylib.InitWindow(1280, 720, "NTI Clicker");
Raylib.SetTargetFPS(60);
Raylib.InitAudioDevice();

GameAudio audio = new();
GameLoop gameLoop = new();

Raylib.SetMusicVolume(audio.bgm, (float)0.3);
Raylib.SetSoundVolume(audio.clickNTI, (float)0.5);
Raylib.SetSoundVolume(audio.buyBuilding, (float)0.5);

// Main game loop
while (!Raylib.WindowShouldClose())
{
    Raylib.PlayMusicStream(audio.bgm);
    Raylib.UpdateMusicStream(audio.bgm);

    Raylib.BeginDrawing();
    gameLoop.RunGameLoop();
    Raylib.EndDrawing();

    FunEasterEggs.ChangeGameName();
}

// Close the window
Raylib.CloseWindow();