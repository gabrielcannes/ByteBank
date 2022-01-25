using System;

namespace C_OO2
{
    public class Client
    {
        public string Name {get; set;}
        public string Doccument {get; set;}
        public string Profession {get;set;}

        public Client(string name,string doccument,string profession)
        {
            Name = name;
            Doccument = doccument;
            Profession = profession;
        }
    }
}