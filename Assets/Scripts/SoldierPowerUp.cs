using UnityEngine;

public class SoldierPowerUp : MonoBehaviour, IDamageable
{
    [SerializeField]
    private int soldierValue = 1;
    [SerializeField]
    private float lifetime = 5f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float amount)
    {
        soldierValue += Mathf.RoundToInt(amount);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.AdjustSoldiers(soldierValue);
            }
            Destroy(gameObject);
        }
    }
}
