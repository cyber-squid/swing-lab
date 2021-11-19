using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{

    public GameObject UIobject;

    // Start is called before the first frame update
    void Start()
    {
        UIobject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            UIobject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
