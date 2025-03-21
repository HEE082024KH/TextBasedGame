﻿using System.Runtime.InteropServices;
using TextBasedGame.classes;

namespace TextBasedGame;

class Program
{
  // [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
  // static extern IntPtr GetConsoleWindow();
  //
  // [DllImport("user32.dll")]
  // static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
  //
  // const int SwMaximize = 5;

  static void Main()
  {
    Controller controller = new();

    // Console.SetWindowSize(3000, 2000);
    // Console.SetBufferSize(3000, 2000);

    // ShowWindow(GetConsoleWindow(), SwMaximize);
    // Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

    // Run Game
    controller.Run();
  }
}