using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float destTime = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, destTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
