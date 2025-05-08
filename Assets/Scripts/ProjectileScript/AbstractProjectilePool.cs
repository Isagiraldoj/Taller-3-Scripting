using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractProjectilePool : MonoBehaviour
{
    [SerializeField] protected GameObject projectilePrefab;
    [SerializeField] protected int initialSize = 10;

    protected Queue<GameObject> pool = new Queue<GameObject>();

    protected virtual void Start()
    {
        for (int i = 0; i < initialSize; i++)
        {
            GameObject proj = Instantiate(projectilePrefab);
            proj.SetActive(false);
            pool.Enqueue(proj);
        }
    }


    public virtual GameObject GetFromPool()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            GameObject obj = Instantiate(projectilePrefab);
            return obj;
        }
    }

    public virtual void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
