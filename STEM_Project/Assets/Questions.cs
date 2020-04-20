using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    public int questionToDisplay;
    public GameObject questionTitle;
    public GameObject aField;
    public GameObject bField;
    public GameObject cField;
    public GameObject dField;


    public List<string> questionList = new List<string>(100);
    public List<string> aList = new List<string>(100);
    public List<string> bList = new List<string>(100);
    public List<string> cList = new List<string>(100);
    public List<string> dList = new List<string>(100);
    public List<string> answerList = new List<string>(100);
    public List<string> correctList = new List<string>(100);
    // Start is called before the first frame update
    void Start()
    {


        LoadQuestions();

        FillQuestion();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FillQuestion() //fill the text elements with the questions and answers
    {
        questionTitle.GetComponent<Text>().text = questionList[questionToDisplay];
        aField.GetComponent<Text>().text = aList[questionToDisplay];
        bField.GetComponent<Text>().text = bList[questionToDisplay];
        cField.GetComponent<Text>().text = cList[questionToDisplay];
        dField.GetComponent<Text>().text = dList[questionToDisplay];

        SetAnswer();


    }

    void SetAnswer()
    {
        if (answerList[questionToDisplay] == "A")
            aField.GetComponent<ABCD>().isAnswer = true;
        if (answerList[questionToDisplay] == "B")
            bField.GetComponent<ABCD>().isAnswer = true;
        if (answerList[questionToDisplay] == "C")
            cField.GetComponent<ABCD>().isAnswer = true;
        if (answerList[questionToDisplay] == "D")
            dField.GetComponent<ABCD>().isAnswer = true;
    }

    void LoadQuestions()
    {
        //-1 from index
        //Question 1 (Multiple Choice)
        questionList.Add("What acronym best describes the 3 main ideas to ensuring security?");
        aList.Add("A DEA");
        bList.Add("B CIA");
        cList.Add("C SAFE");
        dList.Add("D All the above");
        answerList.Add("B");
        correctList.Add("CIA stands for sdg dfl sj");

        //Question 2 (Multiple Choice)
        questionList.Add("What is encryption?");
        aList.Add("A Group of people working together");
        bList.Add("B Catches someone stealing your password");
        cList.Add("C Hides the meaning of communication in text, audio, or video");
        dList.Add("D The act of allowing people to see your message");
        answerList.Add("C");

        //Question 3 (Multiple Choice)
        questionList.Add("If you lose your ID badge then you may not ______ the hackers/attackers.");
        aList.Add("A Deter");
        bList.Add("B Be friends with");
        cList.Add("C Defense-in-depth");
        dList.Add("D Direct");
        answerList.Add("A");

        //Question 4 (True/False)
        questionList.Add("Your teacher audits you.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");

        //Question 5 (Multiple Choice)
        questionList.Add("AAA stands for _____, _____, _____.");
        aList.Add("A Abstract, Authorize, Audit");
        bList.Add("B Authenticate, Authorize, Audit");
        cList.Add("C Adapt, Able, Achieve");
        dList.Add("D An Attacker Always Attacks");
        answerList.Add("B");

        //Question 6 (Multiple Choice)
        questionList.Add("Whats the equation for risk?");
        aList.Add("A Threat + Vulnerability - Attack");
        bList.Add("B Single Loss Expcetancy X Annual Rate of Occurence");
        cList.Add("C Threat X Vulnerability");
        dList.Add("D None of the above");
        answerList.Add("C");

        //Question 7 (Multiple Choice)
        questionList.Add("An unauthorized attack can be done by _____?");
        aList.Add("A Humans");
        bList.Add("B Letting someone not authorized use your school appointed laptop or tablet");
        cList.Add("C Staying logged in after you leave class to go to lunch");
        dList.Add("D All the above");
        answerList.Add("D");

        //Question 8 (True/False)
        questionList.Add("Students birthdays are top secret/propiertary information.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("B");

        //Question 9 (True/False)
        questionList.Add("Your school grades data state is at REST.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");

        //Question 10 (True/False)
        questionList.Add("Your teacher can ask IT workers to check their filtering system to see what your digital footprint left.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");

        //Question 11 (True/False)
        questionList.Add("You reccieve an email that someone in California tried to access your account, you should allow it.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("B");

        //Question 12 (True/False)
        questionList.Add("Stealing information like music or your classmate's password can be considered breaking cybercrimes and you could go to jail/prison.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");

        //Question 13 (True/False)
        questionList.Add("The C in the CIA triad prevents unauthorized access.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");

        //Question 15 (Multiple Choice)
        questionList.Add("What are the correct types of memory?");
        aList.Add("A RAM");
        bList.Add("B ROM");
        cList.Add("C CD");
        dList.Add("D RAM & ROM");
        answerList.Add("D");

        //Question 16 (Multiple Choice)
        questionList.Add("Now that you deleted your history, your teacher & IT people can see what you deleted, why?");
        aList.Add("A Because your system is VOLATILE");
        bList.Add("B Because your system is NONVOLATILE");
        cList.Add("C Because their the boss");
        dList.Add("D Because your system is VOLATILE and they have access to your information at all times");
        answerList.Add("D");

        //Question 17 (Multiple Choice)
        questionList.Add("What is considered to be a data warehouse?");
        aList.Add("A Website/Database that holds your grades, address, middle name, parents name, etc");
        bList.Add("B Your classroom");
        cList.Add("C Username and password");
        dList.Add("D All the above");
        answerList.Add("A");

        //Question 18 (Multiple Choice)
        questionList.Add("What type of cloud computing did you use for you and your group project?");
        aList.Add("A Nonvolatile");
        bList.Add("B Community");
        cList.Add("C Public");
        dList.Add("D CIA");
        answerList.Add("B");

        //Question 19 (True/False)
        questionList.Add("You havent updated your password in 42 days, you should update it.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");

        //Question 20 (True/False)
        questionList.Add("Updates are part of IPS.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");

        //Question 21 (Multiple Choice)
        questionList.Add("Who allow for the most dangerous attacks, UNAUTHORIZED ACCESS?");
        aList.Add("A Phishing");
        bList.Add("B Happens rarely");
        cList.Add("C Brute-force");
        dList.Add("D Humans");
        answerList.Add("D");

        //Question 22 (True/False)
        questionList.Add("notAhackerrrr@email.com wants your address, you should give it to them.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("B");

        //Question 23 (Multiple Choice)
        questionList.Add("What type of attack is this?");
        aList.Add("A Main-in-the-Middle");
        bList.Add("B Phishing");
        cList.Add("C Unauthorized access");
        dList.Add("D All the above");
        answerList.Add("A");

        //Question 24 (True/False)
        questionList.Add("When going from APPLICATION to PHYSICAL level, you are encapsulating.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");

        //Question 25 (Multiple Choice)
        questionList.Add("What layer consists of visualization (JPEG or TIFF)?");
        aList.Add("A OSI");
        bList.Add("B Physical");
        cList.Add("C Presentation");
        dList.Add("D None of the above");
        answerList.Add("C");

        //Question 26 (Multiple Choice)
        questionList.Add("At what layer does IP addresses pop-up?");
        aList.Add("A Network");
        bList.Add("B Physical");
        cList.Add("C Network and Physical");
        dList.Add("D None of the above");
        answerList.Add("A");

        //Question 27 (Multiple Choice)
        questionList.Add("What layer of the OSI may this attack occur?");
        aList.Add("A TCI");
        bList.Add("B SYN/ACK");
        cList.Add("C Transport");
        dList.Add("D All the above");
        answerList.Add("C");

        //Question 28 (Multiple Choice)
        questionList.Add("Whats the strongest biometric password?");
        aList.Add("A Something you know");
        bList.Add("B Retinal");
        cList.Add("C Fingerprint");
        dList.Add("D QR code");
        answerList.Add("B");

        //Question 29 (Multiple Choice)
        questionList.Add("Uh oh! Your locked out of your account, what type of error has your school used?");
        aList.Add("A False acceptance");
        bList.Add("B Biometric");
        cList.Add("C 2-type-authentication");
        dList.Add("D False rejection");
        answerList.Add("D");

        //Question 30 (Multiple Choice)
        questionList.Add("How many characters should you have at least?");
        aList.Add("A 12");
        bList.Add("B 53");
        cList.Add("C 1");
        dList.Add("D 18");
        answerList.Add("A");

        //Question 31 (Multiple Choice)
        questionList.Add("What type of test is this?");
        aList.Add("A Type 1");
        bList.Add("B White");
        cList.Add("C Type 2");
        dList.Add("D Type 1 and Type 2");
        answerList.Add("C");

        //Question 32 (Multiple Choice)
        questionList.Add("What type of pen test is this?");
        aList.Add("A White");
        bList.Add("B Black");
        cList.Add("C Type 1");
        dList.Add("D All the above");
        answerList.Add("A");

        //Question 33 (Multiple Choice)
        questionList.Add("WHy would this be called a Xmas attack?");
        aList.Add("A Only done around Christmas");
        bList.Add("B Shows all the ports");
        cList.Add("C All open ports alert the pen testers");
        dList.Add("D None of the above");
        answerList.Add("C");

        //Question 34 (Multiple Choice)
        questionList.Add("What layer would this pen test attack?");
        aList.Add("A Transport");
        bList.Add("B Xmas");
        cList.Add("C White");
        dList.Add("D All the above");
        answerList.Add("A");

        //Question 35 (True/False)
        questionList.Add("This is secure through symmetric cyrptography; you should send your top secret information to your teacher.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("B");

        //Question 36 (Multiple Choice)
        questionList.Add("What should you do with this email?");
        aList.Add("A Send email");
        bList.Add("B Leave and go to lunch");
        cList.Add("C Throw in the trash or delete it");
        dList.Add("D None of the above");
        answerList.Add("C");

        //Question 37 (True/False)
        questionList.Add("This is a good way to secure your asymmetric message.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");

        //Question 38 (Multiple Choice)
        questionList.Add("You live in Michigan and have a lot of snow days with power outages, what type of alternative site should you have to secure all your information or data?");
        aList.Add("A Michigan");
        bList.Add("B Hot");
        cList.Add("C Cold");
        dList.Add("D All the above");
        answerList.Add("B");

        //Question 37 (True/False)
        questionList.Add("The 7 main ways to stop attacks are to have control physical and electronic access to systems, create strong passwords or hash or salt, multifactor authentication, account lockout controls, last logon notification, classifications, and educate others.");
        aList.Add("A True");
        bList.Add("B False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
    }
}
