using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    //�������� NPC
   public int health = 5;

    //������� NPC
  public  int level = 1;

    //�������� NPC
  public  float speed = 1.2f;

    void Start()
    {
        health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}