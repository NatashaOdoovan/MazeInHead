using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Configs
{
    [CreateAssetMenu(menuName = "Create Quest", fileName = "Quest", order = 0)]
    public class GameQuests : ScriptableObject
    {
        
            [SerializeField]
            private string _name;
            [SerializeField, Multiline(5)]
            private string _description;
            [SerializeField]
            private List <string> _answers = new List<string>();

            public string Name => _name;
            public string Description => _description;
            public List <string> answers => _answers;
        
    }
}