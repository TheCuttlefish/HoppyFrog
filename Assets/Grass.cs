using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{

    float timer = 0;
    public AnimationCurve curve;
    bool shake = false;
    float rndShake;
  

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!shake)
        {
            shake = true;
            rndShake = Random.Range(-30, 30);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (shake)
        {
            timer += Time.deltaTime;
            transform.localEulerAngles = new Vector3(0, 0, curve.Evaluate(timer) * rndShake);

            if(timer > 1)
            {
                shake = false;
                timer = 0;
            }
        }
    }
}
