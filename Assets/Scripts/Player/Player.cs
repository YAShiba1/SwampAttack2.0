using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Transform _shootPoint;

    public int Money { get; private set; }

    private Weapon _currentWeapon;
    private int _currentHealth;
    private Animator _animator;

    private void Start()
    {
        _currentWeapon = _weapons[0];
        _currentHealth = _health;
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown((int)MouseButton.Left)) 
        {
            _currentWeapon.Shoot(_shootPoint);
        }
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;

        if(_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void AddMoney(int money)
    {
        Money += money;
    }

    private void OnEnemyDied(int reward)
    {
        Money += reward;
    }
}