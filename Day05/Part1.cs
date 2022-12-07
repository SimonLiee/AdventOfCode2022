class Part1 {
    public string? answer;
    public Part1(Input inn) {

        char tmp;
        // Create answer by reading top of each stack
        foreach(int[] i in inn.moves){
            for(int j = 0; j < i[0]; j++){
                tmp = inn.stack[i[1]].Pop();
                inn.stack[i[2]].Push(tmp);
            }
        }

        foreach(Stack<char> s in inn.stack)
            if(s != null)
                this.answer += s.Peek();
    }
}

