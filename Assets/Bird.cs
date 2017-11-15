using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private PlayMakerFSM _playMakerFSM;

    private Rigidbody2D _rigidbody2D;

    // Use this for initialization
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playMakerFSM = GetComponent<PlayMakerFSM>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void SetForce(Vector2 power)
    {
        Vector2 vector = _rigidbody2D.velocity;
        vector.y = 0;
        _rigidbody2D.velocity = vector;
        _rigidbody2D.AddForce(power);

    }

 

    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayMakerFSM.BroadcastEvent("GameOver");
       
    }
}
