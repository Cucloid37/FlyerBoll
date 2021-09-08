using System.Collections.Generic;
using MVC.Model;
using UnityEngine;
using UnityEngine.EventSystems;
using Bug = UnityEngine.Debug;

namespace MVC.Controller
{
    public static class Instruments
    {
       // static Dictionary<int, float> _dictionaryFactor { get; }
        
        
        
        public static GameObject RayCastReturn()
        {
            if (!(Camera.main is null) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo, 100))
            {
                Bug.Log($"RayCast return: {hitInfo.collider.gameObject}");
                if (EventSystem.current.IsPointerOverGameObject())
                    return null;
                else 
                    return hitInfo.collider.gameObject;
            }
            else return null;
        }
        
        
        public static float CalculateDistance(Coordinates myField, Coordinates rayCastField, ICharacteristicsFlyers  selectedObject)
        {
            float x; 
            float y; 
            float z;

            Coordinates result = myField - rayCastField;

            if (result.X <= result.Z && result.X != 0)
            {
                z = result.Z - result.X;
                x = result.X * selectedObject.factorDiagonale;
            }
            else if (result.Z <= result.X && result.Z != 0)
            {
                x = result.X - result.Y;
                z = result.Z * selectedObject.factorDiagonale;
            }
            else
            {
                x = result.X * selectedObject.factorSpeed; 
                z = result.Z * selectedObject.factorSpeed;   
            }

            if (result.Y > 0)
            {
                y = result.Y * selectedObject.factorHieght;
            }
            else y = result.Y;
            
            return x + y + z;
        }


        public static float CountingFactor(ICharacteristicsFlyers flyer)
        {
            
            return 0;
        }
    }
}