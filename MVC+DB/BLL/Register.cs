namespace BLL;
using BOL;
using DAL;
public class Register{
     public bool ValidateUser(string uname,string pass){

        return DBManager.ValidateUser(uname,pass);
    }
}