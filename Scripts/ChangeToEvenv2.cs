using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToEvenv2 : ButtonEventsInh

{
    public override void CloseAllPanels()
    {
        base.CloseAllPanels();                      //closes all panels
        healthPanel.SetActive(true);                //sets health panel to active
        myCharacterAttacks.betOdd = false;          //says the player thinks the dice roll will be even
        myCharacterAttacks.gameStarted = true;      // tells character attacks to start running the game
    }
}
