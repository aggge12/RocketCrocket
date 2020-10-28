using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int turnSpeed;
    public int speed;
    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
      turnSpeed = 40;
      speed = 20;
    }

    void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        this.rotation = new Vector3(0, 0, moveHorizontal * turnSpeed * Time.deltaTime);
        this.transform.Rotate(this.rotation,Space.Self);

        Vector3 position = transform.position;

        transform.position -= transform.up * moveVertical * speed * Time.deltaTime;
      }
}
