using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private float speed = 10f;


    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    private void OncollisionEnter2D(Collision2D collision)
    {
        
    }
}
