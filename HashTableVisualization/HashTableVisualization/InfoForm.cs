using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTableVisualization;

public partial class InfoForm : Form
{
    public InfoForm()
    {
        InitializeComponent();
        LoadInfoText();
    }
    private void LoadInfoText()
    {
        string infoText = "Алгоритм хэш-таблицы: " + Environment.NewLine +
                          "Хэш-таблица использует хэш-функцию для вычисления индекса элемента в массиве " +
                          "ячеек (bucket), из которых состоит таблица. Хэш считается из значения Key, и вставляет элемент по позиции хэша." + Environment.NewLine +
                          "Принцип работы:" + Environment.NewLine + 
                          "1. Вставка, поиск и удаление элементов имеют в среднем временную сложность O(1), так как производятся" +
                          "при помощи хэш-функции." + Environment.NewLine +
                          "2. Коллизии (одинаковый хэш для двух элементов) решаются методом цепочек с бинарным деревом." +
                          " То есть в каждой ячейке есть бинарное дерево, которое хранит в себе элементы с одинаковым хэшем" + Environment.NewLine +
                          "Описание программы:" + Environment.NewLine +
                          "Программа демонстрирует визуализацию структуры данных хэш-таблицы, " +
                          "позволяя пользователю добавлять, удалять и искать ключи, а также " +
                          "просматривать изменения в реальном времени.";
        txtInfo.AppendText(infoText);
    }
}
