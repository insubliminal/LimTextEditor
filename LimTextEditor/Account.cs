﻿using System;
using System.IO;

namespace LimTextEditor
{
    class Account
    {
        private string username;
        private string password;
        private int userType;
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string dateCreated;
        //add a List of file permissions.


        //For a new account created. Requires most recent date.
        public Account(string username, string password, int userType, string firstName, string lastName, string dateOfBirth)
        {
            this.username = username;
            this.password = password;
            this.userType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            dateCreated = DateTime.UtcNow.Date.ToString("dd/MM/yy");

            AddAccountToDatabase();
        }

        //Used for getting the data from the previously existing user file. Date created is should be the same as before.
        public Account(string username, string password, int userType, string firstName, string lastName, string dateOfBirth, string dateCreated)
        {
            this.username = username;
            this.password = password;
            this.userType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.dateCreated = dateCreated;
        }

        public override string ToString()
        {
            string accountDetails = "";

            accountDetails += username + ",";
            accountDetails += password + ",";
            accountDetails += userType + ",";
            accountDetails += firstName + ",";
            accountDetails += lastName + ",";
            accountDetails += dateOfBirth + ",";
            accountDetails += dateCreated;

            return accountDetails;
        }

        public void AddAccountToDatabase()
        {
            string fileName = username + ".txt";

            //If the file exists, it will be replaced and written on with user data and their files that belong to them.

            File.WriteAllText(fileName, this.ToString());
            //CHANGE THIS. WE NEED TO PUT LIST OF FILES INTO THE DATA STORAGE SOMEHOW.
            //File.AppendAllText(fileName, "\r\n" + "Text files they have edited?");
        }
    }
}