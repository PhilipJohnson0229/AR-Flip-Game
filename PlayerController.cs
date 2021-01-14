using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    public Rigidbody feet;

    public float force;

    InputHandler inputHandler;

    float delta;
    private void Start()
    {
        inputHandler = FindObjectOfType<InputHandler>();
    }

    private void Update()
    {
        delta = Time.deltaTime;
        inputHandler.TickInput(delta);

        if (inputHandler.k_input) 
        {
            Kick();
        }
    }

    private void LateUpdate()
    {
        inputHandler.k_input = false;
    }
    public void Kick()
    {
        feet.AddForce(Vector3.forward * force);
    }

    public void Dismount() 
    {
    //release from pole and launch
    //well have to disable some components to make this work and change some mass values probably
    }
}
