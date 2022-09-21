using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{

    private ICommand rightButtonHeld;
    private ICommand leftButtonHeld;
    private ICommand spacePressed;
    private ICommand shiftHeld;

    public InputHandler(ICommand _right, ICommand _left, ICommand _space, ICommand _shift)
    {
        this.rightButtonHeld = _right;
        this.leftButtonHeld = _left;
        this.spacePressed = _space;
        this.shiftHeld = _shift;
    }

    public ICommand HandleInput()
    {

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            return rightButtonHeld;
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            return leftButtonHeld;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            return spacePressed;
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            return shiftHeld;
        }

        return null;
        
    }

}