using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderscript : MonoBehaviour
{ 
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // sphereが当たった時一時的に消える
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("落ちたボール" + other.gameObject.name);
        other.gameObject.SetActive(false);
    }
}
