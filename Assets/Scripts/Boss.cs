using UnityEngine;

public class Boss : MonoBehaviour, IDamageable
{
    [SerializeField]
    private float health = 50f;
    [SerializeField]
    private float moveSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore(10);
        }
        Destroy(gameObject);
    }
}
