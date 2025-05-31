using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float _hp = 100f;
    public bool IsDead { get; private set; } = false;

    public void GetDamage(float damage)
    {
        if (IsDead) return;

        _hp -= damage;
        Debug.Log($"Character took {damage} damage. HP: {_hp}");

        if (_hp <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        IsDead = true;
        Debug.Log("Character died!");
       
    }
}
