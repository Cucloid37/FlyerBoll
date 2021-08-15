using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainSpace
{
    public sealed class Hunter : Functional
    {
        #region Fields

        private int _speed;
        private int _magicForce;

        #endregion

        #region Constructs

        Hunter(int speed, int magicForce)
        { speed = _speed; magicForce = _magicForce; }

        #endregion

        public override void UseMagic(int magicForce, int costAction)
        {
            base.UseMagic(magicForce, costAction);

            _speed += magicForce;

        }
    }
}
