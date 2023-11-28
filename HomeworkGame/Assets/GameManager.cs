using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource note1;
    public AudioSource note2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            note1.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            note2.Play();
        }
    }
}
