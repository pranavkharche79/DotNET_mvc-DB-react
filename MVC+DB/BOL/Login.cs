namespace BOL;

public class Login{

    private string username;
    private string password;

    public Login(){
        
    }
    public Login(string username,string password ){
        this.username=username;
        this.password=password;
    }

    public string UserName{
            get { return username; }
            set { username = value; }
    }
    public string PassWord{
            get { return password; }
            set { password = value; }
    }

}