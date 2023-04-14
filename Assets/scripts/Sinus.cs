using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinus : MonoBehaviour
{
    public GameObject point;
    public float zakres;
    public float przesuniecie = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            for (float i = -zakres; i <= zakres; i += .15f)
            {
                GameObject objekt = Instantiate(point, new Vector3(i, 2 * Mathf.Sin(i-przesuniecie), 0), Quaternion.identity);
                objekt.GetComponent<Renderer>().material.color = new Color(0, objekt.transform.position.y / 5, 0);
            }
        przesuniecie+= Time.deltaTime;
    }
}
