using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableVisualization;

internal class StateManager<TValue>
{
    private HashTable<TValue> hashTable;
    private StateStorage<TValue> stateStorage;
    private string? LastHighlighted;

    public StateManager(HashTable<TValue> table, int capacity = 16)
    {
        hashTable = table;
        stateStorage = new StateStorage<TValue>();
        stateStorage.AddState(hashTable);
        LastHighlighted = null;
    }
    public void UpdateHashTable()
    {
        hashTable = new HashTable<TValue>(stateStorage.GetCurrentState());
        LastHighlighted = null;
    }
    private void Highlight(string key)
    {
        if (LastHighlighted != null)
            hashTable.Find(LastHighlighted).IsHighlighted = false;
        hashTable.Find(key).IsHighlighted = true;
        LastHighlighted = key;
    }
    public void Insert(string key, TValue value)
    {
        hashTable.Insert(key, value);
        Highlight(key);
        stateStorage.AddState(hashTable);
    }

    public Node<TValue>? Find(string key)
    {
        Node<TValue>? value = hashTable.Find(key);
        if (value != null) {
            Highlight(key);
            stateStorage.AddState(hashTable);
        }
        return value;
    }
    public bool Remove(string key)
    {
        bool result = hashTable.Remove(key);
        stateStorage.AddState(hashTable);
        return result;
    }

    public StateStorage<TValue> GetStateStorage()
    {
        return stateStorage;
    }

    public void LoadStatesFromFile(string filePath)
    {
        stateStorage.LoadFromFile(filePath);
    }

    public void SaveStatesToFile(string filePath)
    {
        stateStorage.SaveToFile(filePath);
    }
}
