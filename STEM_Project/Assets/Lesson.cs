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
        lessonText.Add("CONFIDENTIALITY protects and prevents/minimizes uauthorized access to your information/data.");
        //5
        lessonText.Add("INTEGRITY protects the reliability and correctness of your information/data.");
        //6
        lessonText.Add("AVAILABILITY allows authorized users to access information/data in a timely manner.");

        //7 Question 3, 4, and 5
        lessonText.Add("To stop hackers/attackers our school further relies on the defense-in-depth approach that consists of 4 protective mechanisms; layering, abstraction, data hiding, & encryption.");
        //8
        lessonText.Add("LAYERING is also known as defense-in-depth and simply uses multiple controls in a series for security.");
        //9
        lessonText.Add("ABSTRACTION simplifies security by labeling security controls to objects and subjects.");
        //10
        lessonText.Add("DATA HIDING prevents important information/data from being found.");
        //11
        lessonText.Add("ENCRYPTION hides the messages meaning through text, audio, and video files.");
        //12
        lessonText.Add("Within these protective mechanisms are access controls that provide a defense-in-depth approach to stop hackers/attackers; deterrent, detection, recovery, directive, & compensate.");
        //13
        lessonText.Add("DETERRENT is used to discourage attacks or hacks of security, examples are cameras at school, teachers supervising, or fences.");
        //14
        lessonText.Add("DETECTION discover activity by unauthorized subjects, examples are filters that the schools IT team can place that alerts when certain innapropriate or unallowed words are used.");
        //15
        lessonText.Add("RECOVERY attempt to correct the attack/hack, examples are backups or anti-virus software.");
        //16
        lessonText.Add("DIRECTIVE controls a subjet to perform a certain task, examples are exit signs, security policy requirements, or rules by your teacher.");
        //17
        lessonText.Add("COMPENSATE are used to support security policies, example of this is making sure that the password you typed in is correct and encrypted.");

        //18 Question 6 and 7
        lessonText.Add("Whenever you use a school device you are assigned a username, password, occasionally a number that correlates to your device, & are always supervised to ensure your safety from hackers/attackers.");
        //19
        lessonText.Add("Your school uses “AAA Services”; authentication, authorize, & audit.");
        //20
        lessonText.Add("AUTHENTICATION verifies the claimed identity, example of this are passwords or pins.");
        //21
        lessonText.Add("AUTHORIZE ensures that the subject has proper rights/privileges to access object, example of this is a username or login ID number.");
        //22
        lessonText.Add("AUDIT monitors, tracks, and records the sujects actions to their safe and using the object for the intended use, an example of this is your teacher, principal, or IT person seeing your school work or username.");

        //23 Question 8
        lessonText.Add("No matter how secure our school is humans are the weakest link, this is because we by nature want to believe everyone is doing the right thing & trust them. Yet in order to ensure hackers/attackers are stopped we should have; separation of duties, job responsibilities, & job rotation.");
        //24
        lessonText.Add("SEPARATION OF DUTIES divides important and sensitive work tasks among the proper subject.");
        //25
        lessonText.Add("JOB RESPONSIBILITIES is the specific work task each subject is required to do on a daily basis.");
        //26
        lessonText.Add("JOB ROTATION moves subjects from different areas to improve overall security.");

        //27 Question 9 and 10
        lessonText.Add("The most dangerous cyberattacks in schools last year in 2019 were unauthorized access attacks.");
        //28
        lessonText.Add("UNAUTHORIZED ACCESS ATTACKS are when a subject who isnt suppose to use an object is allowed, examples of this can be stealing your badge, watching you type in your username and password, sending information/data to the wrong subject.");
        //29
        lessonText.Add("Similarly, large companies & the government face the same attack, this is partially because they have bad offboarding/firing protocol. Workers should give all the technology/equipment the employer gave them - phone, laptop, keys, badge & should be escorted out the door midweek at the end of their shift.");
        //30
        lessonText.Add("This will help reduce the danger of UNAUTHORIZES ACCESS ATTACKS to ensure the old subjects dont have access the objects, which creates a vulnerability and a threat. Which lead to risk.");

        //31 Question 11 and 12
        lessonText.Add("Some information is more important than other information & most of the time that information should be more secretive than other information. To organize all this information the school places levels of classification; top secret/proprietary, secret/private, confidential/sensitive, & unclassified/public.");
        //32
        lessonText.Add("TOP SECRET/PROPRIETARY is the highest level of classification of information/data and can cause grave damage if stolen, examples are your principal and parent seeing your address.");
        //33
        lessonText.Add("SECRET/PRIVATE is information/data that should stay private and could cause serious damage, examples are your principal, teacher, and parents seeing your medical information.");
        //34
        lessonText.Add("CONFIDENTIAL/SENSITIVE is information/data that can cause damage, examples are your principale, teacher, and parent seeing your grades.");
        //35
        lessonText.Add("UNCLASSIFIED/PUBLIC is information/data that is posted on websites and allow anyone to see it, example of this are listing what day parent/teacher conferences are.");

        //36 Question 13
        lessonText.Add("When using a school device in your classroom your using data and there are 3 main types of data - rest, transit, and use.");
        //37
        lessonText.Add(" DATA AT REST is your information/data that is on hard drives or USB drives, examples of this are school grades .");
        //38
        lessonText.Add("DATA IN TRANSIT is information/data in motion thats transmitted over a network, examples of this are information/data sent over the internet or Wi-Fi.");
        //39
        lessonText.Add("DATA IN USE is information/data held in memory while an object is using it, an example is your password remembered everytime you login to see your school assignment or grades.");

        //40 Question 14
        lessonText.Add("You have just been given book report to write & are on google looking information up but are on YouTube looking up other video game trailers. Halfway through the video your teacher is walking towards you, you quickly “X” out of the tab & delete your history. You think your safe & there is no way your teacher can find out what you were doing, but he/she can through - data remanence.");
        //41
        lessonText.Add("DATA REMANENCE is information/data that remains on your object the subject tried to erase.");
        //42
        lessonText.Add("You have left a digital footprint and your schools IT team can track that.");

        //43 Question 15 and 16
        lessonText.Add("The government or companies destroys top secret information, but will purge or degaussing secret/confidential information.");
        //44
        lessonText.Add("PURGING gets rid of information/data by repeating the clearing process mulitple times by re-writing over the original message.");
        //45 
        lessonText.Add("DEGAUSSING is using a strong magnetic field to erase data, this is done on magnetic tapes but CANT be used on hard disks.");

        //46 Question 17
        lessonText.Add("As discussed before, our school has ways to stop attacks; deter, deny, detect, & delay.");
        //47
        lessonText.Add("DELAY should slow down the attacker/hacker, an example is a lock on doors or your computer cart.");
        //48
        lessonText.Add("Some schools are further attempting to implement 2 types of authentication; card/QR & pin, which are something you have & something you know");

        //49 Question 18 and 19
        lessonText.Add("Layers of defense can be a mantrap, badge to show CCTB, & enter a pin before you enter.");
        //50 
        lessonText.Add("MANTRAP has a door a subject enters and another door for the exit at the front of a building, once inside the door locks and subject is stuck inside.");
        //51
        lessonText.Add("BADGE TO SHOW CCTV is something you have that you show a Closed Circuit TV that confirms you are who you say you are, an example is when you use your QR code or password to access your grades.");
        //52
        lessonText.Add("If your worried someone may be listening to a secret conversation you may be having, ways to stop this can be faraday cages or white noise.");
        //53
        lessonText.Add("FARADAY CAGE is a box/room that subjects can enter that is externallly covered with metal wire and acts as a electromagnetic interference absorbing capacitor, this cage stops electromagnetic signals to exit or enter. Your phone or laptop wont work and nobody can hack your devices.");
        //54
        lessonText.Add("WHITE NOISE is displaying fake traffic at all times to hide the real message");

        //55 Question 20
        lessonText.Add("Upon looking up information for your history assignment a new song comes on & you decide to put the song on Facebook & claim it as yours but then you remember your teacher saying defining copyrights, trademarks, patents, & criminal acts.");
        //56
        lessonText.Add("COPYRIGHTS are a law that protects the originator of the work that nobody can steal their work, an example is music, pictures, or sound recordigs.");
        //57
        lessonText.Add("TRADEMARKS are a law that protects the originator of the work that nobody can steal their work, an example are words, slogans or logos.");
        //58
        lessonText.Add("PATENTS are a law that protects the originator of the wokr that nobody can steal their work, an example of this are inventions.");
        //59
        lessonText.Add("CRIMINAL ACTS are high actions that are against the law and can include robbery, arson, & includes cyber attacks like stealing passwords or information/data.");

        //60 Final Message
        lessonText.Add("As a student you should ALWAYS be aware of dangers while using technology and in order to ensure your safety proper layers of defense and monitoring techniques are used. If you notice any problems or signs of attack/hacks then you should tell your teacher IMMEDIATELY.");

        //61 Question 1
        lessonText.Add("Depending the system, your school has certain security designs that are open and closed.");
        //62 
        lessonText.Add("OPEN SYSTEMS allow any subject to acccess the object, examples are your schools website or your schools social media page.");
        //63
        lessonText.Add("CLOSED SYSTES allow certain subject to access the object, examples are your school grades or teachers computer");

        //64 Question 2
        lessonText.Add("As you know from stated before defense-in-depth is the best approach to stopping hackers/attackers. Specifically, Jenison IT protects your technological devices through - trusted computing base, security perimeter, & reference monitor");
        //65
        lessonText.Add("TRUSTED COMPUTING BASE/TCB control access to the system and consist of hardware/software.");
        //66
        lessonText.Add("SECURITY PERIMETER separates the TCB from the rest of your system, examples of this can be firewalls, detective, or compensative controls.");
        //67
        lessonText.Add("REFERENCE MONITOR enforces access controls and validates certain subjects to access the object, examples of this are logging in with your password, PIN, ID badge, or QR code.");
        //68
        lessonText.Add("");

        //69 Question 3
        lessonText.Add("QUICK! REMEMBER, the CIA triad!?");

        //70 Question 4
        lessonText.Add("The government and companies have 2 main ways to share information - the Bell LaPadulaa Model and the Biba Model.");
        //71 
        lessonText.Add("BELL-LAPADULA is used by the US Department of Defense and allows subjects to write UP to those with higher clearance/data classification levels and read DOWN to those with lower clearance/data classification levels.");
        //72
        lessonText.Add("BIBA is used by companies and allows subjects to write DOWN to those with lower clearance/data classification levels and read UP those with higher clearance/data classification levels.");

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
        lessonText.Add("SECONDARY is long-term storage that you can use everyday, examples are your passwords saved to access your grades.");
        //79
        lessonText.Add("VOLATILE measures how likely an object will lose its memory, this can be considered RAM.");
        //80
        lessonText.Add("NON-VOLATILE retain their information/data on the object, this can be considered ROM, which keeps you passwords or essay saved after you type it and can be seen by your schools IT team.");

        //81 Question 8, 9, 10, and 11
        lessonText.Add("Any object you use has the ability access software as a service - SAAS or a data warehouse, which can be restricted a public or community setting.");
        //82
        lessonText.Add("SAAS gives subject online access to a certain software service that saves all your information data.");
        //83
        lessonText.Add("PUBLIC can be set in SAAS for your entire class to see and use your information/data.");
        //84
        lessonText.Add("COMMUNITY can be set in SAAS for a few members in your group if your teacher assigns your to a group project.");
        //85
        lessonText.Add("DATA WAREHOUSE store large amounts of information/data, examples of information/data that are stored are your password, address, or middle name.");

        //86 Question 12
        lessonText.Add("To ensure your safety, your school keeps you safe is by setting certain password rules and restrictions.");
        //87
        lessonText.Add("PASSWORD RULES AND RESTRICTIONS your school may have are that you need to have atleast 12 characters, symbols, numbers, or uppercase letters in your password. Also that they MUST be reset every 30 days.");

        //88 Question 13 
        lessonText.Add("Other ways your school keeps you safe is by having in place intrusion detection/prevention systems -IDS/IPS.");
        //89
        lessonText.Add("INTRUSION DETECTION SYSTEMS - IDS monitor recorded information as they happen live, the goal is to have timely and accurate responses to attacks/hacks.");
        //90
        lessonText.Add("INTRUSION PREVENTION SYSTEMS - IPS extend what IDS does and attempt to block attacks/hackers by standing in the way. Example of this are honeypots, honeypots are fake accounts/database that have fake information/data that if an attacker/hacker finds, they are trapped and your school will be alerted.");

        //91 Question 14
        lessonText.Add("Another way your school can keep you safe while using technological devices/objects, is by having firewalls.");
        //92
        lessonText.Add("FIREWALLS give you protection as you use your techological device/object through filtering traffic in either 1, 2, or 3 tiers. The higher the tier, the more filters/layers of defense are in place.");

        //93 Question 15
        lessonText.Add("Schools have different ways to set up the physical layout of their network, also called topology. The main topologies used are star, tree, ring, and linear.");

        //94 Question 1
        lessonText.Add("There are so many types of attacks with the advancements of technology, but as stated before, for schools the most dangerous attack are unauthorized access attacks. Unfortunately subject allow this because humans are the most WEAKEST link.");

        //95 Question 2
        lessonText.Add("Other types of attacks that humans open themselves up to are poor passwords & social engineering.");
        //96
        lessonText.Add("POOR PASSWORDS may be 12345, password, football, or letmein.");
        //97
        lessonText.Add("SOCIAL ENGINEERING is part of unauthorized access and is the ability to gain access to a subjects object by decieving, lying, or just asking the subject for personal information.");

        //98 Question 3
        lessonText.Add("Another popular attack is when you the subject are communicating with the computer an object, you are still open to attacks like; SYN flood attack, man-in-the-middle.");
        //99
        lessonText.Add("SYN FLOOD ATTACK is a form of denial-of-service that chooses a subject and FLOODs their object with messages and traffic crashes the object, causing the subject to not be able to act on the object.");
        //100
        lessonText.Add("MAN-IN-THE-MIDDLE is simply an attacker/hacker that waits between you the subject and another subject your are trying to message or your object is trying to communicate with.");

        //101 Question 4, 5, 6, and 7
        lessonText.Add("As learned before, layers of defense is the best way to stop hackers/attackers. This consists of the Open Systems Interconnection (OSI) model, which is the framework of how protocols should function. Also this is how OSI communicates with eachother by encpasulating data starting with the Application layer and traveling down to the Physical layer.");
        //102
        lessonText.Add("APPLICATION layer determines if the object is available to communicate with, examples of this are hypertext transfer protocol (HTTP) or simple mail transfer protocol (SMTP).");
        //103
        lessonText.Add("PRESENTATION layer transforms data into something one can understand and encrypts it, an example of this are joint photographic experts group (JPEG) or tagged image file format (TIFF).");
        //104
        lessonText.Add("TRANSPORT layer establishes the lines of connection for communication and creates the SYN/ACK 3-way handshake. This is also where SYN flood attacks occur.");
        //105
        lessonText.Add("NETWORK layer holds the address information and is responsible for delivering information, an example of this is IP addresses.");
        //106
        lessonText.Add("PHYISCAL layer consists of any hardware-based signal operations - hubs, repeaters, or amplifiers.");

        //107 Question 8, 9, 10
        lessonText.Add("Today there are 3 types of passwords; something you know, have, & are.");
        //108
        lessonText.Add("SOMETHING YOU KNOW can be a memorized password, an example is iL1KEGAM3ZZZ.");
        //109
        lessonText.Add("SOMETHING YOU HAVE can be a QR code, ID badge, or ID number card.");
        //110
        lessonText.Add("SOMETHING YOU ARE can be biometrics - which is emerging as a STRONG option for schools, companies, and the government.");
        //111
        lessonText.Add("BIOMETRICS cant be lost or forgotten like a badge or password, it is YOU! Examples are - fingerprints, face scans, voice patter recognition, heart patterns, & the strongest retinal scanners.");

        //112
        lessonText.Add("BIOMETRICS strength depends on the accuracy and the 2 rates are false rejection and false acceptance rates.");
        //113
        lessonText.Add("FALSE REJECTION are set to be sensitive and sometimes dont let valid subjects to access objects.");
        //114
        lessonText.Add("FALSE ACCEPTANCE are set to be less sensitive and sometimes let INVALID subjects to access objects.");
        //115
        lessonText.Add("Your school is worried about people stealing others passwords so they incorporate a 3-attempt limit to typing in your password, this creates a type I error/false rejection & is very sensitive.");

        //116 Question 11 and 12
        lessonText.Add("Occasionally audits will occur and can be done either internally or externally, if done externally they are done by pen testers. Options of pen tests are either type 1 or type 2 and a white or black pen test.");
        //117
        lessonText.Add("PEN TEST are ethical/allowed hackers that JOB is to attack/hack an object to determine if they are secure.");
        //118
        lessonText.Add("TYPE 1 audit a SINGLE point in time.");
        //119
        lessonText.Add("TYPE 2 audit can cover MINIMUM 6-months.");
        //120
        lessonText.Add("WHITE pen tests give the attacker/hacker ALL the information to attack/hack.");
        //121
        lessonText.Add("BLACK pen tests give the attacker/hacker NONE of the information to attack/hack.");

        //122 Question 13 and 14
        lessonText.Add("Remember SYN/ACK 3-way handshake? Well pen testers can access this to see what ports are open, this test is called a Xmas attack.");
        //123
        lessonText.Add("XMAS attack the pen tester sends a message to find all open ports, which shows vulnerabilities and can lead to threats.");

        //124 Question 15, 16, and 17
        lessonText.Add("As you learned before the CIA, AAA, & data states protection occurs throughout, this is done through encryption.");
        //125
        lessonText.Add("Further is called cryptography which has 2 main ways of encrypting your passwords - symmetric & asymmetric.");
        //126
        lessonText.Add("SYMMETRIC crytography rely on shared key messaging. The sender encrypts a message with a SHARED key and the reciever decrypts it with that SHARED key.");
        //127
        lessonText.Add("ASYMMETRIC cryogrpahy rely on PUBLIC keys, each user has their OWN private key. The sender encrypts a message with a SHARED key and the reciever decrypts it with a PRIVATE key.");

        //128 Question 18 and 19
        lessonText.Add("Student gets an alert that you are about to lose power, what should you do?");
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
        lessonText.Add("FAILOVER CLUSTERS are added supportive security to protect crtical servers.");
        //135
        lessonText.Add("BANDWIDTH is the limit that frequencies can transmit and can be extended or shortened. Examples that use bandwidth are streaming vidoes or music.");
        //136
        lessonText.Add("LATENCY is the delty before data is sent and can vary from fast or slow, depending on the object.");

        //137 Question 20
        lessonText.Add("In summary of everything discussed in the game, their are 7 main ways to stop attacks - have control physical and electronic access to systems, create strong passwords or hash or salt, multifactor authentication, account lockout controls, last logon notification, classifications, and educate others.");
    }
}
