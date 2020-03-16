using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed); //x is 0 because bullet moves in one direction, speed is speed you enter in the unity editor
    }

    // Update is called once per frame
    void Update()
    {
        //check if bullet has gone beyond screen bounds, if it has, destroy it to save space
        if (Camera.main.WorldToViewportPoint(transform.position).y > 1) //unity knows that if you only have one camera, that is your main camera
            //world to view point = what the camera sees, basically this is converting bullets position to position to camera, and if its too far, delete it
            Destroy(this.gameObject);
    }
}
