using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToBetSizeBluev2 : ButtonEventsInh
{

    //Sets panels to active or hidden



    public override void CloseAllPanels()
    {
        base.CloseAllPanels();              //closes all panels
        betSizePanel.SetActive(true);       //sets size panel to active
        myCharacterAttacks.betRed = false;  //says the player bets on blue to win
    }
}
