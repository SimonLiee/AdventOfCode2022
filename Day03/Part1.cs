class Part1 {
    public int answer;
    public Part1(Input inn) {
        string first;
        string second;

        if(inn.lines == null)
            return;
        foreach(string line in inn.lines){
            first = line.Substring(0, line.Length / 2);
            second = line.Substring(line.Length / 2, line.Length / 2);
            foreach(char c in first){
                if(second.Contains(c)){
                    this.answer += this.priority(c);
                    break;
                }
            }
        }
    }

    private int priority(char c){
        if(char.IsUpper(c)) {
            return  c - 'A' + 27;
        } else {
            return c - 'a' + 1;
        }
    }
}

