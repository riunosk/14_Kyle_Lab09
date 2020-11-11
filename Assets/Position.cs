using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Position : MonoBehaviour
{
    float X;
    float Y;
    float Z;

    public GameObject PlayerPosition;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        X = Player.transform.position.x;
        Y = Player.transform.position.y;
        Z = Player.transform.position.z;
        PlayerPosition.GetComponent<Text>().text = "Position: (" + X + ", " + Y + ", " + ", " + Z + ")";
    }
}
