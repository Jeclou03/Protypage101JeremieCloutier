using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class playerhealth : MonoBehaviour
    {
        #region
        public GameObject Flake;


        #endregion
        private bool isSuffocate = false;
        private bool isDead = false;

        public JayScript CurrentBar;
        
        [SerializeField]
        public GameObject Gm;


        //private bool isRespawn = true;
        private Rigidbody rbPlayer;
        //---------------------------------------------
        void Awake()
        {
           CurrentBar = GetComponent<JayScript>();
           rbPlayer = this.GetComponent<Rigidbody>();
        }

        void Update()
        {
            //suffocation du joueur
            if (isSuffocate == false && CurrentBar.CurrentBar <= 0)
            {
                Flake.transform.parent = null;
                rbPlayer.constraints = RigidbodyConstraints.None;
                isSuffocate = true;
            }

            //mort du joueur apres suffocation et reload de la scene
            if (CurrentBar.CurrentBar < -300 && isDead == false)
            {
                isDead = true;
                Gm.GetComponent<GameManager>().AddGameplayed();
                SceneManager.LoadScene(0);
            }
        }
        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.tag == "DeathZone")
            {
                CurrentBar.CurrentBar = 0;
            }
        }

    }



