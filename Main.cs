using Life;
using UnityEngine;

namespace MyEvents
{
    public class Main : Plugin
    {
        public Main(IGameAPI api): base(api)
        {
            Debug.Log($"Plugin \"MyEvents\" initialisé avec succès.");
        }
    }
}