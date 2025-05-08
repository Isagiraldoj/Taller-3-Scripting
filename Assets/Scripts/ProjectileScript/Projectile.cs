using UnityEngine;

public class Projectile : MonoBehaviour
{
    public ProjectileType type;
    public GameObject impactEffect;  // solo para tipo 3

    public void Launch(Vector3 direction, float speed)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.linearVelocity = direction * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            switch (type)
            {
                case ProjectileType.Type1:
                    Debug.Log("Tipo 1: ¡Impacto registrado!");
                    break;

                case ProjectileType.Type2:
                    ColliderManager.Instance.TemporarilyDisableCollider();
                    break;

                case ProjectileType.Type3:
                    if (impactEffect != null)
                    {
                        impactEffect.SetActive(true);
                        Invoke(nameof(DisableEffect), 0.5f); // Desactivar después de un rato
                    }
                    break;
            }

            gameObject.SetActive(false); // "Recicla" el proyectil
        }
    }

    void DisableEffect()
    {
        if (impactEffect != null)
            impactEffect.SetActive(false);
    }
}
