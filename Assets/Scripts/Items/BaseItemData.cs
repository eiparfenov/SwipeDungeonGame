using System;
using UnityEngine;

namespace Items
{
    public abstract class BaseItemData: ScriptableObject
    {
        [field: SerializeField] public Guid Id { get; set; }
        [field: SerializeField] public Sprite Sprite { get; private set; }
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
    }
}