using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{

    private ICommand rightButtonHeld;
    private ICommand leftButtonHeld;
    private ICommand spacePressed;
    private ICommand shiftHeld;
    private ICommand shiftReleased;

    public InputHandler(ICommand _right, ICommand _left, ICommand _space, ICommand _shiftHeld, ICommand _shiftReleased)
    {
        this.rightButtonHeld = _right;
        this.leftButtonHeld = _left;
        this.spacePressed = _space;
        this.shiftHeld = _shiftHeld;
        this.shiftReleased = _shiftReleased;
    }

    public List<ICommand> HandleInput()
    {

        List<ICommand> commands = new List<ICommand>();

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            commands.Add(rightButtonHeld);
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            commands.Add(leftButtonHeld);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            commands.Add(spacePressed);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            commands.Add(shiftHeld);
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            commands.Add(shiftReleased);
        }

        return commands;
        
    }

}