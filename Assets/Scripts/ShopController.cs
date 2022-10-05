using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopController : MonoBehaviour
{
    public TextMeshProUGUI clickDamageCostText;

    public float clickDamageCost = 5;
    public float clickDamageCostMultiplier = 1;


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
}
