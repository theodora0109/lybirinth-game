using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour
{
    [SerializeField] GameObject Sphere = null;

    public float speed = 10f;   // ボールの移動速度
    private Rigidbody rb;           // Rigidbodyコンポーネント
    
    Vector3 SphereDefaultPosition = new Vector3();

    int count;
    
    void Start()
    {
        // Rigidbodyコンポーネントを取得
        rb = GetComponent<Rigidbody>();
        SphereDefaultPosition = Sphere.transform.localPosition;
    }

    void Update()
    {
        // 加速度センサーを使用してデバイスの傾きを取得
        Vector3 acceleration = Input.acceleration;

        // 加速度を使ってボールを転がす方向を計算
        Vector3 movement = new Vector3(-acceleration.x, 0, -acceleration.y);

        // Rigidbodyを使ってボールを動かす
        rb.AddForce(movement * speed);
    }

   　//sphereがぶつかった時に音が鳴る
    void OnCollisionEnter (Collision col)
    {
       if ( col.gameObject.name == "sphere") {
          GetComponent<AudioSource>().Play();
       }

    }
    //sphereをもとの位置からスタートする
    public void OnResetButtonClicked()
    {
        Sphere.SetActive(true);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        Sphere.transform.localPosition = SphereDefaultPosition;
    }
}
