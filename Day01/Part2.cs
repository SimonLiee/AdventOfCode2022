class Part2 {
    public int answer;
    public Part2(int[] nums) {

        int cals = 0;
        int h1 = 0;
        int h2 = 0;
        int h3 = 0;
        foreach (int num in nums)
        {   
            if(num == 0){
                if(cals > h1){
                    h3 = h2;
                    h2 = h1;
                    h1 = cals;
                } else if(cals > h2){
                    h3 = h2;
                    h2 = cals;
                } else if(cals > h3){
                    h3 = cals;
                }
                cals = 0;
                continue;
            }
            cals += num;
        
        }

        if(cals > h1){
            h3 = h2;
            h2 = h1;
            h1 = cals;
        } else if(cals > h2){
            h3 = h2;
            h2 = cals;
        } else if(cals > h3){
            h3 = cals;
        }

        this.answer = h1 + h2 + h3;
    }
}