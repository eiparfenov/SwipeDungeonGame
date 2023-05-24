using System;
using UnityEngine;

namespace Player
{
    [Serializable]
    public class StartPlayerStats
    {
        [field: SerializeField] public float Health { get; private set; }
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public float AttackRate { get; private set; }
        [field: SerializeField] public float Damage { get; private set; }
        [field: SerializeField] public float KnockBack { get; private set; }
    }
}