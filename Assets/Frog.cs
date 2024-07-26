using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{

    public GameObject UIline;
    public Vector3 mousePos;
    Vector3 offset = new Vector3(0, 0, -10);
    Vector3 dirLineToMouse;
    float lineScale;// distance between mouse postition and line postiion
    Rigidbody2D rb2;
    bool showUIline = false;
    float jumpForce = 200f;
    bool clikedOnFrog = false;
    void Start()
    {
        UIline = GameObject.Find("UI_line");
        rb2 = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (showUIline)
        {
            UIline.SetActive(true);//show

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
            UIline.transform.position = transform.position;
            dirLineToMouse = mousePos - transform.position;
            UIline.transform.up = dirLineToMouse.normalized;//normalise to keep values clamped
            lineScale = Vector3.Distance(UIline.transform.position, mousePos);
            UIline.transform.localScale = new Vector3(1, lineScale, 1);
        }
        else
        {
            UIline.SetActive(false);//hide
        }

        if (Input.GetMouseButtonUp(0) && clikedOnFrog)
        {

            showUIline = false;
            rb2.AddForce(-dirLineToMouse * jumpForce);
            clikedOnFrog = false;
        }
    }

    private void OnMouseDown()
    {
        clikedOnFrog = true;
        showUIline = true;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb2.velocity = Vector3.zero;
    }


}
