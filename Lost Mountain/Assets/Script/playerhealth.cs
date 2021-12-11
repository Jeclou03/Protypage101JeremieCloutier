using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class playerhealth : MonoBehaviour
    {
        #region
        public GameObject Flake;
        public JayScript CurrentBar;
        #endregion
        private bool isSuffocate = false;
        private bool isDead = false;
        private Rigidbody rbPlayer;

        [SerializeField]
        public GameObject Gm;

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
            // mort du joueur si collision avec la deathzone
            if (collider.gameObject.tag == "DeathZone")
            {
                CurrentBar.CurrentBar = 0;
            }
        }

    }



