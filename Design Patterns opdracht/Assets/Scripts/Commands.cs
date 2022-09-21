using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkRightCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        _actor.GetComponent<Player>().Move(1);
    }
}

public class WalkLeftCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        _actor.GetComponent<Player>().Move(-1);
    }
}

public class JumpCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        _actor.GetComponent<Player>().Jump();
    }
}

public class SprintCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        //Sprint
    }
}