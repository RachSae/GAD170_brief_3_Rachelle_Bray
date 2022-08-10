using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{


    public class HealthPack : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
           if (other.CompareTag("Player"))
            {
                other.GetComponent<Tank>().tankHealth.ApplyHealthChange(20);
                
            }
        }
    }
}