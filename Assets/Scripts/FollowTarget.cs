using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Vector3 offset;
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        // 寻找Player队友的GameObject，然后获取对应的transform，获取对应的position
        GameObject gameObject = GameObject.Find("Player");
        playerTransform = gameObject.GetComponent<Transform>();

        offset = transform.position - this.playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
