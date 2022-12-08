class Input {
    public string[][]? lines;
    public Input(string file) {
        // Read all files to array
        string[] l;
        l = System.IO.File.ReadAllLines(file);

        this.lines = new string[l.Length][];

        for (int i = 0; i < l.Length; i++)
        {
            this.lines[i] = l[i].Split(' ');
        }
    }
}