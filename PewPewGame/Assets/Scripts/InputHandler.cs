using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject player;
    public List<KeyCode> MoveInputs;
    public List<KeyCode> PressedMoveKeys;
    public MoveCommand[] moveCommands = new MoveCommand[8];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = MoveInputs.Count; i >0; i --){
            if (Input.GetKeyDown(MoveInputs[i])){
                PressedMoveKeys.Add(MoveInputs[i]);
            }
            if (Input.GetKeyUp(MoveInputs[i])){
                PressedMoveKeys.Remove(MoveInputs[i]);
            }
        }
        moveMentExcecuter();
    }
    private void moveMentExcecuter(){
        for (int i = 0; i < 8; i ++){
            if (PressedMoveKeys.Contains(MoveInputs[i])){

            }           
        }

    }
}
