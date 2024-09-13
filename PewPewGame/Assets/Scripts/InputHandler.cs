using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public  Movement movement;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Excecuter();
    }
    private void Excecuter(){
        movement.movement(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
}
