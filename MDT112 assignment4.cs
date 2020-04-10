using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MDT112_assignment4
{
    public class Shooting : MonoBehaviour
    {
        public GameObject bulletPosition;
        public GameObject bullet;
        public float speed = 10000f;
         //Start is called before the first frame update
         void Start()
        {

        }

        //Update is called once per frame
        void Update()
        {
            if(Input.GetButtonDown("firel"))
            {
                GameObject instBullet = Instaniate(bullet, bulletPosiyion.Tranform.position, bulletPostion.tranform.rotation) as GameObject;
                Rigidbody intBulletRigidbody = instBullet.GetComponent<tRigidbody>();
                
                instBulletRigidbody.AddForce(bulletPosition.TranForm.forward * speed);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.Equals())
            {
                Debug.Log("You Win");
            }
        }
    }
}
