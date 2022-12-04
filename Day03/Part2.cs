class Part2 {
    public int answer;
    public Part2(Input inn) {
        if(inn.lines == null)
            return;
        int i = 0;
        while(i < inn.lines.Length){
            foreach(char c in inn.lines[i]){
                if(inn.lines[i + 1].Contains(c) && inn.lines[i + 2].Contains(c)){
                    this.answer += this.priority(c);
                    break;
                }
            }
            i += 3;
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