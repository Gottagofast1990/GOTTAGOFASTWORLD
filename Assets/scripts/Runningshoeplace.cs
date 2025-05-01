using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Runningshoeplace : MonoBehaviour
{
    public TMP_Text crazinessText;
    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        crazinessText.text = playerStats.craziness.ToString();
    }

    public void ExitMenu()

    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;


    }

    public void CrazyButton()
    {
        if (playerStats.timeLeft <= 0)
        {
            return;
        }

        // Increase player strength
        playerStats.craziness += 10;

        // Decrease time by 1 hour
        playerStats.timeLeft--;

        // Update the strength text
        crazinessText.text = playerStats.craziness.ToString();
    }

}

