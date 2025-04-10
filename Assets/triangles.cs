using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class triangles : MonoBehaviour
{
    // Start is called before the first frame update
    public class Enemy : MonoBehaviour
    {
        public float health = 1;

        public void GetDamage()
        {
            health--;
            Debug.Log("Enemy took damage!");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
