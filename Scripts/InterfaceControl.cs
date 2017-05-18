using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceControl : MonoBehaviour {          

    public interface IMyDiceInterface                       //interface that reads if the dice roll was even or odd
    {
        void MyDiceRoll();                                  //call MyDiceRoll
    }       

    class MyDiceInterface : IMyDiceInterface

    {                            
        public void MyDiceRoll()
        {
            if (GameObject.Find("Scripts").GetComponent<CharacerAttacks>().oddRoll == true)     //if oddroll in character attacks is true
            {
                Debug.Log("The dice rolled was ODD");       //writes the outcome of the roll into the console
            }

            if (GameObject.Find("Scripts").GetComponent<CharacerAttacks>().oddRoll == false)    //if oddroll in character attacks is false
            {
                Debug.Log("The dice rolled was EVEN");      //writes the outcome of the roll into the console
            }
        }
    }
}
