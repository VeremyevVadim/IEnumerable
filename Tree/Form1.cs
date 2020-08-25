using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;

namespace Tree
{
    public partial class MainForm : Form
    {
        public static MainForm TreeForm;
        BinaryTree Tree;

        public MainForm()
        {
            TreeForm = this;
            Tree = new BinaryTree();
            Tree.Root = Tree;
            InitializeComponent();

        }

        // Вывод дерева
        private void Output_Btn_Click(object sender, EventArgs e)
        {
            Log_TxBx.AppendText("Прямой обход:\r\n");
            foreach (var node in Tree)
            {
                Log_TxBx.AppendText($"{node.ToString()} ");
            }
            Log_TxBx.AppendText("\r\n");
        }

        // Действия с узлами
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            int value;

            try
            {
                value = int.Parse(edit_add.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число.");
                return;
            }

            if(Tree.Insert(value) == true)
                Log_TxBx.AppendText($"Значение {value} добавлено.\r\n");
            else
                Log_TxBx.AppendText($"Значение {value} уже существует.\r\n");
            edit_add.Text = "";
        }

        private void Srch_Btn_Click(object sender, EventArgs e)
        {
            int value;
            string mes;

            try
            {
                value = int.Parse(edit_search.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число.");
                return;
            }

            var node = Tree.Find(value);

            mes = node == null ? $"Узел со значением {value} не найден." : $"Узел со значением {value} найден.";
            Log_TxBx.AppendText($"{mes}\r\n");
            edit_search.Text = "";
        }

        // Вывод в окно
        public static void WriteInLog(string text)
        {
            TreeForm.Log_TxBx.AppendText($"{text}\r\n");
        }
    }


    // Бинарное дерево поиска
    public class BinaryTree : IEnumerable
    {
        public int? Data { get; private set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }
        public BinaryTree Root = null;


        // Вставка значения в дерево.
        public bool Insert(int data)
        {
            bool result = false;

            if (Data == null)
            {
                Data = data;
                return true;
            }

            if (Data > data)
            {
                if (Left == null) Left = new BinaryTree();
                result = Insert(data, Left);
            }
            else if(Data < data)
            {
                if (Right == null) Right = new BinaryTree();
                result = Insert(data, Right);
            }

            return result;
        }

        // Вставка значения в определённый узел дерева
        private bool Insert(int data, BinaryTree node)
        {
            bool result = false;

            if (node.Data == null)
            {
                node.Data = data;
                return true;
            }
            if (node.Data > data)
            {
                if (node.Left == null) node.Left = new BinaryTree();
                result = Insert(data, node.Left);
            }
            else if(node.Data < data)
            {
                if (node.Right == null) node.Right = new BinaryTree();
                result = Insert(data, node.Right);
            }

            return result;
        }

        // Поиск узла с определенным значением
        public BinaryTree Find(int data)
        {
            if (Data == data) return this;
            if (Data > data)
            {
                return Find(data, Left);
            }
            return Find(data, Right);
        }

        // Поиск значения в определенном узле
        public BinaryTree Find(int data, BinaryTree node)
        {
            if (node == null) return null;

            if (node.Data == data) return node;
            if (node.Data > data)
            {
                return Find(data, node.Left);
            }
            return Find(data, node.Right);
        }

        // Прямой обход дерева с определенного узла.
        public IEnumerable WalkTree(BinaryTree node)
        {
            if (node != null)
            {
                if (node.Left != null)
                    foreach (var elem in WalkTree(node.Left))
                    {
                        yield return elem;
                    }

                yield return node.Data;

                if (node.Right != null)
                    foreach (var elem in WalkTree(node.Right))
                    {
                        yield return elem;
                    }
            }

            yield break;
        }

        public IEnumerator GetEnumerator()
        {
            return WalkTree(Root).GetEnumerator();
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}