using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents : MonoBehaviour
{

    public GameObject whoToWinPanel;    //First panel
    public GameObject betSizePanel;     //Second Panel
    public GameObject diceRollPanel;    //Third Panel
    public GameObject healthPanel;      //Forth Panel
    public GameObject winScreen;        //win screen
    public GameObject loseScreen;       //loose screen

    public bool startNewGame;           //starts new game

    public CharacerAttacks myCharacterAttacks;      //assign character attacks script

    // Use this for initialization
    void Start ()
    {
        myCharacterAttacks = GameObject.Find("Scripts").GetComponent<CharacerAttacks>();        //attaches script to mycharacterattacks

        whoToWinPanel.SetActive(true);      //sets first screen to show up at the start of the game 

        startNewGame = false;               //dont start new game
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (startNewGame == true)           //starts new game
        {
            whoToWinPanel.SetActive(true);  //starts first panel to active
            winScreen.SetActive(false);     //sets win screen to not active
            loseScreen.SetActive(false);    //sets lose screen to not active
            healthPanel.SetActive(false);   //sets health panel to not active
            myCharacterAttacks.redHealth = 100;     //sets red health back to 100
            myCharacterAttacks.blueHealth = 100;    //sets blue health back to 100
            myCharacterAttacks.myCountdownTimer = 6;
            startNewGame = false;
        }
		
	}

    public void ChangeToBetSizeRed()        //Sets panels to active or hidden
    {
        whoToWinPanel.SetActive(false);
        betSizePanel.SetActive(true);
        myCharacterAttacks.betRed = true;   //says the player bets on red to win
    }

    public void ChangeToBetSizeBlue()       //Sets panels to active or hidden
    {
        whoToWinPanel.SetActive(false);
        betSizePanel.SetActive(true);
        myCharacterAttacks.betRed = false;  //says the player bets on blue to win
    }

    public void ChangeToDiceRoll10()        //Sets gameobjects to active or hidden
    {
        betSizePanel.SetActive(false);
        diceRollPanel.SetActive(true);
        myCharacterAttacks.bet10coins = true;       //says the player chose to bet 10 coins
        myCharacterAttacks.playerCoins -= 10;       //takes 10 coins from the player
    }
    public void ChangeToDiceRoll25()                //Sets gameobjects to active or hidden
    {
        betSizePanel.SetActive(false);
        diceRollPanel.SetActive(true);
        myCharacterAttacks.bet10coins = false;       //says the player chose to bet 25 coins
        myCharacterAttacks.playerCoins -= 25;        //takes 25 coins from the player
    }
    public void ChangeToHealthOdd()                  //Sets gameobjects to active or hidden
    {
        diceRollPanel.SetActive(false);
        healthPanel.SetActive(true);
        myCharacterAttacks.betOdd = true;            //says the player thinks the dice roll will be odd
        myCharacterAttacks.gameStarted = true;       // tells character attacks to start running the game
    }
    public void ChangeToHealthEven()                 //Sets gameobjects to active or hidden
    {
        diceRollPanel.SetActive(false);
        healthPanel.SetActive(true);
        myCharacterAttacks.betOdd = false;           //says the player thinks the dice roll will be odd
        myCharacterAttacks.gameStarted = true;       // tells character attacks to start running the game
    }

    public void StartNewGame()                       //starts new game
    {
        startNewGame = true;
    }
}
