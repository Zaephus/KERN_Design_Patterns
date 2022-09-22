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
        _actor.GetComponent<Player>().isSprinting = true;
    }
}

public class WalkCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        _actor.GetComponent<Player>().isSprinting = false;
    }
}

public class ToAbilityOneCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        _actor.GetComponent<Player>().SetCurrentAbility(0);
    }
}

public class ToAbilityTwoCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        _actor.GetComponent<Player>().SetCurrentAbility(1);
    }
}

public class ToAbilityThreeCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        _actor.GetComponent<Player>().SetCurrentAbility(2);
    }
}

public class ActivateAbilityCommand : ICommand
{
    public void Execute(GameObject _actor)
    {
        _actor.GetComponent<Player>().ActivateAbility();
    }
}