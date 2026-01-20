using Enums;
using UnityEngine;

namespace Core
{
    public abstract class BoardItem : MonoBehaviour
    {
        [SerializeField] public ItemType Type;
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public void Initialize(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}