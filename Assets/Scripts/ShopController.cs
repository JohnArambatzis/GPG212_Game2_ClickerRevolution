using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopController : MonoBehaviour
{
    public TextMeshProUGUI clickDamageCostText;
    public TextMeshProUGUI autoClickerDamageCostText;

    public float clickDamageCost = 5;
    public float clickDamageCostMultiplier = 1;

    public float autoClickerCost = 10;
    public float autoCLickerCostMultiplier = 2;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ClickDamageUpgrade()
    {
        if (gameObject.GetComponent<PlayerManager>().gold >= clickDamageCost)
        {
            clickDamageCostMultiplier += 1;
            gameObject.GetComponent<PlayerManager>().gold -= clickDamageCost;
            gameObject.GetComponent<PlayerManager>().damage += 1;
            gameObject.GetComponent<PlayerManager>().updateVariables = true;

            clickDamageCost = clickDamageCostMultiplier * 5;
            clickDamageCostText.text = clickDamageCost.ToString();
        }
    }
    public void AutoClickerUpgrade()
    {
        if (gameObject.GetComponent<PlayerManager>().gold >= autoClickerCost)
        {
            autoCLickerCostMultiplier += 1;
            gameObject.GetComponent<PlayerManager>().gold -= autoClickerCost;
            gameObject.GetComponent<PlayerManager>().autoClickerDamage += 1;
            gameObject.GetComponent<PlayerManager>().updateVariables = true;

            autoClickerCost = autoCLickerCostMultiplier * 5;
            autoClickerDamageCostText.text = autoClickerCost.ToString();
        }
    }
}
