using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToDiceRoll10v2 : ButtonEventsInh

{
    public TakeCoins myTakeCoins;                   //assigns take my coins to mytakecoins

    public override void CloseAllPanels()
    {
        base.CloseAllPanels();                      //closes all panels
        diceRollPanel.SetActive(true);              //sets dice roll panel to active
        myCharacterAttacks.bet10coins = true;       //says the player chose to bet 10 coins
        myTakeCoins = GameObject.Find("Scripts").GetComponent<TakeCoins>();                         //attaches script to Take Coins polymorphism script
        myCharacterAttacks.playerCoins = myTakeCoins.takeCoins(myCharacterAttacks.playerCoins, 10); //takes 10 coins away
    }    
}
