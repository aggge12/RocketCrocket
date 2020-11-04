using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int turnSpeed;
    public int speed;
    public Vector3 rotation;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
      turnSpeed = 60;
      speed = 15;
      velocity = 0;
    }

    void Update () {

        float tryjump = Input.GetKeyDown("space") ? 1 : 0;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        this.rotation = new Vector3(0, 0, moveHorizontal * turnSpeed * Time.deltaTime);
        this.transform.Rotate(this.rotation,Space.Self);

        Vector3 position = transform.position;

        transform.position -= transform.up * ((moveVertical * speed) + velocity) * Time.deltaTime;
        transform.position -= transform.forward * - ( tryjump * 1000 ) * Time.deltaTime;
        /////// JUMP

        /////// VELOCITY
        
        if (moveVertical > 0 && velocity < 100){
          velocity += (float)0.25;
        } else if (velocity > 0){
          velocity -= (float)0.25;
        }
      }
}
