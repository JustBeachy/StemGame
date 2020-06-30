using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson : MonoBehaviour
{
    public List<int> lessonsToDisplay;
    public GameObject textObject;
    public List<string> lessonText = new List<string>();

    // Start is called before the first frame update
    void Awake()
    {
        
    
        LoadLessons();






        FillText();

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void FillText()
    {
        lessonsToDisplay = GameObject.FindGameObjectWithTag("Controller").GetComponent<Controller>().ListOfLessons;

        for(int i=0; i<lessonsToDisplay.Count;i++)
        {
           
            textObject.GetComponent<Text>().text += lessonText[lessonsToDisplay[i]]+"\n"+"\n";

        }
    }

    void LoadLessons()
    {
        //0 Question 1
        lessonText.Add("Whenever using technology at school, you are either the object or the subject.");
        //1
        lessonText.Add("OBJECTS are the passive element in a security relationship, such as computers or phones.");
        //2
        lessonText.Add("SUBJECTS are the active element in the security relationship, such as users or people.");

        //3 Question 2
        lessonText.Add("Our school security starts out with focusing on 3 main ideas: confidentiality, integrity, and availability.");
        //4
        lessonText.Add("CONFIDENTIALITY protects and prevents/minimizes unauthorized access to your information/data.");
        //5
        lessonText.Add("INTEGRITY protects the reliability and correctness of your information/data.");
        //6
        lessonText.Add("AVAILABILITY allows authorized users to access information/data in a timely manner.");

        //7 Question 3, 4, and 5
        lessonText.Add("To stop hackers/attackers our school further relies on a 4 layer defense-in-depth approach; layering, abstraction, data hiding, & encryption.");
        //8
        lessonText.Add("LAYERING (defense-in-depth) and uses multiple controls for stronger security.");
        //9
        lessonText.Add("ABSTRACTION labels all the objects and subjects.");
        //10
        lessonText.Add("DATA HIDING prevents important information/data from being found.");
        //11
        lessonText.Add("ENCRYPTION hides the messages meaning through text, audio, and video files.");
        //12
        lessonText.Add("Further layers of defense to stop hackers/attackers used are called access controls; deterrent, detection, recovery, & directive.");
        //13
        lessonText.Add("DETERRENT is used to discourage attackers/hackers (Examples are cameras at school, teachers supervising, or fences).");
        //14
        lessonText.Add("DETECTION discover activity by unauthorized subjects (Examples are filters that the schools IT team use to alert them if innapropriate behavior is performed).");
        //15
        lessonText.Add("RECOVERY attempt to correct the attack/hack (Examples are backups or anti-virus software).");
        //16
        lessonText.Add("DIRECTIVE tells a subject to perform a certain task (Examples are exit sign or rules by your teacher).");
        //17
        lessonText.Add("COMPENSATE are used to support security policies, example of this is making sure that the password you typed in is correct and encrypted.");

        //18 Question 6 and 7
        lessonText.Add("At school you are assigned a username, password, sometimes a number that connects YOU to your device, & are always supervised to ensure your safety.");
        //19
        lessonText.Add("Your school uses “AAA Services”; authentication, authorize, & audit.");
        //20
        lessonText.Add("AUTHENTICATION verifies the claimed identity (Example of this are passwords or pins).");
        //21
        lessonText.Add("AUTHORIZE ensures that the subject has proper rights/privileges to access the object (Example of this is a username or login ID number).");
        //22
        lessonText.Add("AUDIT monitors and tracks the subjects actions to make sure their doing what their teacher asked (Example of who can audit you is your teacher, principal, or IT person).");

        //23 Question 8
        lessonText.Add("No matter how secure our school is, humans are the weakest link! We by nature want to believe everyone is doing the right thing & trust them.");
        //24
        lessonText.Add("SEPARATION OF DUTIES divides important jobs among the proper subject.");
        //25
        lessonText.Add("JOB RESPONSIBILITIES is the specific work task each subject is required to do everyday.");
        //26
        lessonText.Add("JOB ROTATION moves subjects from different areas to improve overall security.");

        //27 Question 9 and 10
        lessonText.Add("The most dangerous cyberattacks in schools last year in 2019 were unauthorized access attacks.");
        //28
        lessonText.Add("UNAUTHORIZED ACCESS ATTACKS are when a subject who isnt suppose to use an object is allowed (Examples of this can be stealing your badge or someone watching you type in your username and password).");
        //29
        lessonText.Add("Similarly, large companies & the government face the same attack, this is partially because they have bad offboarding/firing protocol. Workers should give all the technology/equipment the employer gave them - phone, laptop, keys, badge & should be escorted out the door midweek at the end of their shift.");
        //30
        lessonText.Add("UNAUTHORIZED ACCESS ATTACKS can occur from a vulnerabitly, which leads to a threat, and equals a risk.");

        //31 Question 11 and 12
        lessonText.Add("All information used at your school has different levels of of importance and secrecy. They can be divided into; top secret, secret/private, sensitive, & public.");
        //32
        lessonText.Add("TOP SECRET is the highest level and can cause grave damage if stolen (Examples are your principal and parent seeing your address).");
        //33
        lessonText.Add("SECRET/PRIVATE can be your medical information and shouldnt be shared but your principal, teacher, and parents.");
        //34
        lessonText.Add("SENSITIVE information/data can be your grades.");
        //35
        lessonText.Add("PUBLIC is information/data posted on websites (Example of this are listing what day parent/teacher conferences are).");

        //36 Question 13
        lessonText.Add("When using a school device at school, your using data and there are 3 main types of data - rest, transit, and use.");
        //37
        lessonText.Add("DATA AT REST is your information/data that is on hard drives or USB drives (An example is your school grades).");
        //38
        lessonText.Add("DATA IN TRANSIT is information/data in motion thats transmitted over a network (An example of this is information/data sent over the internet or Wi-Fi.");
        //39
        lessonText.Add("DATA IN USE is information/data held in memory (An example is your password that is saved so you can see your school assignment or grades).");

        //40 Question 14
        lessonText.Add("Imagine you are in class and you have been given a book report. After 10 minutes of researching your topic, you start youtubing video games. Halfway through your video game video your teacher is about to walk by! You quickly close youtube and delete your history....Your safe, right? No, your not, because of - data remanence.");
        //41
        lessonText.Add("DATA REMANENCE is information/data that remains on your object the subject tried to erase.");
        //42
        lessonText.Add("You have left a digital footprint and your schools IT team can track that!");

        //43 Question 15 and 16
        lessonText.Add("The government or companies destroys top secret information, but will purge or degauss secret information.");
        //44
        lessonText.Add("PURGING writes over the original message multiple times.");
        //45 
        lessonText.Add("DEGAUSSING uses a strong magnetic field to erase data, this is done on magnetic tapes but CANT be used on hard disks.");

        //46 Question 17
        lessonText.Add("As discussed before, our school has ways to stop attacks; deter, deny, detect, & delay.");
        //47
        lessonText.Add("DELAY should slow down the attacker/hacker (An example is a lock on doors or on your computer cart).");
        //48
        lessonText.Add("Ever heard of 2 - factor authentication? (Helps make you MORE safe) Well that includes using your card/QR & pin, which are something you have & something you know.");

        //49 Question 18 and 19
        lessonText.Add("Layers of defense can be a mantrap, badge to show CCTB, & enter a pin before you enter.");
        //50 
        lessonText.Add("MANTRAP locks a subject in a small room and is let out if the subject isnt an attacker/hacker.");
        //51
        lessonText.Add("BADGE TO SHOW Close Circuit TV is similar to when using a QR code scanner and confirms who you say you are (Example is if you want to see your grades.");
        //52
        lessonText.Add("If your worried someone may be listening to a secret conversation you may be having, ways to stop this can be faraday cages or white noise.");
        //53
        lessonText.Add("FARADAY CAGE is a box/room that subjects can enter and has metal wire on the outside and stops all electronmagnetic signals, your phone/laptop wont work in here.");
        //54
        lessonText.Add("WHITE NOISE has fake signals at all times to hide the real message.");

        //55 Question 20
        lessonText.Add("Upon looking up information for your history assignment, you find a new song and post it on instagram saying its yours. Then you remember what your teacher said there are laws that protect the originator from anyone stealing their work; copyrights, trademarks, patents, & criminal acts.");
        //56
        lessonText.Add("COPYRIGHTS protect music or pictures.");
        //57
        lessonText.Add("TRADEMARKS protects words, slogans or logos.");
        //58
        lessonText.Add("PATENTS protect inventions.");
        //59
        lessonText.Add("CRIMINAL ACTS are actions that are against the law and can include robbery, arson, & includes cyber attacks like stealing passwords or information/data.");

        //60 Final Message
        lessonText.Add("As a student you should ALWAYS be aware of dangers while using technology and in order to ensure your safety proper layers of defense and monitoring techniques are used. If you notice any problems or signs of attack/hacks then you should tell your teacher IMMEDIATELY.");

        //61 Question 1
        lessonText.Add("Depending the system, your school has certain security designs that are open and closed.");
        //62 
        lessonText.Add("OPEN SYSTEMS allow ANY subject to acccess the object (Examples are your schools website or your schools social media page).");
        //63
        lessonText.Add("CLOSED SYSTEMS allow CERTAIN subject to access the object (Examples are your school grades or your teachers computer).");

        //64 Question 2
        lessonText.Add("Jenison IT protects your technological devices through - trusted computing base, security perimeter, & reference monitor");
        //65
        lessonText.Add("TRUSTED COMPUTING BASE/TCB control access to the system and consist of hardware/software.");
        //66
        lessonText.Add("SECURITY PERIMETER sits on the outside and separates the TCB from the rest of your system (Examples of this can be firewalls or detective controls.");
        //67
        lessonText.Add("REFERENCE MONITOR is like the security guard and allows certain subjects to access the object (Examples of this are logging in with your password, PIN, ID badge, or QR code).");
        //68
        lessonText.Add("");

        //69 Question 3
        lessonText.Add("QUICK! REMEMBER, the CIA triad!?");

        //70 Question 4
        lessonText.Add("The government and companies have 2 main ways to share information - the Bell LaPadulaa Model and the Biba Model.");
        //71 
        lessonText.Add("BELL-LAPADULA is used by the US Department of Defense and allows subjects to write UP to those with higher clearance levels and read DOWN to those with lower clearance levels.");
        //72
        lessonText.Add("BIBA is used by companies and allows subjects to write DOWN to those with lower clearance levels and read UP those with higher clearance levels.");

        //73 Question 5
        lessonText.Add("All technological devices have 2 main types of memory - ROM and RAM.");
        //74
        lessonText.Add("READ ONLY MEMORY is the memory your object can read but cant write on");
        //75
        lessonText.Add("RANDOM ACCESS MEMORY is the memory that is readable and writable, but when power is GONE, the memory is lost.");

        //76 Question 6 and 7
        lessonText.Add("Memory on your technological device/object are either primary or secondary.");
        //77
        lessonText.Add("PRIMARY keeps information/data for the subject while the object has power.");
        //78
        lessonText.Add("SECONDARY is long-term storage that you can use everyday (An example are your passwords saved).");
        //79
        lessonText.Add("VOLATILE measures how likely an object will lose its memory (This can be RAM).");
        //80
        lessonText.Add("NON-VOLATILE keep their information/data on the object (This can be ROM and your schools IT team can track).");

        //81 Question 8, 9, 10, and 11
        lessonText.Add("Any object you use has the ability access software as a service - SAAS or a data warehouse, which can be limited to a public or community setting.");
        //82
        lessonText.Add("SAAS gives the subject online access and saves all your information/data.");
        //83
        lessonText.Add("PUBLIC lets the entire class see and use your information/data.");
        //84
        lessonText.Add("COMMUNITY lets only a few members in your group to use your information/data.");
        //85
        lessonText.Add("DATA WAREHOUSE store large amounts of information/data (Examples are information/data stored like your password, address, or middle name.");

        //86 Question 12
        lessonText.Add("To ensure your safety, your school keeps you safe is by setting certain password rules and restrictions.");
        //87
        lessonText.Add("PASSWORD RULES AND RESTRICTIONS your school may have are that you need to have atleast 12 characters, symbols, numbers, or uppercase letters in your password. Also that they MUST be reset every 30 days.");

        //88 Question 13 
        lessonText.Add("Other ways your school keeps you safe is by having in place intrusion detection/prevention systems -IDS/IPS.");
        //89
        lessonText.Add("INTRUSION DETECTION SYSTEMS - IDS monitor and records information as they happen live!");
        //90
        lessonText.Add("INTRUSION PREVENTION SYSTEMS - IPS extend what IDS does and block attacks/hackers by standing in there way with updates.");

        //91 Question 14
        lessonText.Add("Have you ever heard of firewalls?");
        //92
        lessonText.Add("FIREWALLS give you protection as you use your techological device/object through filtering traffic in either 1, 2, or 3 tiers. The higher the tier, the more filters/layers of defense are in place.");

        //93 Question 15
        lessonText.Add("Schools have different ways to set up the physical layout of their network, also called topology. The main topologies used are star, tree, ring, and linear.");

        //94 Question 1
        lessonText.Add("For schools the most dangerous attack are unauthorized access attacks! Unfortunately subject allow this because humans are the most WEAKEST link.");

        //95 Question 2
        lessonText.Add("Other types of attacks that humans are weak to are - poor passwords & social engineering.");
        //96
        lessonText.Add("POOR PASSWORDS may be 12345, password, football, or letmein.");
        //97
        lessonText.Add("SOCIAL ENGINEERING tricks and lie to subjects to give them information/data! Their used in phishing emails.");

        //98 Question 3
        lessonText.Add("Another popular attack is when you (subject) are communicating with the computer (object). This is called either; SYN flood attack, man-in-the-middle.");
        //99
        lessonText.Add("SYN FLOOD ATTACK chooses a subject and FLOODs their object with messages and traffic crashes the object.");
        //100
        lessonText.Add("MAN-IN-THE-MIDDLE is simply an attacker/hacker that waits to steal your information/data and sits between you and another subject.");

        //101 Question 4, 5, 6, and 7
        lessonText.Add("Open Systems Interconnection (OSI) model allow technological devices to communicate with eachother through encapsulation. Data is encapsualted from Application layer to the Physical layer.");
        //102
        lessonText.Add("APPLICATION layer determines if the object is available to communicate with.");
        //103
        lessonText.Add("PRESENTATION layer transforms data into something one can understand and encrypts it (An example is an joint photographic experts group (JPEG).");
        //104
        lessonText.Add("TRANSPORT layer establishes the lines of communication and creates the SYN/ACK 3-way handshake. This is also where SYN flood attacks occur.");
        //105
        lessonText.Add("NETWORK layer holds the address information (An example of this is IP addresses).");
        //106
        lessonText.Add("PHYISCAL layer consists of any hardware-based signal operations - hubs, repeaters, or amplifiers.");

        //107 Question 8, 9, 10
        lessonText.Add("Today there are 3 types of passwords; something you know, have, & are.");
        //108
        lessonText.Add("SOMETHING YOU KNOW can be a memorized password (Example is iL1KEGAM3ZZZ).");
        //109
        lessonText.Add("SOMETHING YOU HAVE can be a QR code, ID badge, or ID number card.");
        //110
        lessonText.Add("SOMETHING YOU ARE can be biometrics - which is a STRONG option for schools, companies, and the government.");
        //111
        lessonText.Add("BIOMETRICS cant be lost or forgotten like a badge or password, it is YOU! (Examples are - fingerprints, heart patterns, & the strongest retinal scanners).");

        //112
        lessonText.Add("BIOMETRICS strength depends on the accuracy and the 2 rates are false rejection and false acceptance rates.");
        //113
        lessonText.Add("FALSE REJECTION are set to be sensitive and sometimes dont let the REAL subjects to access objects.");
        //114
        lessonText.Add("FALSE ACCEPTANCE are set to be less sensitive and sometimes let FAKE subjects to access objects.");
        //115
        lessonText.Add("Your school is worried about password stealing, so they use a 3-attempt limit to typing in your password (This creates a type I error/false rejection & is very sensitive).");

        //116 Question 11 and 12
        lessonText.Add("Occasionally audits or pen tests will occur and can be done either internally or externally. Options of pen tests are either type 1 or type 2 and a white or black pen test.");
        //117
        lessonText.Add("PEN TEST are ethical/allowed hackers thats JOB is to attack/hack an object to determine if they are secure!");
        //118
        lessonText.Add("TYPE 1 audit a SINGLE point in time.");
        //119
        lessonText.Add("TYPE 2 audit can cover MINIMUM 6-months.");
        //120
        lessonText.Add("WHITE pen tests give the attacker/hacker A LOT of the information to attack/hack.");
        //121
        lessonText.Add("BLACK pen tests give the attacker/hacker NONE of the information to attack/hack.");

        //122 Question 13 and 14
        lessonText.Add("Remember SYN/ACK 3-way handshake? Well pen testers can access this to see what ports are open, this test is called a Xmas attack.");
        //123
        lessonText.Add("XMAS attack the pen tester sends a message to find all open ports, which shows vulnerabilities and can lead to threats.");

        //124 Question 15, 16, and 17
        lessonText.Add("As you learned before; CIA, AAA, & data states protection happens through encryption.");
        //125
        lessonText.Add("This encryption can be called CRYPTORGRAPHY, which has 2 main ways of encrypting your passwords - symmetric & asymmetric.");
        //126
        lessonText.Add("SYMMETRIC cryptography share keys. The sender encrypts a message with a SHARED key and the reciever decrypts it with that SHARED key.");
        //127
        lessonText.Add("ASYMMETRIC cryptography dont share keys. Each user has their OWN private key and decrypts the message with their OWN private key.");

        //128 Question 18 and 19
        lessonText.Add("Imagine you get an alert that you are about to lose power, what should you do?");
        //129
        lessonText.Add("The student should quick save!");
        //130
        lessonText.Add("Schools, companies, and governments have backup/recovery building in case they lose power or dont have access to their information/data. These are called - hot or cold sites.");
        //131
        lessonText.Add("HOT SITES are the most expensive, fastest, & realistic building.");
        //132
        lessonText.Add("COLD SITES are cheapest, slowest, & outline of what your original building has.");
        //133
        lessonText.Add("These sites can include failover cluster, extra bandwidth, & quicker latency.");
        //134
        lessonText.Add("FAILOVER CLUSTERS are added supportive security to protect important servers.");
        //135
        lessonText.Add("BANDWIDTH is the limit that frequencies can transmit and can be extended or shortened (Examples that use bandwidth are streaming vidoes or music).");
        //136
        lessonText.Add("LATENCY is the delay before data is sent and can vary from fast or slow.");

        //137 Question 20
        lessonText.Add("In summary of everything discussed in the game, their are 7 main ways to stop attacks - have control physical and electronic access to systems, create strong passwords or hash or salt, multifactor authentication, account lockout controls, last logon notification, classifications, and educate others.");
    }
}
