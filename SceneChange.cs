using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public int num;
    private int counter = 1;
    public AudioSource audioSource;
    public AudioClip clip2;
    public AudioClip clip3;

    // Use this for initialization
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (num == 3 && counter < 3)
            {
                if (counter == 1)
                    audioSource.PlayOneShot(clip2);
                else if (counter == 2)
                    audioSource.PlayOneShot(clip3);
                counter++;
            }
            else
            {
                SceneManager.LoadScene(num);
                Debug.Log("Scene changed to " + num);
            }
        }
    }
}