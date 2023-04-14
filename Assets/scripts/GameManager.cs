using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject point;
    public float zakres;
    public float a;
    public float b;
    public float c;
    public Material material;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(float i = -zakres; i<=zakres; i += .1f)
        {
            GameObject objekt = Instantiate(point, new Vector3(i, a * Mathf.Pow(i, 2) + b * i + c, 0), Quaternion.identity);
            objekt.GetComponent<Renderer>().material.color = new Color(objekt.transform.position.x/5, objekt.transform.position.y/5,0);
        }
    }
}
