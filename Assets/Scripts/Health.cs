using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int lives = 3;
    public GameObject PacmanLife;

    void Start()
    {
        for (int i = lives; i > 0; i--)
        {
            GameObject life = Instantiate(PacmanLife, new Vector2(-3, 29 - (lives * 2.0F) + (i * 2.0F)), Quaternion.identity);
            PacmanLife.name = "life" + i;
            Debug.Log(PacmanLife.name);
        }
    }
}
