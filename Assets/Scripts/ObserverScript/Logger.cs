using UnityEngine;

public class Logger : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnButtonClicked += Log;
    }

    void Log(int n)
    {
        Debug.Log("Número actual: " + n);
    }

    void OnDisable()
    {
        EventManager.OnButtonClicked -= Log;
    }
}
