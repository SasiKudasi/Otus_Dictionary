using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Dictionary
{
    public class OtusDictionary
    {
        private string _value;
        private string[] _storage;
        private int _size = 32;
        public void Add(int key, string value)
        {
            if (_storage == null)
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Значение не может быть пустым");
                }
                else
                {
                    _storage = new string[_size];
                    key = GetHash(key);
                    _storage[key] = value;
                }

            }
            else if (GetDictionaryCount() == _size)
            {
                throw new ArgumentException("Словарь полность заполнен");
            }
            else
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Значение не может быть пустым");

                }
                else
                {
                    key = GetHash(key);
                    _storage[key] = value;
                }
            }
        }
        int GetDictionaryCount()
        {
            int count = 0;
            for (int i = 0; i < _storage.Length; i++)
            {
                if (_storage[i] != null)
                    count++;
            }
            return count;
        }
        public string GetValue(int key)
        {

            if (_storage[GetHash(key)] == null)
            {
                throw new ArgumentException($"Значений по адресу {key} не найдено");
            }
            return _storage[GetHash(key)];
        }
        int GetHash(int key)
        {
            int hash = key % _storage.Length;
            return hash;
        }
    }
}
