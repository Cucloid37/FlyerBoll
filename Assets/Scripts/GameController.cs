using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MainSpace
{
    public delegate void HunterVoid();

    public sealed class GameController : Functional
    {
        private ArrayList FirstTeam;
        private ArrayList SecondTeam;
        private List<GameObject> Bludger;  // пробую здесь два способа, потому что не понимаю, каким предпочтительней пользоваться

        private GameObject selectedObject;

        private HunterVoid hunterVoid;
        private Selection selection;

        private int _capacityListOfTeam = 7;
        private int _capacityListOfBlugher = 2;

        private void Awake()
        {

            #region Инициализация коллекций
            FirstTeam = new ArrayList(_capacityListOfTeam);
            SecondTeam = new ArrayList(_capacityListOfTeam);
            Bludger = new List<GameObject>(_capacityListOfBlugher);  

            Functional[] functionals = FindObjectsOfType<Functional>();
            for(int i = 0; i < functionals.Length; i++)
            {
                if (functionals[i].MyTeam == EnumTeam.First)
                {
                    FirstTeam.Add(functionals[i]);
                }
                if (functionals[i].MyTeam == EnumTeam.Second)
                {
                    SecondTeam.Add(functionals[i]);
                }
                if (functionals[i].MyTeam == EnumTeam.Bludger)
                {
                    Bludger.Add(functionals[i].GetComponent<GameObject>());
                }
            }
            #endregion
        }

        private void Update()
        {


            if (Input.GetKeyDown(KeyCode.E))
            {
                // выбор доступной цели для заклинания


            }
        }

        public static GameObject RayCastReturn()
        {

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo, 100))
            {
                if (EventSystem.current.IsPointerOverGameObject())
                    return null;
                else return hitInfo.collider.gameObject;
            }
            else return null;
        }
    }
}
