using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SWT2781_GroupProject
{
    [TestClass]
    public class UnitTest1
    {
        WebDriver driver;

        [TestInitialize]
        public void StartUp()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void LoginTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/login.html"; //Please change file path as needed to run test.

            driver.FindElement(By.Id("email")).SendKeys("admin@example.com");
            driver.FindElement(By.Id("password")).SendKeys("admin");

            driver.FindElement(By.Id("loginButton")).Click();
        }

        [TestMethod]
        public void SignOutTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

             driver.FindElement(By.Id("sign-out")).Click();
        }

        [TestMethod]
        public void LogOutTest1()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("logout")).Click();
        }

        [TestMethod]
        public void LogOutTest2()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Projects")).Click();

            driver.FindElement(By.Id("logout")).Click();
        }

        [TestMethod]
        public void LogOutTest3()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Team Members")).Click();

            driver.FindElement(By.Id("logout")).Click();
        }

        [TestMethod]
        public void TicketsNavigateTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/tickets.html"; // Please change file path as needed to run test.

            driver.FindElement(By.Id("nextButton")).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.Id("backButton")).Click();
        }

        [TestMethod]
        public void ProjectsNavigateTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/projects.html"; // Please change file path as needed to run test.

            driver.FindElement(By.Id("nextButton")).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.Id("backButton")).Click();
        }

        [TestMethod]
        public void MembersNavigateTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/team.html"; // Please change file path as needed to run test.

            driver.FindElement(By.Id("nextButton")).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.Id("backButton")).Click();
        }

        [TestMethod]
        public void DisplayAssignedMemberTicketTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("newTicket")).Click();

            driver.FindElement(By.Id("assignedMember")).Click();
        }

        [TestMethod]
        public void DisplayRelatedProjectTicketTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("newTicket")).Click();

            driver.FindElement(By.Id("relatedProject")).Click();
        }

        [TestMethod]
        public void DisplayBugStatusTicketTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("newTicket")).Click();

            driver.FindElement(By.Id("status")).Click();
        }

        [TestMethod]
        public void DisplayBugPriorityTicketTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("newTicket")).Click();

            driver.FindElement(By.Id("priority")).Click();
        }

        [TestMethod]
        public void CancelNewTicketTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("newTicket")).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.Id("submitTicketCancel")).Click();
        }

        [TestMethod]
        public void CreatelNewTicketTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("newTicket")).Click();

            driver.FindElement(By.Id("bugSummary")).SendKeys("This is a test ticket");

            driver.FindElement(By.Id("bugDetails")).SendKeys("This is a very long description of a test ticket");

            driver.FindElement(By.Id("identifier")).SendKeys("Harry Styles");
            
            driver.FindElement(By.Id("identificationDate")).SendKeys("002022/10/03");

            driver.FindElement(By.Id("relatedProject")).SendKeys("Tax app");

            driver.FindElement(By.Id("assignedMember")).SendKeys("Steven Burger");

            driver.FindElement(By.Id("status")).SendKeys("Open");

            driver.FindElement(By.Id("priority")).SendKeys("high");

            driver.FindElement(By.Id("targetDate")).SendKeys("002022/11/01");

            driver.FindElement(By.Id("actualDate")).SendKeys("002022/11/02");

            driver.FindElement(By.Id("resolutionSummary")).SendKeys("This is a summary of the test bug resolution");

            Thread.Sleep(3000);

            driver.FindElement(By.Id("submitTicket")).Click();
        }

        [TestMethod]
        public void AssignTicketTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("3.showMore")).Click();

            driver.FindElement(By.Id("assignTicket")).Click();

            driver.FindElement(By.Id("assignMemberOption")).SendKeys("Harry Styles");

            driver.FindElement(By.Id("MemberSaveChanges")).Click();

            driver.FindElement(By.Id("3")).Click();
        }

        [TestMethod]
        public void HomeButtonTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/tickets.html"; // Please change file path as needed to run test.

            driver.FindElement(By.Id("homelink")).Click();

            Assert.AreEqual("file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html", driver.Url); // Please change file path as needed to run test.
        }

        [TestMethod]
        public void DeleteTicketTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("2.showMore")).Click();

            driver.FindElement(By.Id("deleteTicket")).Click();
        }

        [TestMethod]
        public void AddProjectTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Projects")).Click();

            driver.FindElement(By.Id("newProject")).Click();

            driver.FindElement(By.Id("projectTitle")).SendKeys("This is a test project title");

            driver.FindElement(By.Id("projectDescription")).SendKeys("This is a test project description");

            driver.FindElement(By.Id("submitProject")).Click();
        }

        [TestMethod]
        public void SortByProjectTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();

            driver.FindElement(By.Id("sort")).Click();
        }

        [TestMethod]
        public void AddMemberTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Team Members")).Click();

            driver.FindElement(By.Id("newTeam")).Click();

            driver.FindElement(By.Id("nameAndSurname")).SendKeys("Biggie Cheese");

            driver.FindElement(By.Id("email")).SendKeys("bigC@gmail.com");

            driver.FindElement(By.Id("username")).SendKeys("MrBoombastic");

            driver.FindElement(By.Id("submitTam")).Click();
        }

        [TestMethod]
        public void EditTicketTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/tickets.html"; // Please change file path as needed to run test.

            driver.FindElement(By.Id("1.bugDisplay")).Click();

            driver.FindElement(By.Id("edit")).Click();

            driver.FindElement(By.Id("bugSummary")).Clear();
            driver.FindElement(By.Id("bugSummary")).SendKeys("This is another test");

            driver.FindElement(By.Id("theBugDetails")).Clear();
            driver.FindElement(By.Id("theBugDetails")).SendKeys("This is a very long description of a test ticket");

            driver.FindElement(By.Id("identifier")).SendKeys("George Bush");

            driver.FindElement(By.Id("identificationDate")).SendKeys("002022/11/03");

            driver.FindElement(By.Id("relatedProject")).SendKeys("Calendar app");

            driver.FindElement(By.Id("assignedMemberEdit")).SendKeys("Fredd Scott");

            driver.FindElement(By.Id("status")).SendKeys("Closed");

            driver.FindElement(By.Id("priority")).SendKeys("low");

            driver.FindElement(By.Id("targetDate")).SendKeys("002022/12/01");

            driver.FindElement(By.Id("actualDate")).SendKeys("002022/12/02");

            driver.FindElement(By.Id("resolutionSummary")).Clear();
            driver.FindElement(By.Id("resolutionSummary")).SendKeys("This is a summary of yet another bug resolution");

            driver.FindElement(By.Id("saveChanges")).Click();
        }

        [TestMethod]
        public void DisplayTicketMenuTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Tickets")).Click();
        }

        [TestMethod]
        public void DisplayProjectMenuTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Projects")).Click();
        }

        [TestMethod]
        public void DisplayTeamMemberMenuTest()
        {
            driver.Url = "file:///C:/Belgium%20Campus/BIT%20(2nd%20Year)/SWT2781/Project/WPR2871%20Project/dashboard.html"; // Please change file path as needed to run test.

            driver.FindElement(By.LinkText("Team Members")).Click();
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
//Project Members:
//Suné Susan du Raan (578640)
//Emile Ayden Fourie (577102)
//Leander Botha (578404)
//Anton de Vos (578302)