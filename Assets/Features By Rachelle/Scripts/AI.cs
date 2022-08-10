using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{

    public class AI : MonoBehaviour
    {
        [SerializeField] private Tank playerTank;
        [SerializeField] private Tank aiTank;
        [SerializeField] private float timer;
        [SerializeField] private float timerReset = 5;
        private void Start()
        {
            aiTank = GetComponent<Tank>();
        }
        private void Update()
        {
            timer -= Time.deltaTime;

            if (playerTank)
            {
                aiTank.transform.LookAt(playerTank.transform.position);
            }

            if (timer < 0)
            {
                timer = timerReset;
                GetComponent<Tank>().tankMainGun.FireWeapon();
            }
        }
    }
}
