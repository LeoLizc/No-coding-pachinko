using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("esta chocando con:" + collision.collider.name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
