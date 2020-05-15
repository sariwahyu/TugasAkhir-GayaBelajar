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
        public float timeChangeSisi0 = 2.0f;
        public float timeChangeSisi1 = 0.0f;
        public float timeChangeSisi2 = 0.0f;
        public float timeChangeSisi3 = 0.0f;
        //public float timeChangeSisi4 = 0.0f;
        //public float timeChangeSisi5 = 0.0f;
        //public float timeChangeSisi6 = 0.0f;

        public float timeChangeSudut0 = 0.0f;
        public float timeChangeSudut1 = 0.0f;
        public float timeChangeSudut2 = 0.0f;
        public float timeChangeSudut3 = 0.0f;
        //public float timeChangeSudut4 = 0.0f;
        //public float timeChangeSudut5 = 0.0f;
        //public float timeChangeSudut6 = 0.0f;
        //public float timeChangeSudut7 = 0.0f;

        //public float timeChangeRusuk0 = 0.0f;
        //public float timeChangeRusuk1 = 0.0f;
        //public float timeChangeRusuk2 = 0.0f;
        //public float timeChangeRusuk3 = 0.0f;
        //public float timeChangeRusuk4 = 0.0f;
        //public float timeChangeRusuk5 = 0.0f;
        //public float timeChangeRusuk6 = 0.0f;
        //public float timeChangeRusuk7 = 0.0f;
        //public float timeChangeRusuk8 = 0.0f;
        //public float timeChangeRusuk9 = 0.0f;
        //public float timeChangeRusuk10 = 0.0f;
        //public float timeChangeRusuk11 = 0.0f;

        [Tooltip("Duration time looping for each part?")]
        public float timeEndSisi = 10.0f;
        public float timeEndSudut = 20.0f;
        //public float timeEndRusuk = 30.0f;

        public Vector3 Axis = Vector3.down;
        public Space Space = Space.Self;
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
            //if (timeNow > timeChangeSisi4 && timeChangeSisi4 != 0)
            //{
            //    transform.GetChild(4).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeSisi5 && timeChangeSisi5 != 0)
            //{
            //    transform.GetChild(5).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeSisi6 && timeChangeSisi6 != 0)
            //{
            //    transform.GetChild(6).gameObject.SetActive(true);
            //}


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
                //if (timeChangeSisi4 != 0)
                //{
                //    transform.GetChild(4).gameObject.SetActive(false);
                //}
                //if (timeChangeSisi5 != 0)
                //{
                //    transform.GetChild(5).gameObject.SetActive(false);
                //}
                //if (timeChangeSisi6 != 0)
                //{
                //    transform.GetChild(6).gameObject.SetActive(false);
                //}
                if (timeEndSudut == 0)
                {
                    timeNow = 0.0f;
                }
            }

            //Sudut
            if (timeNow > timeChangeSudut0 && timeChangeSudut0 != 0)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
            if (timeNow > timeChangeSudut1 && timeChangeSudut1 != 0)
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
            if (timeNow > timeChangeSudut2 && timeChangeSudut2 != 0)
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }
            if (timeNow > timeChangeSudut3 && timeChangeSudut3 != 0)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
            //if (timeNow > timeChangeSudut4 && timeChangeSudut4 != 0)
            //{
            //    transform.GetChild(4).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeSudut5 && timeChangeSudut5 != 0)
            //{
            //    transform.GetChild(5).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeSudut6 && timeChangeSudut6 != 0)
            //{
            //    transform.GetChild(6).gameObject.SetActive(true);
            //}


            if (timeNow > timeEndSudut)
            {
                if (timeChangeSudut0 != 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                if (timeChangeSudut1 != 0)
                {
                    transform.GetChild(1).gameObject.SetActive(false);
                }
                if (timeChangeSudut2 != 0)
                {
                    transform.GetChild(2).gameObject.SetActive(false);
                }
                if (timeChangeSudut3 != 0)
                {
                    transform.GetChild(3).gameObject.SetActive(false);
                }
                //if (timeChangeSudut4 != 0)
                //{
                //    transform.GetChild(4).gameObject.SetActive(false);
                //}
                //if (timeChangeSudut5 != 0)
                //{
                //    transform.GetChild(5).gameObject.SetActive(false);
                //}
                //if (timeChangeSudut6 != 0)
                //{
                //    transform.GetChild(6).gameObject.SetActive(false);
                //}
                //if (timeEndRusuk == 0) 
                //{ 
                //timeNow = 0.0f;
                //}
                timeNow = 0.0f;
            }

            //Rusuk
            //if (timeNow > timeChangeRusuk0 && timeChangeRusuk0 != 0)
            //{
            //    transform.GetChild(0).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeRusuk1 && timeChangeRusuk1 != 0)
            //{
            //    transform.GetChild(1).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeRusuk2 && timeChangeRusuk2 != 0)
            //{
            //    transform.GetChild(2).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeRusuk3 && timeChangeRusuk3 != 0)
            //{
            //    transform.GetChild(3).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeRusuk4 && timeChangeRusuk4 != 0)
            //{
            //    transform.GetChild(4).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeRusuk5 && timeChangeRusuk5 != 0)
            //{
            //    transform.GetChild(5).gameObject.SetActive(true);
            //}
            //if (timeNow > timeChangeRusuk6 && timeChangeRusuk6 != 0)
            //{
            //    transform.GetChild(6).gameObject.SetActive(true);
            //}


            //if (timeNow > timeEndRusuk)
            //{
            //    if (timeChangeRusuk0 != 0)
            //    {
            //        transform.GetChild(0).gameObject.SetActive(false);
            //    }
            //    if (timeChangeRusuk1 != 0)
            //    {
            //        transform.GetChild(1).gameObject.SetActive(false);
            //    }
            //    if (timeChangeRusuk2 != 0)
            //    {
            //        transform.GetChild(2).gameObject.SetActive(false);
            //    }
            //    if (timeChangeRusuk3 != 0)
            //    {
            //        transform.GetChild(3).gameObject.SetActive(false);
            //    }
            //    if (timeChangeRusuk4 != 0)
            //    {
            //        transform.GetChild(4).gameObject.SetActive(false);
            //    }
            //    if (timeChangeRusuk5 != 0)
            //    {
            //        transform.GetChild(5).gameObject.SetActive(false);
            //    }
            //    if (timeChangeRusuk6 != 0)
            //    {
            //        transform.GetChild(6).gameObject.SetActive(false);
            //    }
            //    timeNow = 0.0f;
            //}
        }
    }

}