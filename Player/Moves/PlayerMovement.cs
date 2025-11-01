using UnityEngine;

public class PlayerMovement : Action
{

    // Please write the code for the movement inside of StartAction function
    // so that the player state machine can work
    // - Frank


    [SerializeField] private Camera PlayerCam;
    public override void StartAction()
    {
        print("player movement");


    }
}
