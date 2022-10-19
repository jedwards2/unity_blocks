using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject enemyPrefab;
  private GameManager gameManager;

  void Start()
  {
    gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    InvokeRepeating("SpawnSideEnemy", 2.0f, 2.0f);
    InvokeRepeating("SpawnTopEnemy", 2.0f, 2.0f);

  }

  // Update is called once per frame
  void Update()
  {

  }

  void SpawnSideEnemy()
  {
    if (!gameManager.gameOver)
    {
      int randomZ = Random.Range(-5, 5);
      int randomSide = 0;
      if (Random.Range(0, 2) == 0)
      {
        randomSide = -6;
      }
      else
      {
        randomSide = 6;
      }

      Quaternion rotation = enemyPrefab.transform.rotation;
      if (randomSide == -6)
      {
        rotation.eulerAngles = new Vector3(0, 90, 0);
      }
      else
      {
        rotation.eulerAngles = new Vector3(0, 270, 0);
      }

      Instantiate(enemyPrefab, new Vector3(randomSide, 1, randomZ), rotation);
    }

  }

  void SpawnTopEnemy()
  {
    if (!gameManager.gameOver)
    {
      int randomX = Random.Range(-5, 5);
      int randomSide = 0;
      if (Random.Range(0, 2) == 0)
      {
        randomSide = -6;
      }
      else
      {
        randomSide = 6;
      }

      Quaternion rotation = enemyPrefab.transform.rotation;
      if (randomSide == -6)
      {
        rotation.eulerAngles = new Vector3(0, 0, 0);
      }
      else
      {
        rotation.eulerAngles = new Vector3(0, 180, 0);
      }

      Instantiate(enemyPrefab, new Vector3(randomX, 1, randomSide), rotation);
    }

  }

}
