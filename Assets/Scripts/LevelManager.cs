using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    [SerializeField]
    private int levelIndex;

    private AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(levelIndex);
        }
    }


    public void LoadChosenScene()
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void ExitCode()
    {
        Application.Quit();
    }

//----------------------------------------------------

    public void LoadWithSound()
    {
        sound = GetComponent<AudioSource>();

        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        sound.PlayDelayed(0);
        yield return new WaitForSeconds(sound.clip.length);
        SceneManager.LoadScene(levelIndex);

    }
}