using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    public float lastVelocity;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.position = player.transform.position + new Vector3(0, 2, -8);
        lastVelocity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement control = player.GetComponent<PlayerMovement>();

        float b = (float)0.01 * (float)control.velocity;
        

        if (b > lastVelocity){
            transform.position -= transform.forward * b * Time.deltaTime;
        } else if (b < lastVelocity){
            transform.position -= transform.forward * -b * Time.deltaTime;
        }

        lastVelocity = b;
        
    }

     void LateUpdate() {
        //transform.LookAt(target.transform);
    }
}
