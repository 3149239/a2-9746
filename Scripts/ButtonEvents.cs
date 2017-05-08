using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents : MonoBehaviour
{

    public GameObject whoToWinPanel;    //First panel
    public GameObject betSizePanel;     //Second Panel
    public GameObject diceRollPanel;    //Third Panel
    public GameObject healthPanel;      //Forth Panel

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
        myCharacterAttacks.betRed = true;                   //says the player bets on red to win
    }

    public void ChangeToBetSizeBlue()       //Sets panels to active or hidden
    {
        whoToWinPanel.SetActive(false);
        betSizePanel.SetActive(true);
        myCharacterAttacks.betRed = false;                  //says the player bets on blue to win
    }

    public void ChangeToDiceRoll10()      //Sets gameobjects to active or hidden
    {
        betSizePanel.SetActive(false);
        diceRollPanel.SetActive(true);
        myCharacterAttacks.bet10coins = true;               //says the player chose to bet 10 coins
    }
    public void ChangeToDiceRoll25()      //Sets gameobjects to active or hidden
    {
        betSizePanel.SetActive(false);
        diceRollPanel.SetActive(true);
        myCharacterAttacks.bet10coins = false;              //says the player chose to bet 10 coins
    }
    public void ChangeToHealthOdd()      //Sets gameobjects to active or hidden
    {
        diceRollPanel.SetActive(false);
        healthPanel.SetActive(true);
        myCharacterAttacks.betOdd = true;                      //says the player thinks the dice roll will be odd
        myCharacterAttacks.gameStarted = true;      // tells character attacks to start running the game
    }
    public void ChangeToHealthEven()      //Sets gameobjects to active or hidden
    {
        diceRollPanel.SetActive(false);
        healthPanel.SetActive(true);
        myCharacterAttacks.betOdd = false;                     //says the player thinks the dice roll will be odd
        myCharacterAttacks.gameStarted = true;      // tells character attacks to start running the game
    }
}
