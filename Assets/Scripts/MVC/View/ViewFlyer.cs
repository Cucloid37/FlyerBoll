using System;
using MVC.Model;
using UnityEngine;

namespace MVC.View
{
    public class ViewFlyer : MonoBehaviour, IViewFlyer
    {
        
        public void Move(IFieldCoordinates point)
        {
            gameObject.transform.position = point.myPosition;
        }
    }
}