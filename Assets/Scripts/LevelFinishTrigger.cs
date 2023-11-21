using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelFinishTrigger : MonoBehaviour
{
    public Canvas congratsCanvas;
    [SerializeField]private AudioSource audioSource;
    [SerializeField]private AudioSource courseClear;

    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el personaje ha colisionado con el trigger
        if (other.CompareTag("Player"))
        {
            // Activa el Canvas de "Congrats!"
            congratsCanvas.gameObject.SetActive(true);
            if (audioSource != null)
            {
                audioSource.Stop();
                courseClear.Play();
            }
            StartCoroutine(reset());
        }
    }

    IEnumerator reset(){
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }  
}
