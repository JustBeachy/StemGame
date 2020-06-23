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
    public GameObject correctField;


    public List<string> questionList = new List<string>(100);
    public List<string> aList = new List<string>(100);
    public List<string> bList = new List<string>(100);
    public List<string> cList = new List<string>(100);
    public List<string> dList = new List<string>(100);
    public List<string> answerList = new List<string>(100);
    public List<string> correctList = new List<string>(100);

    private void Awake()
    {
        questionToDisplay = GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>().ListOfLessons[0];
    }

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
        {
            aField.GetComponent<ABCD>().isAnswer = true;
            aField.GetComponent<ABCD>().CorrectText = correctList[questionToDisplay]; //put the correct text in the answer
        }
        if (answerList[questionToDisplay] == "B")
        {
            bField.GetComponent<ABCD>().isAnswer = true;
            bField.GetComponent<ABCD>().CorrectText = correctList[questionToDisplay]; //put the correct text in the answer
        }
        if (answerList[questionToDisplay] == "C")
        {
            cField.GetComponent<ABCD>().isAnswer = true;
            cField.GetComponent<ABCD>().CorrectText = correctList[questionToDisplay]; //put the correct text in the answer
        }
        if (answerList[questionToDisplay] == "D")
        {
            dField.GetComponent<ABCD>().isAnswer = true;
            dField.GetComponent<ABCD>().CorrectText = correctList[questionToDisplay]; //put the correct text in the answer
        }
    }

    void LoadQuestions()
    {
        
        //Question 0 (Multiple Choice)
        questionList.Add("What best describes the 3 main ideas to keep you safe while using technology?");
        aList.Add("A. DEA");
        bList.Add("B. CIA");
        cList.Add("C. SAFE");
        dList.Add("D. All the above");
        answerList.Add("B");
        correctList.Add("CIA stands for confidentiality, intregrity, and availability. All 3 of these principles help you stay safe while using technology!");

        //Question 1 (Multiple Choice)
        questionList.Add("What is encryption?");
        aList.Add("A. Group of people working together");
        bList.Add("B. Catches someone stealing your password");
        cList.Add("C. Hides the meaning of communication in text, audio, or video");
        dList.Add("D. The act of allowing people to see your message");
        answerList.Add("C");
        correctList.Add("ENCRYPTION is so IMPORTANT when not just using technology, but when communicating with others because it provides more safety for you!");

        //Question 2 (Multiple Choice)
        questionList.Add("If you lose your ID badge then you may not ______ the hackers/attackers.");
        aList.Add("A. Deter");
        bList.Add("B. Be friends with");
        cList.Add("C. Defense-in-depth");
        dList.Add("D. Direct");
        answerList.Add("A");
        correctList.Add("You can strengthen your security and your safety by DETERRING hackers/attackers.");

        //Question 3 (True/False)
        questionList.Add("Your teacher audits you.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("AUDITING helps hold subjects accountable for their actions by monitoring them.");

        //Question 4 (Multiple Choice)
        questionList.Add("AAA stands for _____, _____, _____.");
        aList.Add("A. Abstract, Authorize, Audit");
        bList.Add("B. Authenticate, Authorize, Audit");
        cList.Add("C. Adapt, Able, Achieve");
        dList.Add("D. An Attacker Always Attacks");
        answerList.Add("B");
        correctList.Add("The AAA is authenticate, authorize, and audit all help the subject remain safe whle on the object.");

        //Question 5 (Multiple Choice)
        questionList.Add("Whats the equation for risk?");
        aList.Add("A. Threat + Vulnerability - Attack");
        bList.Add("B. Single Loss Expcetancy X Annual Rate of Occurence");
        cList.Add("C. Threat X Vulnerability");
        dList.Add("D. None of the above");
        answerList.Add("C");
        correctList.Add("RISK is the possisbility that a THREAT will take advantage of a VULNERABILTY, which can harm you!");

        //Question 6 (Multiple Choice)
        questionList.Add("An unauthorized access attack can be done by _____?");
        aList.Add("A. Humans");
        bList.Add("B. Letting someone not authorized use your school provided laptop or tablet");
        cList.Add("C. Staying logged in after you leave class to go to lunch");
        dList.Add("D. All the above");
        answerList.Add("D");
        correctList.Add("UNAUTHORIZED ACCESS ATTACK are the most overlooked attack because humans are the weakest link and can happen to anyone, anywhere!");

        //Question 7 (True/False)
        questionList.Add("Students birthdays are top secret information.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("B");
        correctList.Add("TOP SECRET/PROPIERTARY information must be kept on a need-to-know basis for certain subjects because if a hacker/attacker finds it, you can be vulnerable to danger!");

        //Question 8 (True/False)
        questionList.Add("Your school grades data state is at REST.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("DATA AT REST is any information/data being stored on your object.");

        //Question 9 (True/False)
        questionList.Add("Your teacher can ask IT workers to check their filtering system to see what your digital footprint left.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("FILTERING SYSTEMS are a firewall that monitor which subject is using the object. DIGITAL FOOTPRINT is the subjects history that can be tracked.");

        //Question 10 (True/False)
        questionList.Add("You recieve an email that someone in California tried to access your account, you should allow it.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("B");
        correctList.Add("Allowing somebody you dont know to access your account makes you VULNERABLE and puts you at RISK!");

        //Question 11 (True/False)
        questionList.Add("Stealing information like music or your classmate's password can be considered breaking cybercrimes and you could go to jail/prison.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("Stealing at any age can get you in trouble by your teacher, principal, parent, and the police.");

        //Question 12 (True/False)
        questionList.Add("The C in the CIA triad prevents unauthorized access.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("C is for CONFIDENTIALITY and you must keep your information/data a secret.");

        //Question 13 (Multiple Choice)
        questionList.Add("What are the correct types of memory?");
        aList.Add("A. RAM");
        bList.Add("B. ROM");
        cList.Add("C. CD");
        dList.Add("D. RAM and ROM");
        answerList.Add("D");
        correctList.Add("RAM and ROM can be on any of your technological devices, examples of this are your phone, tablet, or laptop.");

        //Question 14 (Multiple Choice)
        questionList.Add("Now that you deleted your history, your teacher & IT people can see what you deleted, why?");
        aList.Add("A. Because your system is VOLATILE");
        bList.Add("B. Because your system is NONVOLATILE");
        cList.Add("C. Because their the boss");
        dList.Add("D. Your system is NONVOLATILE and have access to all ");
        answerList.Add("D");
        correctList.Add("NONVOLATILE memory keeps everything you have done on the object forever.");

        //Question 15 (Multiple Choice)
        questionList.Add("What is considered to be a data warehouse?");
        aList.Add("A. Website/Database that holds your grades, address, middle name, parents name, etc");
        bList.Add("B. Your classroom");
        cList.Add("C. Username and password");
        dList.Add("D. All the above");
        answerList.Add("A");
        correctList.Add("DATA WAREHOUSE stores all your information used at your school.");

        //Question 16 (Multiple Choice)
        questionList.Add("What type of cloud computing did you use for you and your group project?");
        aList.Add("A. Nonvolatile");
        bList.Add("B. Community");
        cList.Add("C. Public");
        dList.Add("D. CIA");
        answerList.Add("B");
        correctList.Add("COMMUNITY cloud computing only allows certain subjects you authorized to work on your assignment.");

        //Question 17 (True/False)
        questionList.Add("You havent updated your password in 42 days, you should update it.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("To make sure your safe, you should consistently update your password every 30 days or you can be at RISK of being hacked/attacked.");

        //Question 18 (True/False)
        questionList.Add("Updates are part of IPS.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("IPS stands for intrusion prevention systems that stand in the way of hackers/attackers.");

        //Question 19 (Multiple Choice)
        questionList.Add("Who allows the most dangerous attacks, UNAUTHORIZED ACCESS attacks?");
        aList.Add("A. Phishing");
        bList.Add("B. Happens rarely");
        cList.Add("C. Brute-force");
        dList.Add("D. Humans");
        answerList.Add("D");
        correctList.Add("HUMANS are the weakest link!");

        //Question 20 (True/False)
        questionList.Add("notAhackerrrr@email.com wants your address, you should give it to them.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("B");
        correctList.Add("Remember that THREAT X VULNERABILITY = RISK. If you dont know someone who messaged you and you message them back, you put your self at risk!");

        //Question 21 (Multiple Choice)
        questionList.Add("What type of attack has an attacker that sits between two users and steals your information/data?");
        aList.Add("A. Man-in-the-Middle");
        bList.Add("B. Phishing");
        cList.Add("C. Unauthorized access");
        dList.Add("D. All the above");
        answerList.Add("A");
        correctList.Add("Again, THREAT X VULNERABILTY = RISK. Always double check who your talking too because if you dont know who your talking too, then you can be in danger!");

        //Question 22 (True/False)
        questionList.Add("When going from APPLICATION to PHYSICAL layer, you are encapsulating.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("ENCAPSULATING holds and protects the security of your information/data.");

        //Question 23 (Multiple Choice)
        questionList.Add("What layer consists of visualization (JPEG or TIFF)?");
        aList.Add("A. OSI");
        bList.Add("B. Physical");
        cList.Add("C. Presentation");
        dList.Add("D. None of the above");
        answerList.Add("C");
        correctList.Add("VISUALIZATION encrypts messages and pictures for subjects to see at the PRESENTATION layer.");

        //Question 24 (Multiple Choice)
        questionList.Add("At what layer does IP addresses pop-up?");
        aList.Add("A. Network");
        bList.Add("B. Physical");
        cList.Add("C. Network and Physical");
        dList.Add("D. None of the above");
        answerList.Add("A");
        correctList.Add("Every object has an IP ADDRESS to label who/where the subject is on the NETWORK layer, like in mailbox.");

        //Question 25 (Multiple Choice)
        questionList.Add("What layer of the OSI may SYN FLOOD ATTACKS occur (stops communication among users?");
        aList.Add("A. TCI");
        bList.Add("B. SYN/ACK");
        cList.Add("C. Transport");
        dList.Add("D. All the above");
        answerList.Add("C");
        correctList.Add("SYN FLOOD ATTACKS overwhealm and stop all communication between subjects.");

        //Question 26 (Multiple Choice)
        questionList.Add("Whats the strongest biometric password?");
        aList.Add("A. Something you know");
        bList.Add("B. Retina");
        cList.Add("C. Fingerprint");
        dList.Add("D. QR code");
        answerList.Add("B");
        correctList.Add("BIOMETRICS is SOMETHING YOU ARE and can allow authentication. RETINA scans focus on the blood vessels at the back of your eye.");

        //Question 27 (Multiple Choice)
        questionList.Add("Uh oh! Your locked out of your account, what type of error has your school used?");
        aList.Add("A. False acceptance");
        bList.Add("B. Biometric");
        cList.Add("C. 2-type-authentication");
        dList.Add("D. False rejection");
        answerList.Add("D");
        correctList.Add("FALSE REJECTION is very sensitive and is not your fault, your school created STRICT security to make sure your safe.");

        //Question 28 (Multiple Choice)
        questionList.Add("How many characters should you have at least?");
        aList.Add("A. 12");
        bList.Add("B. 53");
        cList.Add("C. 1");
        dList.Add("D. 18");
        answerList.Add("A");
        correctList.Add("ALL your passswords should be at least 12 characters long because they can take a year to hack/attack!");

        //Question 29 (Multiple Choice)
        questionList.Add("What type of test researches 6 MONTHS of your history?");
        aList.Add("A. Type 1");
        bList.Add("B. White");
        cList.Add("C. Type 2");
        dList.Add("D. Type 1 and Type 2");
        answerList.Add("C");
        correctList.Add("TYPE 2 can test the activity that has happened to an object for the last 6 months! This is a job that you can do when your older!");

        //Question 30 (Multiple Choice)
        questionList.Add("What type of pen test KNOW A LOT about your information?");
        aList.Add("A. White");
        bList.Add("B. Black");
        cList.Add("C. Type 1");
        dList.Add("D. All the above");
        answerList.Add("A");
        correctList.Add("WHITE pen tests are when subjects KNOW A LOT about who their testing.");

        //Question 31 (Multiple Choice)
        questionList.Add("What is a Xmas attack?");
        aList.Add("A. Only done around Christmas");
        bList.Add("B. Shows all ports");
        cList.Add("C. All open ports and alert the pen testers");
        dList.Add("D. None of the above");
        answerList.Add("C");
        correctList.Add("When a pen tester wants to try and make sure a subject is safe, they will perform a XMAS ATTACK to see what ports/addresses are opened, the open ports/addresses will light up like a Christmas Tree! These are the ports/addresses that the subject should look to secure even more!");

        //Question 32 (Multiple Choice)
        questionList.Add("What layer would attack communication for the SYN/ACK 3 WAY HANDSHAKE?");
        aList.Add("A. Transport");
        bList.Add("B. Xmas");
        cList.Add("C. White");
        dList.Add("D. All the above");
        answerList.Add("A");
        correctList.Add("Because communication occurs at the TRANSPORT layer and this pen test attacks to see who/where the subject can communicate with.");

        //Question 33 (True/False)
        questionList.Add("You are secure through symmetric cryptography if you want to send your top secret information to your teacher.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("B");
        correctList.Add("SYMMETRIC CRYPTOGRAPHY can be seen by any hacker/attacker because this is a WEAK way of communicating.");

        //Question 34 (Multiple Choice)
        questionList.Add("What should you do with an email that asks for your address and social security?");
        aList.Add("A. Send email");
        bList.Add("B. Leave and go to lunch");
        cList.Add("C. Throw in the trash or delete it");
        dList.Add("D. None of the above");
        answerList.Add("C");
        correctList.Add("As said before in other questions... RISK = THREAT X VULNERABILITY. If you dont know who is messaging you, DO NOT respond or you can be in danger!");

        //Question 35 (True/False)
        questionList.Add("Asymmetric cryptography is the best way to send important/sensitive message.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("ASYMMETRIC CRYPTOGRAPHY allows the sender and reciever to have their own SECRET key to open up a message because even if an hacker/attacker intercepts the message, they dont have the SECRET key to open it.");

        //Question 36 (Multiple Choice)
        questionList.Add("You live in Michigan and have a lot of snow days with power outages, what type of alternative site should you have to secure all your information or data?");
        aList.Add("A. Michigan");
        bList.Add("B. Hot");
        cList.Add("C. Cold");
        dList.Add("D. All the above");
        answerList.Add("B");
        correctList.Add("HOT SITES are used for businesses, government, or even your school to AUTOMATICALLY restart what they were doing. This is because everything was saved and AUTOMATICALLY sent over to their back-up location.");

        //Question 37 (True/False)
        questionList.Add("The 7 main ways to stop attacks are to have control physical and electronic access to systems, create strong passwords or hash or salt, multifactor authentication, account lockout controls, last logon notification, classifications, and educate others.");
        aList.Add("A. True");
        bList.Add("B. False");
        cList.Add("");
        dList.Add("");
        answerList.Add("A");
        correctList.Add("In all the questions you have answered, ALL the material discussed can be summarized in 7 main ways.");
    }
}
