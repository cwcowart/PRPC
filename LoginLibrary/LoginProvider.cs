﻿using System;

namespace LoginLibrary
{
    public class LoginProvider
    {
        //This checks to see if the password matches the password from the database
        //Probably needs to specify where password comes fomr
        public string PasswordVerify(string inputtedPassword)
        {
            string password = "abc123";
            string userName = "Bob";
            if(inputtedPassword != password){
                Console.WriteLine("Incorrect password, please try again");
                return inputtedPassword;
            }else if(inputtedPassword == password){
                Console.WriteLine("LogIn successful! Welcome {0}",userName);
                return password;
            }else{
                 Console.WriteLine("This account does not exist");
                 return inputtedPassword;
            }
        }
        //This checks to see if the username and password match, 
        //needs to specify what username matches what password --> also 
        //need to be able to match username and password with rest of customer
        //information provided
        /* public string LoginVerify (string username){
            if(inputtedUsername == username && inputtedPassword == PasswordVerify){
                Console.WriteLine("Login successful! Welcome {0}", username);

            }
        }
*/
    }
}
