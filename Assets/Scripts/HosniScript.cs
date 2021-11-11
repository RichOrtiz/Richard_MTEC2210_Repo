using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HosniScript : MonoBehaviour
{
    public GameObject teacher;
    private SpriteRenderer beardSprite;
    private SpriteRenderer hairSprite;
    private SpriteRenderer faceSprite;
    // Start is called before the first frame update
    void Start()
    {
        teacher = GameObject.Find("Hosni");
        //beard = teacher.transform.GetChild(0).gameObject;
        hairSprite = teacher.transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>();
        faceSprite = teacher.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>();
        beardSprite = teacher.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //Debug.Log(beardSprite.color);
        //beardSprite.color = new Color(50, 150, 100, 50);
    }
    public void ColorChange()
    {
        beardSprite.color = new Color(0, 100, 50, 255);
        hairSprite.color = new Color(60, 150, 0,255);
        faceSprite.color = new Color(0, 0, 150,255);
    }
}
