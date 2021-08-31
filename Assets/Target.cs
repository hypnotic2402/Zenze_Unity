
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public done lol;
    
    public void takeDmg(float dmg){

        health -= dmg;
        if (health <= 0f)
        {
            Die();
        }

    }

    public void Die()
    {
        Destroy(gameObject);
        lol.inc();
    }


}
