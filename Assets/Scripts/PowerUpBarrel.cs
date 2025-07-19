using UnityEngine;

public class PowerUpBarrel : MonoBehaviour
{
    public int weaponLevel = 1;
    public float health = 10f;

    void Update()
    {
        if (health <= 0)
        {
            CollectPowerUp();
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
    }

    void CollectPowerUp()
    {
        // TODO: give player new weapon based on weaponLevel
        Destroy(gameObject);
    }
}
