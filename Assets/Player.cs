using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    
    public float moveSpeed = 600f;

    float movement = 0f;


    // Update is called once per frame
    void Update(){
        Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate(){
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }
}