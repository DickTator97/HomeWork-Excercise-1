using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _RigidBody2D;
    [SerializeField] private float Speed;
    
    private void FixedUpdate()
    {
        _RigidBody2D.AddForce(Vector2.right *Speed* (Time.deltaTime));
       
       
    }


}
