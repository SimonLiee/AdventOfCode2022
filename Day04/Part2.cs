class Part2 {
    public int answer;
    public Part2(Input inn) {
        if(inn.lines == null)
            return;
        foreach(int[] line in inn.lines) {
            if(line[0] >= line[2] && line[0] <= line[3]){
                this.answer += 1;
            }else if(line[1] >= line[2] && line[0] <= line[3]){
                this.answer += 1;
            }else if(line[2] >= line[0] && line[2] <= line[1]){
                this.answer += 1;
            }else if(line[3] >= line[0] && line[3] <= line[1]){
                this.answer += 1;
            }
        }
    }
}