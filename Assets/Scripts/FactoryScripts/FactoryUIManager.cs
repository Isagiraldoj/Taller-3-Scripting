using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FactoryUIManager : MonoBehaviour
{
    public Button cubeButton;
    public Button sphereButton;
    public Button capsuleButton;
    public Button spawnButton;
    public Button backButton;

    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject capsulePrefab;

    private ObjectSpawner spawner;

    void Start()
    {
        spawner = new ObjectSpawner(cubePrefab, spherePrefab, capsulePrefab);

        cubeButton.onClick.AddListener(() => spawner.SetObjectType(ObjectType.Cube));
        sphereButton.onClick.AddListener(() => spawner.SetObjectType(ObjectType.Sphere));
        capsuleButton.onClick.AddListener(() => spawner.SetObjectType(ObjectType.Capsule));
        spawnButton.onClick.AddListener(() => spawner.Spawn());
        backButton.onClick.AddListener(() => SceneManager.LoadScene("MainMenu"));
    }
}
