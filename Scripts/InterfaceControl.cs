using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceControl : MonoBehaviour {

    public interface IMyDiceInterface
    {
        void MyDiceRoll();
    }

    class MyDiceInterface : IMyDiceInterface

    {

        public void MyDiceRoll()

        {

            if (GameObject.Find("Scripts").GetComponent<CharacerAttacks>().oddRoll == true)
            {
                Debug.Log("The dice rolled was ODD");
            }

            if (GameObject.Find("Scripts").GetComponent<CharacerAttacks>().oddRoll == false)
            {
                Debug.Log("The dice rolled was EVEN");
            }
        }

    }

}
