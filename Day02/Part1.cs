class Part1 {
    public int answer;
    public Part1(string[] lines) {
        int you;
        int opp;

        foreach(string line in lines) {
            opp = line[0] - 'A';
            you = line[2] - 'X';

            if(you == opp){ // Draw
                this.answer += you + 1 + 3;
            } else if((opp + 1) % 3 == you) { // Win
                this.answer += you + 1 + 6;
            } else{ // Lose
                this.answer += you + 1 + 0;
            }
        }
    }
}

// A, X Rock
// B, Y Paper
// C, Z Scissor