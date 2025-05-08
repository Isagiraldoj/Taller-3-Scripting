using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        EventManager.OnButtonClicked += CambiarColor;
    }

    void CambiarColor(int n)
    {
        Color color = Color.white;

        switch (n)
        {
            case 1: color = Color.red; break;
            case 2: color = Color.green; break;
            case 3: color = Color.blue; break;
            case 4: color = Color.yellow; break;
        }

        rend.material.color = color;
    }

    void OnDestroy()
    {
        EventManager.OnButtonClicked -= CambiarColor;
    }
}
