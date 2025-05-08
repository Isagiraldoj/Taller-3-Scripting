using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    public static ColliderManager Instance;

    private Collider targetCollider;
    private bool isCooldown = false;

    void Awake()
    {
        Instance = this;
        targetCollider = GetComponent<Collider>();
    }

    public void TemporarilyDisableCollider()
    {
        if (!isCooldown)
        {
            StartCoroutine(DisableAndReactivate());
        }
    }

    private System.Collections.IEnumerator DisableAndReactivate()
    {
        isCooldown = true;
        targetCollider.enabled = false;
        Debug.Log("Tipo 2: Collider desactivado por 1 segundo.");
        yield return new WaitForSeconds(1f);
        targetCollider.enabled = true;
        isCooldown = false;
    }
}
