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

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ChangeToBetSizeRed()       //Sets gameobjects to active or hidden
    {
        whoToWinPanel.SetActive(false);
        betSizePanel.SetActive(true);
        redChosen = true;
    }

    public void ChangeToBetSizeBlue()       //Sets gameobjects to active or hidden
    {
        whoToWinPanel.SetActive(false);
        betSizePanel.SetActive(true);
        redChosen = false;
    }

    public void ChangeToDiceRoll10()      //Sets gameobjects to active or hidden
    {
        betSizePanel.SetActive(false);
        diceRollPanel.SetActive(true);
        coins10chosen = true;
    }
    public void ChangeToDiceRoll25()      //Sets gameobjects to active or hidden
    {
        betSizePanel.SetActive(false);
        diceRollPanel.SetActive(true);
        coins10chosen = false;
    }
    public void ChangeToHealthOdd()      //Sets gameobjects to active or hidden
    {
        diceRollPanel.SetActive(false);
        healthPanel.SetActive(true);
        betOdd = true;
    }
    public void ChangeToHealthEven()      //Sets gameobjects to active or hidden
    {
        diceRollPanel.SetActive(false);
        healthPanel.SetActive(true);
        betOdd = false;
    }
}
