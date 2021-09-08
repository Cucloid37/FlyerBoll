using System;
using Marker;
using MVC.Model;
using MVC.View;
using UnityEngine;

namespace MVC.Controller
{
    internal sealed class MoveController : MonoBehaviour, IMoveContrloller
    {
        private readonly ICharacteristicsFlyers _flyerModel;
        private readonly IViewFlyer _viewFlyer;
        IFieldCoordinates _myField;

        public MoveController(ICharacteristicsFlyers flyerModel, IViewFlyer viewFlyer)
        {
            _flyerModel = flyerModel;
            _viewFlyer = viewFlyer;
        }

        public void Move()
        {
            IFieldCoordinates point = Instruments.RayCastReturn().GetComponent<IFieldCoordinates>();
            float AP = _flyerModel.actionPoints;
            float distance = Instruments.CalculateDistance(_myField.myCoordinates, point.myCoordinates, _flyerModel);
            if (AP - distance > 0)
            {
                _viewFlyer.Move(point);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<MarkerField>())
            {
                _myField = other.GetComponent<IFieldCoordinates>();
            }
            
        }
    }
}
