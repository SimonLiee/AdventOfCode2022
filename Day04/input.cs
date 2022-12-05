class Input {
    public int[][]? lines;
    public Input(string file) {
        // Read all files to array
        string[] fileLines = System.IO.File.ReadAllLines(file);

        this.lines = new int[fileLines.Length][];

        string[] li;
        string[] l;

        for(int i = 0; i < fileLines.Length; i++) {
            li = fileLines[i].Split(',');
            this.lines[i] = new int[4];

            l = li[0].Split('-');
            this.lines[i][0] = Int32.Parse(l[0]);
            this.lines[i][1] = Int32.Parse(l[1]);

            l = li[1].Split('-');
            this.lines[i][2] = Int32.Parse(l[0]);
            this.lines[i][3] = Int32.Parse(l[1]);
        }
    }
}