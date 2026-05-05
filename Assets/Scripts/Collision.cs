using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int score = 0;

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            score += 1;
            Destroy(collision.gameObject);
            Debug.Log(score);
        }
    }

    void OnTriggerEnter(Collider other)
    {   
        print(other.gameObject.name);
        if (other.gameObject.tag == "WinArea" && score >= 7)
        {
            Debug.Log("WINNER");
        }
    }

}
