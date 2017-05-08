using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacerAttacks : MonoBehaviour
{

    public GameObject redWizard;    //Red Wizard
    public GameObject blueWizard;   //Blue Wizard
    public GameObject rockWeapon;   //Rock Bullet
    public GameObject waterWeapon;  //Water Bullet
    public GameObject fireWeapon;   //Fire Bullet

    public GameObject diceOutcomePanel;     //countdown panel after dice roll

    public Text diceOutcomeText;    //text to notify player of dice outcome
    public Text wizardFirst;        //text to notify player of which wizard attacks after
    public Text countdownTimer;     //text to notify player of when the game will start


    public float weaponPower;       //Bullet Strength
    public float redHealth;         //Red Wizard Health
    public float blueHealth;        //Blue Wizard Health
    public float myTimer;           //Game Timer
    public float myCountdownTimer;  //countdown timer
    public float attackTimer;       //timer between attacks

    public bool gameStarted;        //Check if game has started
    public bool redFirst;           //Who will make the first move
    public bool oddRoll;            //Dice roll odd or even
    public bool betRed;             //bet red or blue
    public bool diceRolled;         //checks if dice has been rolled
    public bool bet10coins;         //player bets 10 or 25 coins
    public bool betOdd;             //player bet on odd;
    public bool fightStart;         //triggers the fight to begin
    public bool firstAttacked;      //checks if the first wizard has just attacked
    public bool redAttacked;        //checks if red has just attacked

    public Random myDice = new Random();        //new random for dice roll
    public Random myRedAttack = new Random();   //new random for red attacks
    public Random myBlueAttack = new Random();  //new random for blue attacks



    // Use this for initialization
    void Start()
    {

        redHealth = 20f;            //Red Wizard starting health
        blueHealth = 20f;           //Blue Wizard starting health
        myTimer = 0f;               //Timer starts at 0
        myCountdownTimer = 6f;      //Countdown timer starts at 6 seconds
        weaponPower = 1f;           //Weapon power starts at 1
        gameStarted = false;        //has the game started
        oddRoll = false;            //dice roll is odd
        redFirst = false;           //red first go
        betRed = false;             //bet on red
        diceRolled = false;         //the dice has not yet been rolled
        bet10coins = true;          //sets 10 coins to default
        fightStart = false;         //the fight has not yet started
        attackTimer = 0;            //sets attack timer to 0


        diceOutcomePanel.SetActive(false);  //sets the dice outcome panel to false at the start
    }

    // Update is called once per frame (60fps)
    void FixedUpdate()
    {
        

        if (gameStarted == true)            //if the game has started
        {
            if (diceRolled == false)        //if the dice hasnt been rolled
            {
                MyGameStartRoll(myDice);    //roll the dice
                diceRolled = true;          //not to roll each frame, set the dice as rolled
            }

            diceOutcomePanel.SetActive(true);           //set the panel dice outcome to active

            countdownTimer.text = "the fight will start in: " + myCountdownTimer.ToString();        //sets countdown text to read contodwn timer

            myTimer += 1;               //timer counts 60 times a second (each frame)

            if (myTimer % 60 == 1)      //if the timer devided by 60 is 1, do:
            {
                myCountdownTimer -= 1;  //make the countdown timer go down by 1 each 60 frames (each second)
                attackTimer += 1;       //makes the attack timer go up each second
            }

            if (betRed == true)         //if the player bets on red to win
            {

                if ((betOdd == true && oddRoll == true) || (betOdd == false && oddRoll == false))     //if the player guessed the dice roll correctly they will go first
                {
                    wizardFirst.text = "The RED wizard will attack first";
                    redFirst = true;    //red wizard will attack first
                }
                else
                {
                    wizardFirst.text = "The BLUE wizard will attack first";                             //if the player didnt guess the dice roll correctly they wont fo first
                    redFirst = false;   //blue wizard will attack first
                }

            }
            if (betRed == false)        //if the player bets on blue to win
            {

                if ((betOdd == true && oddRoll == true) || (betOdd == false && oddRoll == false))       //if the player guessed the dice roll correctly they will go first
                {
                    wizardFirst.text = "The BLUE wizard will attack first";
                    redFirst = false;   //red wizard will attack first
                }

                else                    //if the player didnt guess the dice roll correctly they wont fo first
                {
                    wizardFirst.text = "The RED wizard will attack first";
                    redFirst = true;    //blue wizard will attack first
                }

            }

            if (myCountdownTimer == 0)             //if the timer reaches zero
            {
                myCountdownTimer = 100;            //set timer to 100
                fightStart = true;                 //start the fight
            }

            if (fightStart == true)                //if the fight has started
            {
                diceOutcomePanel.SetActive(false); //sets the panel to not active

                if (redFirst == true)              //if the red wizard is starting the fight
                {
                    if (myCountdownTimer % 6 == 1 && firstAttacked == false)      //every 6 seconds attack blue
                    {
                        redAttacked = false;       //says that red hasnt attacked yet
                        //redAttack();               //red attacks first
                        MyRedAttacks(myRedAttack);
                        firstAttacked = true;      //tells player its blue's turn to attack
                        attackTimer = 0;           //sets blue's attack timer to 0
                    }

                    else if (attackTimer == 3 && firstAttacked == true)          //3 seconds after red's attack, blue can now attack
                    {
                        redAttacked = true;        //says that red has already attacked
                        //blueAttack();              //blue can attack
                        MyBlueAttacks(myBlueAttack);
                        firstAttacked = false;     //says the second wizard has attacks
                    }
                }
                if (redFirst == false)             //if the blue wizard is starting the fight
                {
                    if (myCountdownTimer % 6 == 1 && firstAttacked == false)      //every 6 seconds attack red
                    {
                        redAttacked = true;        //says that red has already attacked
                        //blueAttack();              //blue attacks first
                        MyBlueAttacks(myBlueAttack);
                        firstAttacked = true;      //tells player its red's turn to attack
                        attackTimer = 0;           //sets red's attack timer to 0
                    }

                    else if (attackTimer == 3 && firstAttacked == true)           //3 seconds after blue's attack, red can now attack
                    {
                        redAttacked = false;       //says that red hasnt attacked yet
                        //redAttack();               //red can attack
                        MyRedAttacks(myRedAttack);
                        firstAttacked = false;     //says the second wizard has attacks
                    }
                }
            }

        }
    }

    void MyGameStartRoll(Random myDice)             //dice roll
    {
        int computerPick;
        computerPick = Random.Range(1, 7);          //picks a random between 1 and 6

        oddRoll = computerPick % 2 == 1;            //if the number is odd or even
        
        Debug.Log(computerPick);                    //check with debug what the number is

        if (oddRoll == true)                        //the dice is odd
        {
            diceOutcomeText.text = "The dice rolled an ODD number";
        }
        if (oddRoll == false)                       //the dice is even
        {
            diceOutcomeText.text = "The dice rolled an EVEN number";
        }
    }

    void MyRedAttacks(Random myRedAttack)            //Red Wizard Attacks
    {
        int computerPick2;
        computerPick2 = Random.Range(1, 4);          //picks a random between 1 and 4

        Debug.Log(computerPick2);                    //check with debug what the number is
        Debug.Log("Red attacks");                    //says that red is attacking

        if (computerPick2 == 1)                      //if the random number chosen is 1 - use this attack
        {
            Instantiate(fireWeapon, new Vector3(-3, 0, 0), Quaternion.identity);     //red shoots fire
        }
        if (computerPick2 == 2)                      //if the random number chosen is 2 - use this attack
        {
            Instantiate(rockWeapon, new Vector3(-3, 0, 0), Quaternion.identity);     //red shoots rock
        }
        if (computerPick2 == 3)                      //if the random number chosen is 3 - use this attack
        {
            Instantiate(waterWeapon, new Vector3(-3, 0, 0), Quaternion.identity);     //red shoots water
        }
    }

    void MyBlueAttacks(Random myBlueAttack)          //Blue Wizard Attacks
    {
        int computerPick3;
        computerPick3 = Random.Range(1, 4);          //picks a random between 1 and 4

        Debug.Log(computerPick3);                    //check with debug what the number is
        Debug.Log("Blue attacks");                   //says that blue is attacking

        if (computerPick3 == 1)                      //if the random number chosen is 1 - use this attack
        {
            Instantiate(fireWeapon, new Vector3(2, 0, 0), Quaternion.identity);     //blue shoots fire
        }
        if (computerPick3 == 2)                      //if the random number chosen is 2 - use this attack
        {
            Instantiate(rockWeapon, new Vector3(2, 0, 0), Quaternion.identity);     //blue shoots rock
        }
        if (computerPick3 == 3)                      //if the random number chosen is 3 - use this attack
        {
            Instantiate(waterWeapon, new Vector3(2, 0, 0), Quaternion.identity);     //blue shoots water
        }
    }

    void redAttack ()       //red's attack
    {
        Debug.Log("Red attacks");
        
    }

    void blueAttack()       //blue's attack
    {
        Debug.Log("Blue attacks");
    }



}
