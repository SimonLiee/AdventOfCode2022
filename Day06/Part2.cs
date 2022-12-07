class Part2 {
    public int answer;
    public Part2(Input inn) {
        if(inn.lines == null)
            return;
            
        string line = inn.lines[0];

        string marker = "";
        for (int i = 0; i < line.Length; i++){
            marker += line[i];
            if(marker.Length > 14){
                marker = marker.Remove(0, 1);
            }
            if(isMarker(marker)){
                this.answer = i + 1;
                break;
            }   
        }
    }

    private bool isMarker(string marker){
        if(marker.Length != 14)
            return false;

        for (int i = 0; i < marker.Length; i++){
            for (int j = i + 1; j < marker.Length; j++){
                if(marker[i] == marker[j]){
                    return false;
                }
            }
        }
        Console.WriteLine("True");
        return true;
    }
}