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

    public StateManager(HashTable<TValue> table, int capacity = 16)
    {
        hashTable = table;
        stateStorage = new StateStorage<TValue>();
        stateStorage.AddState(hashTable);
    }

    public void Insert(string key, TValue value)
    {
        hashTable.Insert(key, value);
        stateStorage.AddState(hashTable);
    }

    public Node<TValue>? Find(string key)
    {
        Node<TValue>? value = hashTable.Find(key);
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

    public void ResetStateManager()
    {
        stateStorage = new StateStorage<TValue>();
    }

    public void LoadStateFromFile(string filePath)
    {
        stateStorage.LoadFromFile(filePath);
    }

    public void SaveStateToFile(string filePath)
    {
        stateStorage.SaveToFile(filePath);
    }
}
