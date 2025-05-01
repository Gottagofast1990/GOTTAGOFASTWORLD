using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContractMenu : MonoBehaviour
{
    public TMP_Text firstStatText;

    public TMP_Text secondStatText;

    public TMP_Text thirdStatText;

    public GameObject winPopup;

    public int firstStatGoal = 66;

    public int secondStatGoal = 33;

    public int thirdStatGoal = 99;

    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        firstStatText.text = playerStats.strength.ToString() + "/" + firstStatGoal.ToString();
        secondStatText.text = playerStats.craziness.ToString() + "/" + secondStatGoal.ToString();
        thirdStatText.text = playerStats.energy.ToString() + "/" + thirdStatGoal.ToString();


       
    }

    public void ExitMenu()

    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;


    }

    public void SignButton()
    {
        if (playerStats.strength >= firstStatGoal
            && playerStats.craziness >= secondStatGoal
            && playerStats.energy >= thirdStatGoal)
        {
            winPopup.SetActive(true);
        }
    }
}

