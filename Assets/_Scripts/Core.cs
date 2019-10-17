using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic.Architecture;
using GameLogic.Player;
using GameLogic.Commands;

namespace GameLogic
{
    public class Core : MonoBehaviour
    {

       public CORE CORE;




        // Use this for initialization
        void Start()
        {

            CORE = new CORE();

        }

        // Update is called once per frame
        void Update()
        {
            new NextTurn().Execute(CORE);
        }
    }




    public class CORE : Core
    {

        public readonly Ship Ship = new Ship();
        public readonly Factory Factory = new Factory();
        public readonly Turns Turns = new Turns();
        public readonly Bank Bank = new Bank();

        public CORE()
        {
            Ship.CreateEmptyRooms(Factory);
        }

    }
}
