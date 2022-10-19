using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
  private int speed;
  // Start is called before the first frame update
  void Start()
  {
    speed = Random.Range(5, 15);
  }

  // Update is called once per frame
  void Update()
  {
    transform.Translate(Vector3.forward * Time.deltaTime * speed);
  }
}
