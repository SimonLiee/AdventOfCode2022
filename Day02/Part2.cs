class Part2 {
    public int answer;
    public Part2(string[] lines) {
        int you;
        int opp;

        foreach(string line in lines) {
            opp = line[0] - 'A';
            
            if(line[2] == 'X'){ // Lose
                you = opp - 1;
                if(you < 0)
                    you = 2;
            } else if(line[2] == 'Y') { // Draw
                you = opp;
            } else{ // Win
                you = (opp + 1) % 3; 
            }
            
            if(you == opp){
                this.answer += you + 1 + 3;
            } else if((opp + 1) % 3 == you) {
                this.answer += you + 1 + 6;
            } else{
                this.answer += you + 1 + 0;
            }
        }
    }
}