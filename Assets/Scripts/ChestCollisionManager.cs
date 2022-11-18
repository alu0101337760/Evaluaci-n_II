using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollisionManager : MonoBehaviour
{
    public delegate void collision();
    public collision OnCollisionWithPlayer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OnCollisionWithPlayer();
        }
    }

}
