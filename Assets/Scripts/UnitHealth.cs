using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth
{
    int _currentHealth;
    int _currentMaxHealth;

    public int Health
    {
        get 
        {
            return _currentHealth;
        }
        set 
        {
            _currentHealth = value;
        }
    }

    public int MaxHealth 
    {
        get 
        {
            return _currentMaxHealth;
        }
        set 
        {
            _currentHealth = value;
        }
    }

    //Constructor
    public UnitHealth(int health, int maxHealth) 
    {
        _currentHealth = health;
        _currentMaxHealth = maxHealth;
    }

    //Methods
    public void Dmg(int dmgAmount) 
    {
        if (_currentHealth > 0) 
        {
            _currentHealth -= dmgAmount;
        }
    }

    public void Heal(int healAmount) 
    {
        if (_currentHealth < _currentMaxHealth) 
        {
            _currentHealth += healAmount;
        }
        if (_currentHealth > _currentMaxHealth)
        {
            _currentHealth = _currentMaxHealth;
        }
    }
}
