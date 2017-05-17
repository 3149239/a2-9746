using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellDictionary : MonoBehaviour
{

    

    public SpellDictionary(float power, string spell)  //saying my dictonary will link each spells power with their corrisponding spell
    {
        PNUM = power;
        SNAME = spell;
    }

    private float pnum;
    public float PNUM
    {
        get { return pnum; }
        set { pnum = value; }
    }

    private string sname;
    public string SNAME
    {
        get { return sname; }
        set { sname = value; }
    }

    public bool gamestarted = false;

    void Start ()
    {
        gamestarted = true;
    }

    void Update()
    {
        if (gamestarted)
        {

            Dictionary<float, SpellDictionary> spells = new Dictionary<float, SpellDictionary>();       //giving the dictionary values

            SpellDictionary sd1 = new SpellDictionary(4, "Water Spell");
            SpellDictionary sd2 = new SpellDictionary(6, "Earth Spell");
            SpellDictionary sd3 = new SpellDictionary(8, "Fire Spell");

            spells.Add(sd1.PNUM, sd1);      //adding the values
            spells.Add(sd2.PNUM, sd2);
            spells.Add(sd3.PNUM, sd3);


            foreach (KeyValuePair<float, SpellDictionary> sdKeyVal in spells)
            {
                Debug.Log(sdKeyVal.Value.SNAME + ", Power: " + sdKeyVal.Key);            //reading out each spells power 
                

            }

            gamestarted = false;
        }
    }
}


    

