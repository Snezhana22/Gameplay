using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private Character _character;
    private float _damageTimer = 0f;
    private const float DAMAGE_INTERVAL = 1f; // Интервал в секундах

    private void Start()
    {
        // Автоматически ищем компонент Character если не установлен в инспекторе
        if (_character == null)
        {
            _character = GetComponent<Character>();
            if (_character == null)
            {
                Debug.LogError("Character component not found on the same GameObject!");
            }
        }
    }

    private void Update()
    {
        if (_character == null || _character.IsDead) return;

        _damageTimer += Time.deltaTime;

        if (_damageTimer >= DAMAGE_INTERVAL)
        {
            _character.GetDamage(10f * DAMAGE_INTERVAL); // 10 урона в секунду
            _damageTimer = 0f;
        }
    }
}
