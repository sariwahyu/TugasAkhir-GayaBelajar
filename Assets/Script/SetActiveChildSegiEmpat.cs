using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Lean.Touch
{
    public class SetActiveChildSegiEmpat : MonoBehaviour
    {

        [Tooltip("List time change each child!")]
        public float timeNow = 0.0f;
        public float timeChangeSisi0 = 2.0f;
        public float timeChangeSisi1 = 4.0f;
        public float timeChangeSisi2 = 6.0f;
        public float timeChangeSisi3 = 8.0f;

        public float timeChangeSudut0 = 12.0f;
        public float timeChangeSudut1 = 14.0f;
        public float timeChangeSudut2 = 16.0f;
        public float timeChangeSudut3 = 18.0f;

        [Tooltip("Duration time looping for each part?")]
        public float timeEndSisi = 10.0f;
        public float timeEndSudut = 20.0f;

        public Vector3 Axis = Vector3.zero;
        public Space Space = Space.World;
        public float Degrees = 0.0f;

        void Update()
        {
            timeNow += Time.deltaTime;
            transform.Rotate(Axis, Degrees, Space);

            //Sisi

            if (timeNow > timeChangeSisi0 && timeChangeSisi0 != 0)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
            if (timeNow > timeChangeSisi1 && timeChangeSisi1 != 0)
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
            if (timeNow > timeChangeSisi2 && timeChangeSisi2 != 0)
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }
            if (timeNow > timeChangeSisi3 && timeChangeSisi3 != 0)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }


            if (timeNow > timeEndSisi)
            {
                if (timeChangeSisi0 != 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                if (timeChangeSisi1 != 0)
                {
                    transform.GetChild(1).gameObject.SetActive(false);
                }
                if (timeChangeSisi2 != 0)
                {
                    transform.GetChild(2).gameObject.SetActive(false);
                }
                if (timeChangeSisi3 != 0)
                {
                    transform.GetChild(3).gameObject.SetActive(false);
                }
            }

            //Sudut
            if (timeNow > timeChangeSudut0 && timeChangeSudut0 != 0)
            {
                transform.GetChild(4).gameObject.SetActive(true);
            }
            if (timeNow > timeChangeSudut1 && timeChangeSudut1 != 0)
            {
                transform.GetChild(5).gameObject.SetActive(true);
            }
            if (timeNow > timeChangeSudut2 && timeChangeSudut2 != 0)
            {
                transform.GetChild(6).gameObject.SetActive(true);
            }
            if (timeNow > timeChangeSudut3 && timeChangeSudut3 != 0)
            {
                transform.GetChild(7).gameObject.SetActive(true);
            }


            if (timeNow > timeEndSudut)
            {
                if (timeChangeSudut0 != 0)
                {
                    transform.GetChild(4).gameObject.SetActive(false);
                }
                if (timeChangeSudut1 != 0)
                {
                    transform.GetChild(5).gameObject.SetActive(false);
                }
                if (timeChangeSudut2 != 0)
                {
                    transform.GetChild(6).gameObject.SetActive(false);
                }
                if (timeChangeSudut3 != 0)
                {
                    transform.GetChild(7).gameObject.SetActive(false);
                }
                timeNow = 0.0f;
            }
        }
    }

}