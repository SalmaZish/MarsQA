using System;
using NUnit.Framework;
using MarsQAProject.Utilities;
using MarsQAProject.Pages;

namespace MarsQAProject
{
    [TestFixture]
    internal class MarsTests: CommonDriver
    {     


        [Test, Order(1), Description("Create")]
        public void CreateFunction()
        {
            //MarsLoginPage loginobj = new MarsLoginPage();
            //loginobj.LoginPage();

            //MProfilelanguagePage langobj = new MProfilelanguagePage();
            //langobj.AddLanguge(Driver);
        }

        [Test, Order(2), Description("Edit")]
        public void EditFunction()
        {
             
        }

        [Test, Order(3), Description("Delete")]
        public void DeleteFunction()
        {
            
        }


    }
}
