
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
        
        transform.Translate(urInput, myInput, 0);
    }

    public void Up()
    {
        transform.Translate(0,speed, 0);
    }
}
