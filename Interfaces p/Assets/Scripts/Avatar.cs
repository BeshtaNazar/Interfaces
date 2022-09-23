using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    //The required method of the IKillable interface
    public void Kill()
    {
        Debug.Log("Kill");
    }

    //The required method of the IDamageable interface
    public void Damage(float damageTaken)
    {
        Debug.Log(damageTaken);
    }
    public void Start()
    {
        Kill();
        Damage(12);
    }
}
