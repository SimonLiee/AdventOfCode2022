class Part2 {
    public int answer;
    private List<string> dir  = new List<string>();
    private Dictionary<string, List<string[]>> fileSys  = new Dictionary<string, List<string[]>>();
    private Dictionary<string, int> fileSysSizes  = new Dictionary<string, int>();

    public Part2(Input inn) {
        if(inn.lines == null)
            return; 

        // Parse and create filesystem
        string[] l; 
        for (int i = 0; i < inn.lines.Length; i++)
        {   
            l = inn.lines[i];
            if(l[0] == "$"){
                if(l[1] == "cd")
                    this.cd(l);
                else if(l[1] == "ls"){
                    this.ls(i, inn);
                }
            }
        }

        // Calculate directory sizes
        int size = 0;
        while(this.fileSysSizes.Count < this.fileSys.Count()){
            foreach(var i in this.fileSys){ // Each dir
                size = 0;
                foreach(var j in this.fileSys[i.Key]){ // Each file in dir
                    if(j[0] == "dir"){
                        if(this.fileSysSizes.ContainsKey(i.Key + j[1] + "/")){
                            size += this.fileSysSizes[i.Key + j[1] + "/"];
                        } else {
                            size = -1;
                            break;
                        }
                    } else {
                        size += Int32.Parse(j[0]);
                    }
                }
                if(size != -1)
                    this.fileSysSizes[i.Key] = size;
            }
        }


        this.answer = 0;
        int spaceNeeed = 30000000 - (70000000 - this.fileSysSizes["//"]);
            
        string deleteDir = "//";
        foreach(var i in this.fileSysSizes){
            if(this.fileSysSizes[i.Key] > spaceNeeed && this.fileSysSizes[i.Key] < this.fileSysSizes[deleteDir])
                deleteDir = i.Key;

        }

        this.answer = this.fileSysSizes[deleteDir];
    }

    private void cd(string[] l ){
        if(l[2] == ".."){
            this.dir.RemoveAt(dir.Count - 1);
        } else {
            this.dir.Add(l[2]);
        }
    }

    private void ls(int l, Input inn){
        List<string[]> list =  new List<string[]>();
        l++;
        while(inn.lines.Length > l){
            if(inn.lines[l][0] == "$" )
                break;
            list.Add(inn.lines[l]);
            l++;
        }
        
        string name = "";

        foreach(string d in dir){
            name += d;
            name += "/";
        }
        if(this.fileSys.ContainsKey(this.dir[dir.Count() - 1])){
            Console.WriteLine(this.dir[dir.Count() - 1]);
        }
        this.fileSys[name] = list;
    }

    private string getName(){
        string name = "";

        foreach(string d in this.dir){
            name += d;
            name += "/";
        }
        return name;
    }
}

