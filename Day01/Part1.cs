class Part1 {
    public int answer;
    public Part1(int[] nums) {
        int cals = 0;
        int highest = 0;
        foreach (int num in nums)
        {   
            if(num == 0){
                cals = 0;
                continue;
            }
            cals += num;

            if(cals > highest){
                highest = cals;
            }
        }

        this.answer = highest;
    }
}

