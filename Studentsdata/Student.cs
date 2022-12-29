namespace Students;

public class Student {

    private string name;
    private string std;
    private int marks;
    
    public void Setname(String name){
        this.name=name;
    }
     
    public void Setstd(String std){
        this.std=std;   
    }
      
    public void Setmarks(int marks){
        this.marks=marks;
    }
    public string getname(){
        return this.name;
    }
    public string getstd(){
        return this.std;   
    }
    public int getmarks(){
        return this.marks;
    }
    public Student(string name,string std,int marks){
       this.name=name;
        this.std=std;
        this.marks=marks;
    }
    
}