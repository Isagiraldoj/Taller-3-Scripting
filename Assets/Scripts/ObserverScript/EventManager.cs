using System;
using UnityEngine;

public static class EventManager
{
    public static event Action<int> OnButtonClicked;
    private static int contador = 0;

    public static void EmitirClick()
    {
        contador++;
        if (contador > 4) contador = 1;

        OnButtonClicked?.Invoke(contador);
    }
}
