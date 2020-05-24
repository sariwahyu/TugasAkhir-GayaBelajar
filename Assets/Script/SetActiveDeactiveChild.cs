using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Lean.Touch
{
    public class SetActiveDeactiveChild : MonoBehaviour
    {
        [Tooltip("List time change each child!")]
        public float timeNow = 0.0f;
        public float timeChange0 = 0.0f;
        public float timeChange1 = 12.5f;
        public float timeChange2 = 25.0f;
        public float timeChange3 = 37.5f;

        [Tooltip("Duraton time looping for each part")]
        public float timeEnd = 50.0f;

        public Vector3 Axis = Vector3.down;
        public Space Space = Space.Self;
        public float Degrees = -1.0f;

        void Update()
        {
            timeNow += Time.deltaTime;
            transform.Rotate(Axis, Degrees, Space);

            if (timeNow > timeChange0)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
            if (timeNow > timeChange1 && timeChange1 != 0)
            {
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
            }
            if (timeNow > timeChange2 && timeChange2 != 0)
            {
                transform.GetChild(1).gameObject.SetActive(false);
                transform.GetChild(2).gameObject.SetActive(true);
            }
            if (timeNow > timeChange3 && timeChange3 != 0)
            {
                transform.GetChild(2).gameObject.SetActive(false);
                transform.GetChild(3).gameObject.SetActive(true);
            }

            if (timeNow > timeEnd)
            {
                if (timeChange2 == 0 && timeChange3 == 0)
                {
                    transform.GetChild(1).gameObject.SetActive(false);
                }
                else if (timeChange3 == 0)
                {
                    transform.GetChild(2).gameObject.SetActive(false);
                }
                else
                {
                    transform.GetChild(3).gameObject.SetActive(false);
                }

                timeNow = 0.0f;
            }
        }
    }
}

