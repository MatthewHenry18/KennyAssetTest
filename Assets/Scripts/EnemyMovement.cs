using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private int MoveRight;
    // Update is called once per frame

    void Update()
    {
        if(MoveRight > 0)
        {
            //if  Move right true will tranlate to the right
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }
        if (MoveRight < 0)
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.CompareTag("Turn" )) || (collision.gameObject.CompareTag("Enemy")))
        {
          
            MoveRight *= -1;
            //if(MoveRight)
           // {
            //    MoveRight = false;
           // }
           // else
           // {
           //     MoveRight = true;
          //  }
        }
    }
}
