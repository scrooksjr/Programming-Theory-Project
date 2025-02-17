using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // INHERITANCE
    // POLYMORPHISM

    public int health;
    public int damage;

    public virtual void DealDamage()
    {
        health -= 10;
    }

    public void Attack(int damage)
    {
        Debug.Log("Enemy attacks with " + damage + " damage.");
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Enemy dies.");
        Destroy(gameObject);
    }
}

public class Thief : Character
{

    public void ThiefHit(int damage)
    {
        Debug.Log("Thief hit.");
    }
    public override void DealDamage() // Can override virtual methods from parent class.
    {
        health -= 2;
    }

    private void Update()
    {
        DealDamage(); // Method from parent class can be called.
    }
}

public class BankRobber : Character
{
    public void BankRobberHit(int damage)
    {
        Debug.Log("BankRobber hit.");
    }
}