using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int Respawn;


    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        
=======

>>>>>>> origin/Diego
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======

>>>>>>> origin/Diego
    }

    void OnTriggerEnter2D(Collider2D other)
    {
<<<<<<< HEAD
        if(other.CompareTag("Player"))
=======
        if (other.CompareTag("Player"))
>>>>>>> origin/Diego
        {
            SceneManager.LoadScene(Respawn);
        }
    }

}
<<<<<<< HEAD
=======


>>>>>>> origin/Diego
