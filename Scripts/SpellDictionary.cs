using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellDictionary : MonoBehaviour
{   

    public SpellDictionary(float power, string spell)   //saying my dictonary will link each spells power with their corrisponding spell
    {
        PNUM = power;                                   //assigning PNUM to = power
        SNAME = spell;                                  //assinging SNAME to = spell
    }

    private float pnum;                                 //float to hold the power number
    public float PNUM                                   //float for power
    {
        get { return pnum; }                            //give power number a value
        set { pnum = value; }
    }

    private string sname;                               //string to hold spell name
    public string SNAME                                 //string for spell name
    {
        get { return sname; }                           //give spell name a value
        set { sname = value; }
    }

    public bool gamestarted = false;                    //game hasnt started

    void Start ()
    {
        gamestarted = true;                             //at the start of the game set game started to true
    }

    void Update()
    {
        if (gamestarted)                                //if game started is true
        {
            Dictionary<float, SpellDictionary> spells = new Dictionary<float, SpellDictionary>();       //giving the dictionary values

            SpellDictionary sd1 = new SpellDictionary(4, "Water Spell");              //water spell has a power of 4
            SpellDictionary sd2 = new SpellDictionary(6, "Earth Spell");              //Earth spell has a power of 6
            SpellDictionary sd3 = new SpellDictionary(8, "Fire Spell");               //Fire spell has a power of 8

            spells.Add(sd1.PNUM, sd1);      //adding the values
            spells.Add(sd2.PNUM, sd2);
            spells.Add(sd3.PNUM, sd3);

            foreach (KeyValuePair<float, SpellDictionary> sdKeyVal in spells)         //for each key value pair in spells
            {
                Debug.Log(sdKeyVal.Value.SNAME + ", Power: " + sdKeyVal.Key);         //reading out each spells power               
            }

            gamestarted = false;            //set the game started bool to false as it has already started
        }
    }
}


    

