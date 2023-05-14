using System;
public class Login{

    public string _pin;

    public string _pinInput;

    public Boolean _auth;

    public List<string> _pinsList = new List<string>{"0000", "1111", "2222", "3333", "4444", "0123"};


    public void GetUserPIN(){
        Console.Write("Enter your pin to load from your saved file(s): ");
        _pinInput = Console.ReadLine();
    }
    public void VerifyUserPIN(){
        GetUserPIN();
        if (_pinsList.Contains(_pinInput)){
            _auth = true;
        }
        else{
            _auth = false;
        }
    }


}