using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float speed = 1;
    public float pitchSpeed = 1;
    public float yawSpeed = 1;
    public float rollSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        transform.localPosition = new Vector3(transform.localPosition.x + x * speed * Time.deltaTime, transform.localPosition.y, transform.localPosition.z + z * speed * Time.deltaTime);
        float Y = transform.localEulerAngles.y;
        float X = transform.localEulerAngles.x;
        float Z = transform.localEulerAngles.z;
        if(Input.GetKey(KeyCode.I))
        {
            X -= 1 * pitchSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.K))
        {
            X += 1 * pitchSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.J))
        {
            Y -= 1 * yawSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.L))
        {
            Y += 1 * yawSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.U))
        {
            Z -= 1 * rollSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.O))
        {
            Z += 1 * rollSpeed * Time.deltaTime;
        }
        transform.localEulerAngles = new Vector3(X, Y, Z);
    }
}
