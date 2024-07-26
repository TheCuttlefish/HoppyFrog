using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncToFrog : MonoBehaviour
{
    Transform frog;
    Vector3 origin;
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.localPosition;
        frog = GameObject.Find("frog_collider").transform;
    }

    private void Update()
    {
        //idle
        transform.position = frog.position + origin;
        //selected

        //jumping
    }

}
