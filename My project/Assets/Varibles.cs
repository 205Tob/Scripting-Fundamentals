using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varibles : MonoBehaviour
{
    //Public Global/Member Varibles
    public int Score = 0; // declare a whole number
    public float ItemAmount = 19.95f; //decimal number
    public string PlayerName = "Child_Predetor4473"; // declare a text
    public bool IsPlayerActivity = true; //declare a true/false

    // private Global/Member Variable
    private int _collectibleAmount = 0;
    private float _horizontalInput = 0f;
    private string _username = "MoeLester8917";
    private bool _isGameOver = false;
    
    // Start is called before the first frame update
    void Start()
    {
        // make sure score is equal to 0
        Score = 0; //assigning a Global/Member varible

        //declare a local varible to track Start Position
        Vector3 startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // trying to update a local varible value will not work
        // create a variable to determine object key movement
        float verticalInput = Input.GetAxis("Vertical");
    }
}
