using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollisions : MonoBehaviour
{
  private GameManager gameManager;

  // Start is called before the first frame update
  void Start()
  {
    gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter(Collider other)
  {
    Destroy(other.gameObject);
    gameManager.livesLeft += -1;
    Debug.Log("Lives Left: " + gameManager.livesLeft);
    if (gameManager.livesLeft <= 0)
    {
      gameManager.gameOver = true;
      Debug.Log("Game Over!");
    }
  }
}
