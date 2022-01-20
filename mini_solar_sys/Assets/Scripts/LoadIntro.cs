using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadIntro : MonoBehaviour
{
    public float wait_time = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitIntro());

    }
    IEnumerator waitIntro()
    {
        //wait for scene 0
        yield return new WaitForSeconds(wait_time);

        // load the next Scene in Unity (1)
        SceneManager.LoadScene(1);
    }
}