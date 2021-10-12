// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// "C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe" --new-window --app="C:\Users\z004c1aw\Downloads\HWEGuidanceAndGovernanceForTestAllignment.pdf"
//"C:\Program Files\Google\Chrome\Application\chrome.exe" --new-window --app="C:\Users\z004c1aw\Downloads\HWEGuidanceAndGovernanceForTestAllignment.pdf"

using System.Diagnostics;

Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", @$"--new-window --app=""{args[0]}""");