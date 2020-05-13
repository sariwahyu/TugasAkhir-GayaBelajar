using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Lean.Touch
{
    public class SetActiveChildGlobal : MonoBehaviour
    {

        [Tooltip("List time change each child!")]
        public float timeNow = 0.0f;
        public float timeChange0 = 2.0f;
        public float timeChange1 = 0.0f;
        public float timeChange2 = 0.0f;
        public float timeChange3 = 0.0f;
        public float timeChange4 = 0.0f;
        public float timeChange5 = 0.0f;
        public float timeChange6 = 0.0f;
        public float timeChange7 = 0.0f;
        public float timeChange8 = 0.0f;
        public float timeChange9 = 0.0f;
        public float timeChange10 = 0.0f;
        public float timeChange11 = 0.0f;


        [Tooltip("Duration time looping for each part?")]
        public float timeEnd = 15.0f;

        public Vector3 Axis = Vector3.down;
        public Space Space = Space.Self;
        public float Degrees = -1.0f;

        void Update()
        {
            timeNow += Time.deltaTime;
            transform.Rotate(Axis, Degrees, Space);

            if (timeNow > timeChange0 && timeChange0 != 0)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
            if (timeNow > timeChange1 && timeChange1 != 0)
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
            if (timeNow > timeChange2 && timeChange2 != 0)
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }
            if (timeNow > timeChange3 && timeChange3 != 0)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
            if (timeNow > timeChange4 && timeChange4 != 0)
            {
                transform.GetChild(4).gameObject.SetActive(true);
            }
            if (timeNow > timeChange5 && timeChange5 != 0)
            {
                transform.GetChild(5).gameObject.SetActive(true);
            }

            if (timeNow > timeChange6 && timeChange6 != 0)
            {
                transform.GetChild(6).gameObject.SetActive(true);
            }
            if (timeNow > timeChange7 && timeChange7 != 0)
            {
                transform.GetChild(7).gameObject.SetActive(true);
            }
            if (timeNow > timeChange8 && timeChange8 != 0)
            {
                transform.GetChild(8).gameObject.SetActive(true);
            }
            if (timeNow > timeChange9 && timeChange9 != 0)
            {
                transform.GetChild(9).gameObject.SetActive(true);
            }
            if (timeNow > timeChange10 && timeChange10 != 0)
            {
                transform.GetChild(10).gameObject.SetActive(true);
            }
            if (timeNow > timeChange11 && timeChange11 != 0)
            {
                transform.GetChild(11).gameObject.SetActive(true);
            }

            if (timeNow > timeEnd)
            {
                if (timeChange0 != 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                if (timeChange1 != 0)
                {
                    transform.GetChild(1).gameObject.SetActive(false);
                }
                if (timeChange2 != 0)
                {
                    transform.GetChild(2).gameObject.SetActive(false);
                }
                if (timeChange3 != 0)
                {
                    transform.GetChild(3).gameObject.SetActive(false);
                }
                if (timeChange4 != 0)
                {
                    transform.GetChild(4).gameObject.SetActive(false);
                }
                if (timeChange5 != 0)
                {
                    transform.GetChild(5).gameObject.SetActive(false);
                }
                if (timeChange6 != 0)
                {
                    transform.GetChild(6).gameObject.SetActive(false);
                }
                if (timeChange7 != 0)
                {
                    transform.GetChild(7).gameObject.SetActive(false);
                }
                if (timeChange8 != 0)
                {
                    transform.GetChild(8).gameObject.SetActive(false);
                }
                if (timeChange9 != 0)
                {
                    transform.GetChild(9).gameObject.SetActive(false);
                }
                if (timeChange10 != 0)
                {
                    transform.GetChild(10).gameObject.SetActive(false);
                }
                if (timeChange11 != 0)
                {
                    transform.GetChild(11).gameObject.SetActive(false);
                }
                timeNow = 0.0f;
            }

        }
    }

}