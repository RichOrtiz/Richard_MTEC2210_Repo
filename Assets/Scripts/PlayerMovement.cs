using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public Transform bike;
    public GameObject knucklesPrefab;
    private SpriteRenderer sr;
    public Sprite secondSprite;
    public Sprite originalSprite;




    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Debug.Log("Bike world position: " + bike.position);
        Debug.Log("Bike local position: " + bike.localPosition);
    }

    void Update()
    {
        //-1 if holding down A and +1 holding down D
        /*float xMovement = Input.GetAxis("Horizontal");
        transform.Translate(speed * Time.deltaTime * xMovement, 0, 0);
        if (xMovement > 0)
        {
            sr.flipX = false;
        }
        else if (xMovement < 0)
        {
            sr.flipX = true;
        }
        */

        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            sr.flipX = false;
            sr.sprite = originalSprite;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            sr.flipX = true;
            sr.sprite = originalSprite;

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
            sr.flipX = true;
            sr.sprite = secondSprite;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            sr.flipX = false;
            sr.sprite = secondSprite;

        }





        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnKnuckles();
        }
    }



    public void shoot()
    {
        Debug.Log("shoot");
    }
    public void spawnKnuckles()
    {
        GameObject knuckles = Instantiate(knucklesPrefab, Vector3.zero, Quaternion.identity);
        knuckles.GetComponent<PlayerMovement>().enabled = false;
        //or knuckles.GetComponent<PlayerMovement>().speed = 0f;
    }
}
