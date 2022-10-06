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
    public float enemyLevel = 1;

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

            if (enemyLevel == 1 && player.GetComponent<EnemySpawner>().levelTwoUnlock == false)
            {
                player.GetComponent<EnemySpawner>().levelTwoUnlock = true;
            }
            if (enemyLevel == 2 && player.GetComponent<EnemySpawner>().levelThreeUnlock == false)
            {
                player.GetComponent<EnemySpawner>().levelThreeUnlock = true;
            }
            if (enemyLevel == 3 && player.GetComponent<EnemySpawner>().levelFourUnlock == false)
            {
                player.GetComponent<EnemySpawner>().levelFourUnlock = true;
            }
            if (enemyLevel == 4 && player.GetComponent<EnemySpawner>().levelFiveUnlock == false)
            {
                player.GetComponent<EnemySpawner>().levelFiveUnlock = true;
            }
            if (enemyLevel == 5 && player.GetComponent<EnemySpawner>().levelSixUnlock == false)
            {
                player.GetComponent<EnemySpawner>().levelSixUnlock = true;
            }
            if (enemyLevel == 6 && player.GetComponent<EnemySpawner>().levelSevenUnlock == false)
            {
                player.GetComponent<EnemySpawner>().levelSevenUnlock = true;
            }
            if (enemyLevel == 7 && player.GetComponent<EnemySpawner>().levelEightUnlock == false)
            {
                player.GetComponent<EnemySpawner>().levelEightUnlock = true;
            }
            if (enemyLevel == 8 && player.GetComponent<EnemySpawner>().levelNineUnlock == false)
            {
                player.GetComponent<EnemySpawner>().levelNineUnlock = true;
            }
            if (enemyLevel == 9 && player.GetComponent<EnemySpawner>().levelTenUnlock == false)
            {
                player.GetComponent<EnemySpawner>().levelTenUnlock = true;
            }

            player.GetComponent<EnemySpawner>().enemySpawnerTest = true;

            Destroy(gameObject);
        }
    }
}
