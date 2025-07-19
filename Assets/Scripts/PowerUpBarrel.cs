using UnityEngine;

public class PowerUpBarrel : MonoBehaviour, IDamageable
{
    [SerializeField]
    private int weaponLevel = 1;
    [SerializeField]
    private float health = 10f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            CollectPowerUp();
        }
    }

    void CollectPowerUp()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.UpgradeWeapon(weaponLevel);
        }
        Destroy(gameObject);
    }
}
