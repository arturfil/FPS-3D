using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // The speed of the bullet is 30, although here the speed is set,
    // you have to remember to set it on unity too!
    public float speed = 30f;
    public float lifeTime = 2f;
    public int damage = 5;

    private float lifeCounter;
    private bool shotByPlayer;
    public bool ShotByPlayer {
        // Getters and Setters
        get {
            return shotByPlayer;
        } 
        set{
            shotByPlayer = value;
        }
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        lifeCounter = lifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Make the bullet move.
        transform.position += transform.forward * speed * Time.deltaTime;
        // Check if the bullet should be destroyed 
        lifeCounter -= Time.deltaTime;
        if (lifeCounter <= 0f) {
            gameObject.SetActive(false);
        }
    }
}
