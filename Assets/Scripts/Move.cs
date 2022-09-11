using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("游戏开始了");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("游戏进行中");
        //Vector3.right left up down forward back
        //rb.AddForce(Vector3.right);
        float h = Input.GetAxis("Horizontal"); // 水平 ad
        Debug.Log(h);
        //rb.AddForce(new Vector3(h, 0, 0));

        float v = Input.GetAxis("Vertical"); // 垂直 ws
        rb.AddForce(new Vector3(h, 0, v));
    }
}
