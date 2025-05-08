using UnityEngine;
using UnityEngine.SceneManagement;  // Necesario para cargar escenas

public class MainMenuManager : MonoBehaviour
{
    // Método para cargar la escena Factory
    public void LoadFactoryScene()
    {
        SceneManager.LoadScene("Factory");  // Nombre de la escena Factory
    }

    // Método para cargar la escena Observer
    public void LoadObserverScene()
    {
        SceneManager.LoadScene("Observer");  // Nombre de la escena Observer
    }

    // Método para cargar la escena Projectile
    public void LoadProjectileScene()
    {
        SceneManager.LoadScene("Projectile");  // Nombre de la escena Projectile
    }

   public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");  // Nombre de la escena del menú principal
    }

}
