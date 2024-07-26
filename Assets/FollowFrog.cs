using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFrog : MonoBehaviour
{
    GameObject frog;
    Vector3 offset = new Vector3(0, 0, -10);
    // Start is called before the first frame update
    void Start()
    {
        frog = GameObject.Find("frog");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= ( transform.position - frog.transform.position- offset) / 0.2f * Time.deltaTime;
    }
}
