using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToDiceRoll10v2 : ButtonEventsInh

{
    public override void CloseAllPanels()
    {
        base.CloseAllPanels();                      //closes all panels
        diceRollPanel.SetActive(true);              //sets dice roll panel to active
        myCharacterAttacks.bet10coins = true;       //says the player chose to bet 10 coins
        myCharacterAttacks.playerCoins -= 10;       //takes 10 coins from the player
    }
}
