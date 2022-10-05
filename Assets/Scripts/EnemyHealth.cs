using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI enemyHealthText;

    public float enemyHealth = 10;
    public float goldDropped = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && player.GetComponent<PanelController>().isPaused == false && enemyHealth > 0)
        {
            Debug.Log("Player Left Clicked");

            enemyHealth = enemyHealth - player.GetComponent<PlayerManager>().damage;
            enemyHealthText.text = enemyHealth.ToString();
        }

        if (enemyHealth <= 0)
        {
            Debug.Log("Destroyed Enemy");

            player.GetComponent<PlayerManager>().gold += goldDropped;
            player.GetComponent<PlayerManager>().updateVariables = true;

            player.GetComponent<EnemySpawner>().enemySpawnerTest = true;


            Destroy(gameObject);
        }
    }
}
