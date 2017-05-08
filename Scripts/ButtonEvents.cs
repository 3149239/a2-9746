using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents : MonoBehaviour
{

    public GameObject whoToWinPanel;    //First panel
    public GameObject betSizePanel;     //Second Panel
    public GameObject diceRollPanel;    //Third Panel
    public GameObject healthPanel;      //Forth Panel

    public bool redChosen;              //red or blue chosen
    public bool coins10chosen;          //10 coins bet or 25
    public bool betOdd;                 //bet odd or even

    public CharacerAttacks myCharacterAttacks;      //assign character attacks script

    // Use this for initialization
    void Start ()
    {
        myCharacterAttacks = GameObject.Find("Scripts").GetComponent<CharacerAttacks>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ChangeToBetSizeRed()       //Sets panels to active or hidden
    {
        whoToWinPanel.SetActive(false);
        betSizePanel.SetActive(true);
        redChosen = true;                   //says the player bets on red to win
    }

    public void ChangeToBetSizeBlue()       //Sets panels to active or hidden
    {
        whoToWinPanel.SetActive(false);
        betSizePanel.SetActive(true);
        redChosen = false;                  //says the player bets on blue to win
    }

    public void ChangeToDiceRoll10()      //Sets gameobjects to active or hidden
    {
        betSizePanel.SetActive(false);
        diceRollPanel.SetActive(true);
        coins10chosen = true;               //says the player chose to bet 10 coins
    }
    public void ChangeToDiceRoll25()      //Sets gameobjects to active or hidden
    {
        betSizePanel.SetActive(false);
        diceRollPanel.SetActive(true);
        coins10chosen = false;              //says the player chose to bet 10 coins
    }
    public void ChangeToHealthOdd()      //Sets gameobjects to active or hidden
    {
        diceRollPanel.SetActive(false);
        healthPanel.SetActive(true);
        betOdd = true;                      //says the player thinks the dice roll will be odd
        myCharacterAttacks.gameStarted = true;      // tells character attacks to start running the game
    }
    public void ChangeToHealthEven()      //Sets gameobjects to active or hidden
    {
        diceRollPanel.SetActive(false);
        healthPanel.SetActive(true);
        betOdd = false;                     //says the player thinks the dice roll will be odd
        myCharacterAttacks.gameStarted = true;      // tells character attacks to start running the game
    }
}
