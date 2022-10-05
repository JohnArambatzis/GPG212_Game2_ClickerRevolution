using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public float gold = 0;
    public float damage = 1;

    public TextMeshProUGUI goldAmountText;
    public TextMeshProUGUI clickDamageText;

    public bool updateVariables = false;


    void Start()
    {
        
    }

    void Update()
    {
        if (updateVariables == true)
        {
            UpdateVariables();
            updateVariables = false;
        }
    }


    public void UpdateVariables()
    {
        goldAmountText.text = gold.ToString();
        clickDamageText.text = damage.ToString();
    }
}
