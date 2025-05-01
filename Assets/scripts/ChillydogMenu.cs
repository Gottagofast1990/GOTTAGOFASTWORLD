using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChillydogMenu : MonoBehaviour
{
    public TMP_Text energyText;
    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        energyText.text = playerStats.energy.ToString();
    }

    public void ExitMenu()

    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;


    }

    public void EatButton()
    {
        if (playerStats.timeLeft <= 0)
        {
            return;
        }

        // Increase player strength
        playerStats.energy += 10;

        // Decrease time by 1 hour
        playerStats.timeLeft--;

        // Update the strength text
        energyText.text = playerStats.energy.ToString();
    }

}

