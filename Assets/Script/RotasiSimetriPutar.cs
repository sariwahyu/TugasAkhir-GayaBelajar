using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Lean.Touch
{
    public class RotasiSimetriPutar : MonoBehaviour
    {
        public Transform Putaran0;
        public Transform Putaran1;
        public Transform Putaran2;
        public Transform Putaran3;

        [Tooltip("List time change each child")]

        public float timeNow = 0.0f;
        public float timeLimit = 5.0f;
        public float timeLimitStatic = 5.0f;
        public float DegreeNow = 0.0f;
        public float DegreeLimit0 = 0.0f;
        public float DegreeLimit1 = 90.0f;
        public float DegreeLimit2 = 180.0f;
        public float DegreeLimit3 = 270.0f;
        public float DegreeLimit4 = 360.0f;
        public float DegreeSpeed = -1.0f;

        public Vector3 Axis = Vector3.forward;
        public Space Space = Space.Self;

        void Update()
        {
            if (timeLimit > 0)
            {
                timeLimit -= Time.deltaTime;
            }

            else if (DegreeNow >= DegreeLimit0 && DegreeNow < DegreeLimit1)
            {

                DegreeNow += 1;
                transform.Rotate(Axis, DegreeSpeed, Space);

            }
            else if (DegreeNow >= DegreeLimit1 && DegreeNow < DegreeLimit2)
            {
                DegreeNow += 1;
                transform.Rotate(Axis, DegreeSpeed, Space);

            }
            else if (DegreeNow >= DegreeLimit2 && DegreeNow < DegreeLimit3)
            {
                DegreeNow += 1;
                transform.Rotate(Axis, DegreeSpeed, Space);

            }
            else if (DegreeNow >= DegreeLimit3 && DegreeNow < DegreeLimit4 && DegreeLimit4 != 0)
            {
                DegreeNow += 1;
                transform.Rotate(Axis, DegreeSpeed, Space);
            }

            if (DegreeNow == DegreeLimit1)
            {
                Putaran0.gameObject.SetActive(true);
                Putaran1.gameObject.SetActive(false);
                Putaran2.gameObject.SetActive(false);
                Putaran3.gameObject.SetActive(false);
                timeLimit = timeLimitStatic;
                DegreeNow += 1;

            }
            if (DegreeNow == DegreeLimit2)
            {
                Putaran1.gameObject.SetActive(true);
                Putaran0.gameObject.SetActive(false);
                Putaran2.gameObject.SetActive(false);
                Putaran3.gameObject.SetActive(false);
                timeLimit = timeLimitStatic;
                DegreeNow += 1;
                transform.Rotate(Axis, DegreeSpeed, Space);
            }
            if (DegreeNow == DegreeLimit3)
            {
                Putaran2.gameObject.SetActive(true);
                Putaran0.gameObject.SetActive(false);
                Putaran1.gameObject.SetActive(false);
                Putaran3.gameObject.SetActive(false);
                timeLimit = timeLimitStatic;
                DegreeNow += 1;
                transform.Rotate(Axis, DegreeSpeed, Space);
            }
            if (DegreeNow == DegreeLimit4 && DegreeLimit4 != 0)
            {
                Putaran3.gameObject.SetActive(true);
                Putaran0.gameObject.SetActive(false);
                Putaran1.gameObject.SetActive(false);
                Putaran2.gameObject.SetActive(false);
                timeLimit = timeLimitStatic;
                DegreeNow += 1;
                transform.Rotate(Axis, DegreeSpeed, Space);
            }

            if (DegreeNow > 360)
            {
                DegreeNow += 1;
            }
            if (DegreeNow > 720)
            {
                Putaran0.gameObject.SetActive(false);
                Putaran1.gameObject.SetActive(false);
                Putaran2.gameObject.SetActive(false);
                if (DegreeLimit4 != 0)
                {
                    Putaran3.gameObject.SetActive(false);
                }

                DegreeNow = 0;
            }
        }
    }
}

