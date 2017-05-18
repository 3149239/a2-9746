using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToBetSizeRedv2 : ButtonEventsInh 
    
{
    //Sets panels to active or hidden

    public override void CloseAllPanels()
    {
        base.CloseAllPanels();              //closes all panels
        betSizePanel.SetActive(true);       //sets size panel to active
        myCharacterAttacks.betRed = true;   //says the player bets on red to win
    }
}
