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


    float weaponPower;              //Bullet Strength
    float redHealth;                //Red Wizard Health
    float blueHealth;               //Blue Wizard Health
    float myTimer;                  //Game Timer

    public bool gameStarted;               //Check if game has started
    bool redFirst;                  //Who will make the first move
    public bool oddRoll;            //Dice roll odd or even
    bool betRed;                    //bet red or blue

    Random myDice = new Random();   //new random for dice roll



    // Use this for initialization
    void Start()
    {

        redHealth = 20f;            //Red Wizard starting health
        blueHealth = 20f;           //Blue Wizard starting health
        myTimer = 0f;               //Timer starts at 0
        weaponPower = 1f;           //Weapon power starts at 1
        gameStarted = false;        //has the game started
        oddRoll = false;            //dice roll is odd
        redFirst = false;           //red first go
        betRed = false;             //bet on red



    }

    // Update is called once per frame (60fps)
    void FixedUpdate()
    {

        if (gameStarted == false)
        {
            MyGameStartRoll(myDice);
        }
    }

    void MyGameStartRoll(Random myDice)
    {
        int computerPick;
        computerPick = Random.Range(1, 7);

        oddRoll = computerPick % 2 == 1;
    }


    

}
