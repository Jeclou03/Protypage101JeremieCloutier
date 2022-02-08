using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class JayScript : MonoBehaviour
    {
        #region
        public int MaxBar = 1000;
        public int CurrentBar;
        public oxygenbar UiBar;
        
        #endregion
        private bool canTake = true;
        private Rigidbody rb;
        public bool CanStart;

        private void Awake()
        {
            CanStart = GetComponent<Move>();
        }
        void Start()
        {
            //Bar max en commancant le jeu
            CurrentBar = MaxBar;
            UiBar.SetMaxHealth(MaxBar);
            rb = this.GetComponent<Rigidbody>();
            
        }

    private void Update()
        {
            // Perde du fuel par seconde
            // (1/3)
            if (canTake == true )
            {
                TakeDamage(1);
                canTake = false;
                StartCoroutine(WaitToTake());
            }
        }
        IEnumerator WaitToTake()
        {
            // (2/3)
            yield return new WaitForSeconds(0.02f);
            canTake = true;
        }

        void TakeDamage(int damage)
        {
            // (3/3)
            CurrentBar -= damage;
            UiBar.SetHealth(CurrentBar);
        }

        private void OnCollisionEnter(Collision collision)
        {
            // remise au max avec les collectibles 
            if (collision.gameObject.tag == "Collectible")
            {
                UiBar.SetMaxHealth(MaxBar);
                CurrentBar = MaxBar;
            }
        }
    }