using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goalscripts : MonoBehaviour
{
    public Canvas canvas;
    public GameObject pep;　//パーティクル
    [SerializeField]
   
    
    // Start is called before the first frame update
    void Start()
    {
       canvas.enabled = false;
    }
    
    void OnCollisionEnter(Collision collision)//球が当たった時goalキャンバスを出す
    {
      if(collision.gameObject.name.Equals("Sphere"))
      {
        canvas.enabled = true;
        ContactPoint contact = collision.contacts[0];
        Instantiate(pep, contact.point, Quaternion.identity);// パーティクルが生成される
      }
    }
  }

