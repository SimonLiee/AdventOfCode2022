﻿class Input {
    public string[]? lines;
    public Input(string file) {
        // Read all files to array
        string[] lines = System.IO.File.ReadAllLines(file);
    }
}