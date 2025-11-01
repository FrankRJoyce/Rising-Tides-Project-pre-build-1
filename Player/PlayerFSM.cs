using UnityEngine;

public class PlayerFSM : MonoBehaviour
{
    //storing the actions for the State machine to use 
    // - Frank

    public Action Movement;
    public Action Attack;
    public Action Dodge;

    public Action OnBoardAbility;
    public Action CounterAbility;
    public Action Idle;

// to change between abilities - Frank
    Action CurrentAbility;
    void Start()
    {
        // starting On Board 
        CurrentAbility = OnBoardAbility;
    }

    // assigning controls to mouse actions - Frank
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack.StartAction();
        }

        else if (Input.GetMouseButtonDown(1))
        {
            Dodge.StartAction();
        }
        else if (Input.GetMouseButtonDown(2))
        {
            CurrentAbility.StartAction();
        }

        else if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            Movement.StartAction();
        }
        else
       {
           Idle.StartAction();
       }
    }

   
}
