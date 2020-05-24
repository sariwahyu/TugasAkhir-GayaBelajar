using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Lean.taouch
{
    public class RotasiSimetriLipat : MonoBehaviour
    {
        [Tooltip("List time change each child")]

        public float timeNow = 0.0f;
        public float timeLimit = 5.0f;
        public float timeLimitStatic = 5.0f;
        public float degreeLimit = 0.0f;
        public float degreeNow = 0.0f;
        public float degreeLimit0 = 0.0f;
        public float degreeLimit1 = 180.0f;
        public float degreeSpeed = -1.0f;

        public Vector3 Axis = Vector3.down;
        public Space Space = Space.Self;


        void Update()
        {
            if (timeLimit > 0)
            {
                timeLimit -= Time.deltaTime;
            }

            else if (degreeNow >= degreeLimit0 && degreeNow < degreeLimit1)
            {

                degreeNow += 1;
                transform.Rotate(Axis, degreeSpeed, Space);

            }
            else if (degreeNow > 360)
            {
                timeLimit = timeLimitStatic;
                transform.Rotate(Axis, degreeLimit1, Space);
                degreeNow = 0;
            }
            else
            {
                degreeNow += 1;
            }
        }
    }
}


