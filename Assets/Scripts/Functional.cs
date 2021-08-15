using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainSpace
{
    public delegate void Selection();

    public abstract class Functional : MonoBehaviour
    {
        private EnumTeam _myTeam;
        public EnumTeam MyTeam => _myTeam;

        private float _actionPoints;
        public float ActionPoints => _actionPoints;

        public void Select()
        {
            // Выделить предмет и сделать его активным
        }

        public virtual void UseBall()
        {

        }

        public virtual void UseMagic(int magicForce, int costAction)
        {
            // базовая реализация
            CountAP(costAction);
        }

        public virtual void CountAP(int costAction)
        {
            // подсчёт очков
            _actionPoints -= costAction;
        }

    }
}
