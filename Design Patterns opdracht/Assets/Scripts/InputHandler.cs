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

    private ICommand oneButtonPressed;
    private ICommand twoButtonPressed;
    private ICommand threeButtonPressed;

    private ICommand fButtonPressed;

    public InputHandler(ICommand _right, ICommand _left, ICommand _space, ICommand _shiftHeld, ICommand _shiftReleased, ICommand _one, ICommand _two, ICommand _three, ICommand _f)
    {
        this.rightButtonHeld = _right;
        this.leftButtonHeld = _left;
        this.spacePressed = _space;
        this.shiftHeld = _shiftHeld;
        this.shiftReleased = _shiftReleased;

        this.oneButtonPressed = _one;
        this.twoButtonPressed = _two;
        this.threeButtonPressed = _three;

        this.fButtonPressed = _f;
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

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            commands.Add(oneButtonPressed);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            commands.Add(twoButtonPressed);
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            commands.Add(threeButtonPressed);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            commands.Add(fButtonPressed);
        }

        return commands;
        
    }

}