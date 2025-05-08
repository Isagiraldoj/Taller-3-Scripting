using UnityEngine;

public class ClickEmitter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EventManager.EmitirClick();
        }
    }
}
