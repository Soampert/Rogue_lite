using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float EnemyHP;
    public float Damage;
    public float Speed;
    
    private GameManager GameMangerScript;
    // Start is called before the first frame update
    void Start()
    {
        GameMangerScript = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameMangerScript.HpPlayer -= Damage;
            Debug.Log($"{GameMangerScript.HpPlayer}");
        }
    }
}
