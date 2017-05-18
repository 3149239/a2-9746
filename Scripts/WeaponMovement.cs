using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMovement : MonoBehaviour {

    public CharacerAttacks myCharacterAttacks;      //assign character attacks script

	// Use this for initialization
	void Start ()
    {
        myCharacterAttacks = GameObject.Find("Scripts").GetComponent<CharacerAttacks>();    //assign my character attacks to that script
    }
	
	// Update is called once per frame (60fps)
	void FixedUpdate ()
    {
        if (myCharacterAttacks.redAttacked == false)            //if red is attacking
        {
            this.transform.Translate(new Vector3(0.06f, 0, 0)); //then move this attack towards blue
            if (this.transform.position.x >= 2)                 //if this object has hit the target, destroy itself
            {
                Destroy(this.gameObject);
            }
        }

        else                                                     //if blue is attacking
        {
            this.transform.Translate(new Vector3(-0.06f, 0, 0)); //then move this attack towards red
            if (this.transform.position.x <= -3)                 //if this object has hit the target, destroy itself
            {
                Destroy(this.gameObject);
            }
        }		
	}
}
