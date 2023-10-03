using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseui; 

    private bool isPaused = false;

    void Update()
    {
        // Verifica si se ha presionado la tecla Esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Si el juego no está pausado, pausarlo
            if (!isPaused)
            {
                PauseGame();
            }
            // Si el juego ya está pausado, reanudarlo
            else
            {
                ResumeGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0; // Pausar el tiempo del juego
        pauseui.SetActive(true); // Activar el Canvas del menú de pausa
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1; // Reanudar el tiempo del juego
        pauseui.SetActive(false); // Desactivar el Canvas del menú de pausa
        isPaused = false;
    }

    // Agrega métodos adicionales según tus necesidades, por ejemplo, para manejar opciones, salir, etc.
}
