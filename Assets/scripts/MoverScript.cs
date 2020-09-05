
using System;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100;

    public float health = 100;

    private void Update()
    {
        var myInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var urInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        
        transform.Translate(myInput, urInput, 0);
    }
    
}
