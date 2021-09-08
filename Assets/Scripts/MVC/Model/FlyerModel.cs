using System;
using UnityEngine;

namespace MVC.Model
{
    internal class FlyerModel : MonoBehaviour, ICharacteristicsFlyers
    {
        #region Property

        public float actionPoints { get; private set; }
        public int force { get; private set; }
        public int agity { get; private set; }
        public int magicForce { get; private set; }
        
        public float factorSpeed { get; private set; }

        public float factorHieght { get; private set; }
        public float factorDiagonale { get; private set; }
        
        private readonly float speedMultiply = 1.1f;
        private readonly float hieghtMultiply = 0.6f;
        private readonly float diagonaleMultiply = 0.8f;

        /*public float  factorSpeed => _factorSpeed;
        public float factorHieght => _factorHieght;
        public float factorDiagonale => _factorDiagonale;*/
        #endregion

        #region Constructors

        public FlyerModel(float actionPoints, int force, int agity, int magicForce)
        {
            this.actionPoints = actionPoints;
            this.force = force;
            this.agity = agity;
            this.magicForce = magicForce;
        }

        #endregion

        #region Void

        private void FactorSpeed()
        {
            factorSpeed = (float) (force + agity) * speedMultiply;
        }

        private void FactorHieght()
        {
            factorHieght = (float) force * hieghtMultiply;
        }

        private void FactorDiagonale()
        {
            
            factorDiagonale = (float) agity * diagonaleMultiply;
        }

        public void SetForce(int Force)
        {
            force = Force;
        }
        
        public void SetAgity(int Agity)
        {
            agity = Agity;
        }

        public void SetMagicForce(int MagicForce)
        {
            magicForce = MagicForce;
        }

        public void SetActionPoints(float ActionPoints)
        {
            actionPoints = ActionPoints;
        }

        #endregion
        
        private void Awake()
        {
            FactorSpeed();
            FactorHieght();
            FactorDiagonale();
        }
        
        public void ChangeActionPoints(float value)
        {
            actionPoints -= value;
        }


    }
}
