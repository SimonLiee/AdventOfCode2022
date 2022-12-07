class Part2 {
    public string? answer;
    public Part2(Input inn) {
        Stack<char> tmpS = new Stack<char>();
        // Create answer by reading top of each stack
        foreach(int[] i in inn.moves){
            for(int j = 0; j < i[0]; j++){
                tmpS.Push( inn.stack[i[1]].Pop() );
            }

            while(tmpS.Count() > 0){
                inn.stack[i[2]].Push( tmpS.Pop() ) ;
            }
        }

        foreach(Stack<char> s in inn.stack)
            if(s != null)
                this.answer += s.Peek();
    }
}