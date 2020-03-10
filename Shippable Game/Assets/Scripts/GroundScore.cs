using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GroundScore : MonoBehaviour
{
    public GameObject Floor;
    public Text text;
    public float ScoreTotal = 0;

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        void Total()
        {
            text.text = "Score: " + ScoreTotal;
            if (Input.GetKeyDown(KeyCode.Mouse0) == true)
            {
                ScoreTotal += 1;

            }
        }
        Total();
    }
}     


