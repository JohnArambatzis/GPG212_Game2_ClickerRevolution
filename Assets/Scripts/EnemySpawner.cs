using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject levelOneButton;
    public GameObject levelTwoButton;
    public GameObject levelThreeButton;
    public GameObject levelFourButton;
    public GameObject levelFiveButton;
    public GameObject levelSixButton;
    public GameObject levelSevenButton;
    public GameObject levelEightButton;
    public GameObject levelNineButton;
    public GameObject levelTenButton;

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

        if (currentLevel == 1)
        {
            levelOneButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 1)
        {
            levelOneButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy1"));
        }
        if (currentLevel == 2)
        {
            levelTwoButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 2 && levelTwoUnlock == true)
        {
            levelTwoButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy2"));
        }
        if (currentLevel == 3)
        {
            levelThreeButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 3 && levelThreeUnlock == true)
        {
            levelThreeButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy3"));
        }
        if (currentLevel == 4)
        {
            levelFourButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 4 && levelFourUnlock == true)
        {
            levelFourButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy4"));
        }
        if (currentLevel == 5)
        {
            levelFiveButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 5 && levelFiveUnlock == true)
        {
            levelFiveButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy5"));
        }
        if (currentLevel == 6)
        {
            levelSixButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 6 && levelSixUnlock == true)
        {
            levelSixButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy6"));
        }
        if (currentLevel == 7)
        {
            levelSevenButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 7 && levelSevenUnlock == true)
        {
            levelSevenButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy7"));
        }
        if (currentLevel == 8)
        {
            levelEightButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 8 && levelEightUnlock == true)
        {
            levelEightButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy8"));
        }
        if (currentLevel == 9)
        {
            levelNineButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 9 && levelNineUnlock == true)
        {
            levelNineButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy9"));
        }
        if (currentLevel == 10)
        {
            levelTenButton.GetComponent<Button>().interactable = false;
        }
        if (currentLevel != 10 && levelTenUnlock == true)
        {
            levelTenButton.GetComponent<Button>().interactable = true;
            Destroy(GameObject.FindWithTag("Enemy10"));
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

    public void LevelOne()
    {
        currentLevel = 1;
        SpawnNewEnemy();
    }
    public void LevelTwo()
    {
        currentLevel = 2;
        SpawnNewEnemy();
    }
    public void LevelThree()
    {
        currentLevel = 3;
        SpawnNewEnemy();
    }
    public void LevelFour()
    {
        currentLevel = 4;
        SpawnNewEnemy();
    }
    public void LevelFive()
    {
        currentLevel = 5;
        SpawnNewEnemy();
    }
    public void LevelSix()
    {
        currentLevel = 6;
        SpawnNewEnemy();
    }
    public void LevelSeven()
    {
        currentLevel = 7;
        SpawnNewEnemy();
    }
    public void LevelEight()
    {
        currentLevel = 8;
        SpawnNewEnemy();
    }
    public void LevelNine()
    {
        currentLevel = 9;
        SpawnNewEnemy();
    }
    public void LevelTen()
    {
        currentLevel = 10;
        SpawnNewEnemy();
    }
}
