using System;
public class Login{

    public string pin;

    public string pinInput;

    public Boolean auth;

    public List<string> pinsList = new List<string>{"0000", "1111", "2222", "3333", "4444", "0123"};


    public void GetUserPIN(){
        Console.Write("Enter your pin to load from your saved file(s): ");
        pinInput = Console.ReadLine();
    }
    public void VerifyUserPIN(){
        GetUserPIN();
        if (pinsList.Contains(pinInput)){
            auth = true;
        }
        else{
            auth = false;
        }
    }


}