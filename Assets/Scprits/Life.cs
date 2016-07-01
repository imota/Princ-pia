using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour
{
    public float max_life = 1;
    public float life = 1;

    public void Heal(float amount)
    {
        life += amount;
        if (life > max_life)
            life = max_life;
    }

    public void Heal()
    {
        life = max_life;
    }

    public void Damage(float amount)
    {
        life -= amount;
    }

    public void Kill()
    {
        life = 0;
    }

    public bool isDead()
    {
        return life <= 0;
    }
}