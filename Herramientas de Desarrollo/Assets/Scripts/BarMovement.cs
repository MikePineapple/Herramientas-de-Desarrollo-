using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float barSpeed;
    
    public float degreesPerSecond;
    private bool Rotated = false;
    private bool isRotating = false;
    private Quaternion lastRotation = Quaternion.Euler(0,0,0);

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (Input.GetKey(KeyCode.Space) && !isRotating){
            Rotated = true;
            isRotating = true;
        }
        if (Rotated == true) {
                transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);

            if (Mathf.Abs( transform.eulerAngles.z - lastRotation.eulerAngles.z) > 90){
                lastRotation = transform.rotation;
                Debug.Log(lastRotation.eulerAngles.z);
                isRotating = false;
                Rotated = false;
            }
        }
        
        float h = Input.GetAxisRaw("Horizontal");

        if (h > 0)
            rb.velocity = transform.right * barSpeed;
        else if (h < 0)
            rb.velocity = -transform.right * barSpeed;
        else
            rb.velocity = Vector2.zero;
    }
}
