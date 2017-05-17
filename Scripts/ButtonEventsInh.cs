using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEventsInh : MonoBehaviour
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
    void Start()
    {
        myCharacterAttacks = GameObject.Find("Scripts").GetComponent<CharacerAttacks>();        //attaches script to mycharacterattacks

        whoToWinPanel.SetActive(true);              //sets first screen to show up at the start of the game 

        startNewGame = false;                       //dont start new game
    }

    // Update is called once per frame
    void Update()
    {
        if (startNewGame == true)                   //starts new game
        {
            whoToWinPanel.SetActive(true);          //starts first panel to active
            winScreen.SetActive(false);             //sets win screen to not active
            loseScreen.SetActive(false);            //sets lose screen to not active
            healthPanel.SetActive(false);           //sets health panel to not active
            myCharacterAttacks.redHealth = 100;     //sets red health back to 100
            myCharacterAttacks.blueHealth = 100;    //sets blue health back to 100
            myCharacterAttacks.myCountdownTimer = 6;
            startNewGame = false;
        }

    }

    public virtual void CloseAllPanels()//closes all panels
    {
        whoToWinPanel.SetActive(false); //starts first panel to notactive
        winScreen.SetActive(false);     //sets win screen to not active
        loseScreen.SetActive(false);    //sets lose screen to not active
        healthPanel.SetActive(false);   //sets health panel to not active
        betSizePanel.SetActive(false);  //sets bet size panel to not active  
        diceRollPanel.SetActive(false); //sets dice roll panel to not active
    }

    public void StartNewGame()                       //starts new game
    {
        startNewGame = true;
    }

}

