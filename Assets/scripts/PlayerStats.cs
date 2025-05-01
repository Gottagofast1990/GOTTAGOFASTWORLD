using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public TMP_Text text;
    public string playerName = "Sonic";
    public int strength = 8;
    public int craziness = 10;
    public int energy = 10;
    public int writing = 10;
    public int timeLeft = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       


    }


    void MyFunction()

    {
        craziness++;


        Debug.Log("Getta Load Of This Guy!");
        craziness++;

        if (craziness >= 3) ;











    }
}

