using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameToTutorialGreyboxPortal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            SceneManager.LoadScene("Greyboxing Scene (Tutorial)");
            Time.timeScale = 1f;
        }

    }

}
