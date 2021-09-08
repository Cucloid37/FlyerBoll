using MVC.Model;
using UnityEngine;

namespace MVC.View
{
    public interface IViewFlyer
    {
        void Move(IFieldCoordinates point);
    }
}