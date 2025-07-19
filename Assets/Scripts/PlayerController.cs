using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform firePoint;

    private Camera mainCamera;
    private bool isDragging = false;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        HandleTouch();
    }

    void HandleTouch()
    {
#if ENABLE_INPUT_SYSTEM
        if (Touchscreen.current != null)
        {
            var touch = Touchscreen.current.primaryTouch;
            float distance = mainCamera.WorldToScreenPoint(transform.position).z;
            Vector3 touchPos = mainCamera.ScreenToWorldPoint(new Vector3(touch.position.ReadValue().x, touch.position.ReadValue().y, distance));

            if (touch.press.wasPressedThisFrame)
            {
                isDragging = true;
            }
            else if (touch.press.wasReleasedThisFrame)
            {
                isDragging = false;
                Shoot();
            }

            if (isDragging)
            {
                Vector3 targetPos = new Vector3(touchPos.x, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
            }
        }
#else
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float distance = mainCamera.WorldToScreenPoint(transform.position).z;
            Vector3 touchPos = mainCamera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, distance));

            if (touch.phase == TouchPhase.Began)
            {
                isDragging = true;
            }
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                isDragging = false;
                Shoot();
            }

            if (isDragging)
            {
                Vector3 targetPos = new Vector3(touchPos.x, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
            }
        }
#endif
    }

    void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
