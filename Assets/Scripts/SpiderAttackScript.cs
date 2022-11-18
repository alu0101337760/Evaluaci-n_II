using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using Unity.VisualScripting;
using UnityEngine;
using static ChestCollisionManager;

public class SpiderAttackScript : MonoBehaviour
{

    public int damage = 10;
    public float attackRange = 4;

    private BoxCollider spiderCollider;
    private SphereCollider attackTrigger;

    private void Start()
    {
        spiderCollider = this.GetComponent<BoxCollider>();
        attackTrigger = this.AddComponent<SphereCollider>();
        attackTrigger.isTrigger = true;
        attackTrigger.enabled = true;   
        attackTrigger.radius = attackRange;
        attackTrigger.center = spiderCollider.center;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerHealth>().DamagePlayer(damage);
        }
    }
 
}
