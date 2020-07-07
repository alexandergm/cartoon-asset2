using System;
using UnityEngine;

namespace DefaultNamespace
{
    
    public class HandController : MonoBehaviour
    {
        [SerializeField] private StarsController _starsController;
        [SerializeField] private Animals _animals;
        [SerializeField] private ChangeColorCar[] _cars;
        [SerializeField] private CarMove _carMove;

        public void StarDelete()
        {
            _starsController.ChangeFillAmount(0);
        }

        public void StartPig()
        {
            _animals.Pig.SetTrigger("Start");
        }
        
        public void StartBird()
        {
            _animals.Bird.SetTrigger("Start");
        }
        
        public void StartCat()
        {
            _animals.Cat.SetTrigger("Start");
        }

        public void ChangeColorOk(int car)
        {
            _cars[car].Ok();
        }
        
        public void ChangeColorFail(int car)
        {
            _cars[car].Fail();
        }

        public void Finish()
        {
            _starsController.Stop();
            _carMove.Finish();
        }
    }
}