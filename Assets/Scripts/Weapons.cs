using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public float Damage;
    private Enemy EnemyScript;

    // Start is called before the first frame update
    void Start()
    {
        EnemyScript = FindObjectOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyScript.EnemyHP -= Damage;
            Debug.Log($"{EnemyScript.EnemyHP}");
        }
    }
}
