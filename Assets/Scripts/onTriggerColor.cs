using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerColor : MonoBehaviour
{
    public Color colorPalet;

    private void Start()
    {
        Debug.Log(colorPalet);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        
        if (other.gameObject.CompareTag("Spawn"))
        {
            
            if (colorPalet != null)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;
                Destroy(other.gameObject);
                gameObject.GetComponent<Renderer>().material.color = colorPalet;
                other.GetComponent<Collider>().enabled = false;
            }
        }
    }

}
