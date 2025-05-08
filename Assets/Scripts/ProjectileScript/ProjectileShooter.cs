using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public float projectileSpeed = 20f;
    private ProjectileType currentType = ProjectileType.Type1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Click izquierdo
        {
            Shoot();
        }

        if (Input.GetMouseButtonDown(1)) // Click derecho
        {
            CycleProjectileType();
        }
    }

    void Shoot()
    {
        GameObject projectile = null;

        switch (currentType)
        {
            case ProjectileType.Type1:
                projectile = Type1ProjectilePool.Instance.GetFromPool();
                break;

            case ProjectileType.Type2:
                projectile = Type2ProjectilePool.Instance.GetFromPool();
                break;

            case ProjectileType.Type3:
                projectile = Type3ProjectilePool.Instance.GetFromPool();
                break;
        }

        if (projectile != null)
        {
            projectile.transform.position = transform.position;
            projectile.transform.rotation = Quaternion.identity;

            Projectile script = projectile.GetComponent<Projectile>();
            script.type = currentType;
            script.Launch(transform.forward, projectileSpeed);
        }
    }

    void CycleProjectileType()
    {
        currentType++;
        if ((int)currentType > 2) currentType = ProjectileType.Type1;

        Debug.Log("Tipo actual: " + currentType);
    }
}
