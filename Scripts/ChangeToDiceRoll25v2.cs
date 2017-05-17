using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToDiceRoll25v2 : ButtonEventsInh

{
    public override void CloseAllPanels()
    {
        base.CloseAllPanels();                      //closes all panels
        diceRollPanel.SetActive(true);              //sets dice roll panel to active
        myCharacterAttacks.bet10coins = false;       //says the player chose to bet 25 coins
        myCharacterAttacks.playerCoins -= 25;        //takes 25 coins from the player
    }
}
