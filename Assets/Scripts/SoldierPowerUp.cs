using UnityEngine;

public class SoldierPowerUp : MonoBehaviour
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

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // TODO: add or remove soldiers from player based on soldierValue
            Destroy(gameObject);
        }
    }
}
