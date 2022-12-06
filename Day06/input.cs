class Input {
    public string[]? lines;
    public Input(string file) {
        // Read all files to array
        this.lines = System.IO.File.ReadAllLines(file);
    }
}