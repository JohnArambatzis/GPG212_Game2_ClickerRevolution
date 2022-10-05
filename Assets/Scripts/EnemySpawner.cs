using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject levelOne;
    public GameObject levelTwo;
    public GameObject levelThree;
    public GameObject levelFour;
    public GameObject levelFive;
    public GameObject levelSix;
    public GameObject levelSeven;
    public GameObject levelEight;
    public GameObject levelNine;
    public GameObject levelTen;

    public float currentLevel = 1;

    public bool levelTwoUnlock = false;
    public bool levelThreeUnlock = false;
    public bool levelFourUnlock = false;
    public bool levelFiveUnlock = false;
    public bool levelSixUnlock = false;
    public bool levelSevenUnlock = false;
    public bool levelEightUnlock = false;
    public bool levelNineUnlock = false;
    public bool levelTenUnlock = false;

    public bool enemySpawnerTest = false;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (enemySpawnerTest == true)
        {
            SpawnNewEnemy();

            enemySpawnerTest = false;
        }
    }



    public void SpawnNewEnemy()
    {
        if (currentLevel == 1)
        {
            Instantiate(levelOne);
        }
        if (currentLevel == 2)
        {
            Instantiate(levelTwo);
        }
        if (currentLevel == 3)
        {
            Instantiate(levelThree);
        }
        if (currentLevel == 4)
        {
            Instantiate(levelFour);
        }
        if (currentLevel == 5)
        {
            Instantiate(levelFive);
        }
        if (currentLevel == 6)
        {
            Instantiate(levelSix);
        }
        if (currentLevel == 7)
        {
            Instantiate(levelSeven);
        }
        if (currentLevel == 8)
        {
            Instantiate(levelEight);
        }
        if (currentLevel == 9)
        {
            Instantiate(levelNine);
        }
        if (currentLevel == 10)
        {
            Instantiate(levelTen);
        }
    }
}
