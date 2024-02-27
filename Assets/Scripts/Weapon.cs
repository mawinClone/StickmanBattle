using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public bool canAttack;
    public Transform attackerTransform;

    public void SetAttackStatus(bool setAttack)
    {
        canAttack = setAttack;
        // Debug.Log(canAttack);
    }

    


}
