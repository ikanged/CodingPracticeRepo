using System;
using System.Collections.Generic;
using CodingPractice;

namespace HackerRank
{
    public class TriesContactsApplication : AbsProblem, IProblem
    {

        public TriesContactsApplication() : base("Contacts Application")
        {
        }

        public override void Begin()
        {
            int iUserNumInput = GetUserIntInput();
            string[] iUserStrArrayInput = GetUserAryStringInput();

            //Dictionary<string, string> dictInput = OrganizeEachInput(iUserStrArrayInput);

        }

        public int FindContact(string strContact)
        {
            int iAnswer = 0;


            return iAnswer;
        }

        public void AddContact(string strContact)
        {

        }
    }
}
