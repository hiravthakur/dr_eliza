// See https://aka.ms/new-console-template for more information
using System.Linq;

bool active = true;
string userInput = "";
dr_eliza.respBank bank;
bank.keyword = "base";
bank.LoR = new string[] { "" };
dr_eliza.respBank[] lstOfResp = bank.applyBank();

Console.WriteLine("Welcome to Dr Eliza, please state your problem.\n");
Console.WriteLine("Remember, if you are done, say goodbye!");
while (active) {
    Console.WriteLine("User:");
    userInput = Console.ReadLine().ToLower();
    Console.WriteLine("Dr Eliza:");
    checkForInput();
    if (userInput.Contains("quit") || userInput.Contains("goodbye") || userInput.Contains("bye"))
    {
        System.Environment.Exit(0);
    }
}

void printRightValue()
{

    foreach (dr_eliza.respBank i in lstOfResp)
    {
        if (userInput.Contains(i.keyword))
        {
            Random r = new Random();
            int rNumber = r.Next(0, i.LoR.Length - 1);
            string response = i.LoR[rNumber];
            if (response.Contains("$"))
            {
                string newResponse = response.Replace("$", userInput.Substring(i.keyword.Length + 1 + userInput.IndexOf(i.keyword)));
                Console.WriteLine(newResponse);
                break;
            }
            else
            {
                Console.WriteLine(response);
                break;
            }
            
        }
    }

    return;

}

void checkForInput()
{
    foreach (dr_eliza.respBank n in lstOfResp)
    {
        if (userInput.Contains(n.keyword))
        {
            printRightValue();
            return;
            

        }

    }
      
            string[] defaultLst = new string[] {"Very interesting",
  "I am not sure I understand you fully",
  "What does that suggest to you?",
  "Please continue",
  "Go on",
  "Do you feel strongly about discussing such things?"};
            Random x = new Random();
            int e = x.Next(0, defaultLst.Length - 1);
            Console.WriteLine(defaultLst[e]);
        
    

    return;
}
