class Input {
    public Stack<char>[] stack;
    public string[] lines;
    public int[][] moves;
    public Input(string file) {
        this.stack = new Stack<char>[9];
        // Read all files to array
        this.lines = System.IO.File.ReadAllLines(file);

        int i;
        for(i = 0; i < this.lines.Length; i++)
        {
            if(string.IsNullOrEmpty(this.lines[i])){
                i -= 1;

                for(int j = 0; j < this.lines[i].Length; j++){
                    if(this.lines[i][j] >= '0' && this.lines[i][j] <= '9'){
                        this.createStack(this.lines[i][j] - '0' - 1, i - 1, j);
                    }
                }
                i += 2;
                break;
            }
        }

        string[] split;
        this.moves = new int[this.lines.Length - i][];
        for(int j = i; j < this.lines.Length; j++){
            this.moves[j - i] = new int[3];
            split = this.lines[j].Split(' ');

            this.moves[j-i][0] = Int32.Parse(split[1]);
            this.moves[j-i][1] = Int32.Parse(split[3]) - 1;
            this.moves[j-i][2] = Int32.Parse(split[5]) - 1;
        }
    }

    private void createStack(int num, int startLine, int pos){
        this.stack[num] = new Stack<char>();
        for (int i = startLine; i >= 0; i--)
        {   
            if(this.lines[i][pos] >= 'A' && this.lines[i][pos] <= 'Z')
                this.stack[num].Push(this.lines[i][pos]);
        }
    }
}
