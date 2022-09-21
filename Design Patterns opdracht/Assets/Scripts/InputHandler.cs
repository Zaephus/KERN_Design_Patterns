using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{

    private ICommand rightButtonPressed;
    private ICommand leftButtonPressed;
    private ICommand spacePressed;
    private ICommand shiftPressed;

    public InputHandler(ICommand _right, ICommand _left, ICommand _space, ICommand _shift)
    {
        this.rightButtonPressed = _right;
        this.leftButtonPressed = _left;
        this.spacePressed = _space;
        this.shiftPressed = _shift;
    }

    public ICommand HandleInput()
    {

        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            return rightButtonPressed;
        }

        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return leftButtonPressed;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            return spacePressed;
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            return shiftPressed;
        }

        return null;
        
    }

}