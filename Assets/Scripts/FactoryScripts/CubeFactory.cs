using UnityEngine;

public class CubeFactory : IObjectFactory
{
    private GameObject prefab;

    public CubeFactory(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public GameObject CreateObject()
    {
        return GameObject.Instantiate(prefab);
    }
}
