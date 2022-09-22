using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{
    public virtual void Activate() {}

    protected void PlaySound(string _soundType)
    {
        Debug.Log(_soundType);
    }

    protected void SpawnParticles(string _particleType)
    {
        Debug.Log(_particleType);
    }

    protected void PrintName(string _name)
    {
        Debug.Log(_name);
    }

}

public class Dash : Ability
{
    public override void Activate()
    {
        PlaySound("Swoosh_Sound");
        SpawnParticles("Dust_Particles");
        PrintName("Dash_Ability");
    }
}

public class FireSpell : Ability
{
    public override void Activate()
    {
        PlaySound("Fiery_Crackling_Sound");
        SpawnParticles("Smoke_Fire_Particles");
        PrintName("FireSpell_Ability");
    }
}

public class FusRoDah : Ability
{
    public override void Activate()
    {
        PlaySound("FUS RO DAH");
        SpawnParticles("Force_Field_Particle");
        PrintName("FusRoDah_Ability");
    }
}