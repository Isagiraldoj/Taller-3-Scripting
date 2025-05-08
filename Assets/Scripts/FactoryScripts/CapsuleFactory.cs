using UnityEngine;

public class CapsuleFactory : IObjectFactory
{
    private GameObject prefab;

    public CapsuleFactory(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public GameObject CreateObject()
    {
        return GameObject.Instantiate(prefab);
    }
}
