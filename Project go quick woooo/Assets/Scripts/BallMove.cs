using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMove : MonoBehaviour
{
    public float mySpeed;
    public string EndLevel;
    void Update()
    {
        transform.position += transform.forward * mySpeed * Time.deltaTime; 
    }

    void OnTriggerEnter (Collider col)
    {
        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(EndLevel);
        }
    }
}
