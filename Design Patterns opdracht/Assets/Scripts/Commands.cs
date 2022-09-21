using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkRightCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        //Walk right
    }
}

public class WalkLeftCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        //Walk left
    }
}

public class JumpCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        //Do a jump
    }
}

public class SprintCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        //Sprint
    }
}