using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private GameManager gameManager;
  private int speed = 5;
  public float getHorizontal;
  public float getVertical;
  void Start()
  {
    gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
  }

  void Update()
  {
    getHorizontal = Input.GetAxis("Horizontal");
    getVertical = Input.GetAxis("Vertical");
    if (!gameManager.gameOver)
    {
      transform.Translate(Vector3.forward * getVertical * Time.deltaTime * speed);
      transform.Translate(Vector3.right * getHorizontal * Time.deltaTime * speed);
    }

  }
}
