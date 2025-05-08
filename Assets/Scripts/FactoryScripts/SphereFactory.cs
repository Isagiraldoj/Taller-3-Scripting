using UnityEngine;

public class SphereFactory : IObjectFactory
{
    private GameObject prefab;

    public SphereFactory(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public GameObject CreateObject()
    {
        return GameObject.Instantiate(prefab);
    }
}
