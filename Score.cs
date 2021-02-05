using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private Rigidbody2D rd2d;
    private int scoreValue;
    public Text score;
    public AudioSource musicSource;
    public AudioClip musicClipDotGet;
    public AudioClip musicClipDotGetR;

    


    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        score.text = scoreValue.ToString();
    
        scoreValue = 0;
     
}

    // Update is called once per frame
    void Update()
    {
       
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Dot")
        {
            scoreValue += 1;
            score.text = scoreValue.ToString();
            
        }
       // else if(collision.collider.tag == "Dot")
        //{
       //     scoreValue += 5;
       //     score.text = scoreValue.ToString();
            
      //  }
    }
    
}
