using UnityEngine;

public enum ObjectType { Cube, Sphere, Capsule }

public class ObjectSpawner
{
    private IObjectFactory cubeFactory;
    private IObjectFactory sphereFactory;
    private IObjectFactory capsuleFactory;

    private ObjectType currentType = ObjectType.Cube;

    public ObjectSpawner(GameObject cube, GameObject sphere, GameObject capsule)
    {
        cubeFactory = new CubeFactory(cube);
        sphereFactory = new SphereFactory(sphere);
        capsuleFactory = new CapsuleFactory(capsule);
    }

    public void SetObjectType(ObjectType type)
    {
        currentType = type;
    }

    public void Spawn()
    {
        GameObject obj = null;

        switch (currentType)
        {
            case ObjectType.Cube:
                obj = cubeFactory.CreateObject();
                break;
            case ObjectType.Sphere:
                obj = sphereFactory.CreateObject();
                break;
            case ObjectType.Capsule:
                obj = capsuleFactory.CreateObject();
                break;
        }

        if (obj != null)
        {
            obj.transform.position = new Vector3(Random.Range(-3, 3), 1, 0);
        }
    }
}
