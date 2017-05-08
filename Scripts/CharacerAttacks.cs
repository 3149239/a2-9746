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

    public bool gameStarted;        //Check if game has started
    public bool redFirst;           //Who will make the first move
    public bool oddRoll;            //Dice roll odd or even
    public bool betRed;             //bet red or blue
    public bool diceRolled;         //checks if dice has been rolled
    public bool bet10coins;         //player bets 10 or 25 coins
    public bool betOdd;             //player bet on odd;

    public Random myDice = new Random();   //new random for dice roll



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
            if (betRed == false)
            {

                if ((betOdd == true && oddRoll == true) || (betOdd == false && oddRoll == false))       //if the player guessed the dice roll correctly they will go first
                {
                    wizardFirst.text = "The BLUE wizard will attack first";
                    redFirst = true; //red wizard will attack first
                }

                else //if the player didnt guess the dice roll correctly they wont fo first
                {
                    wizardFirst.text = "The RED wizard will attack first";
                    redFirst = false; //blue wizard will attack first
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


    

}
