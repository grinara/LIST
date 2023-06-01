﻿using System;

namespace Samogina_LAB3
{
    class LAB3
    {
        static void Main()
        {
            int k = 2;
            if (k == 1)
            {
                Console.WriteLine("1)Создайте пустой список S1. Добавьте элемент 1 в голову, добавьте элемент 10 в хвост. Выведите S1 на экран (используя функцию Print)");
                Nodelist S1 = new Nodelist();
                S1.Push_front(1);
                S1.Push_back(10);
                S1.PRINT();
                Console.WriteLine("\n\n2)Создайте список S2 из 6 случайных чисел. Выведите список S2 на экран, используя потоковый вывод. Найдите в S2 max и min элемент. Отсортируйте  S2.");
                Nodelist S2 = new Nodelist(6);
                S2.PRINT();
                Console.Write("max - "); S2.Max().Print();
                Console.Write("min - "); S2.Min().Print();
                S2.Sort();
                S2.PRINT();
                Console.WriteLine("\n\n3)Найдите в S2 2-й элемент и выведите его на экран. Удалите 2-й элемент списка S2. ");
                S2[1].Print();
                S2.earse(1);
                S2.PRINT();
                Console.WriteLine("\n\n4)Найдите в S2 6-й элемент (т.е. убедитесь, что в списке осталось меньше 6 элементов). Удалите элемент из хвоста S2.");
                if (S2[5] == null) { Console.WriteLine("нет 6 элемента"); }
                S2.Pop_back();
                S2.PRINT();
                Console.WriteLine("\n\n5)Создайте пустой список S3. Инициализируйте его значением S1. Проверьте равенство списков S1  и  S3. Проверьте, есть ли в S3 элемент 15.");
                Nodelist S3 = new Nodelist();
                S3 = (Nodelist)S1.Clone();
                if (S3 == S1) { Console.WriteLine("S3==S1"); }
                if (S3.find(15) == null) { Console.WriteLine("нет 15"); }
                Console.WriteLine("\n\n6)Удалите элемент из головы списка S3. Удалите из списка S3 элемент 10. Выведите S3 на экран. Проверьте S3 на пустоту.");
                S3.Pop_front();
                S3.earse_key(10);
                S3.PRINT();
                if (S3.is_empy()) { Console.WriteLine("S3-пуст"); }
                Console.WriteLine("\n\n7)Создайте последовательность из 6 случайных чисел, меньших 20. Превратите ее в список S4 и выведите его на экран. Проверьте, есть ли в S4 элемент 25. Добавьте элемент 25 четвертым в список.");
                Nodelist S4 = new Nodelist(6, 20);
                S4.PRINT();
                if (S4.find(25) == null) { Console.WriteLine("нет 25"); }
                S4.insert(3, 25);
                S4.PRINT();
                Console.WriteLine("\n\n8)Создайте список S5, проинициализировав его при создании списком S2. Выведите S5 на экран. Проверьте, есть ли в S5 элемент 4 и если есть – удалите его, если нет – добавьте элемент 4 в хвост.");
                Nodelist S5 = new Nodelist();
                S5 = (Nodelist)S2.Clone();
                S5.PRINT();
                if (S5.find(4) == null) { S5.Push_back(4); }
                else { S5.earse_key(4); }
                S5.PRINT();
                Console.WriteLine("\n\n9)Измените S5, записав в него 4 числа: 11, 12, 13, 14 (числа вводятся с клавиатуры). Сравните S5 и S4.");
                for(int i=0;i<4;i++) { S5.Input(); }
                S5.PRINT();
                if (S5 == S4) { Console.WriteLine("S5==S4"); }
                else Console.WriteLine("S5!=S4");
                Console.WriteLine("\n\n10) Добавьте в хвост S5 список S4. Добавьте в голову S5 список S1.");
                S5 = S1 + S5 + S4;
                S5.PRINT();
            }
            else
            {
                Console.WriteLine("\n\n\n1)Создайте множество S1, из 10 случайных чисел. Выведите S1 на экран (используя функцию Print).");
                NodeSet S1= new NodeSet(10,20);
                S1.PRINT();
                Console.WriteLine("\n\n2)Создайте множество S2 и инициализируйте его (при создании) значением S1.  Выведите S2 на экран (используйте потоковый вывод). Проверьте равенство множеств S1  и  S2.");
                NodeSet S2 = (NodeSet)S1.Clone();
                S2.PRINT();
                if (S2 == S1) { Console.WriteLine("S2==S1"); }
                Console.WriteLine("\n\n3)Проверьте, есть ли в S1 элемент 5. Создайте множество S3, которое получается  удалением/добавлением из S1 элемента 5. Проверьте, что S1 и S3 – не равны.");
                NodeSet S3;
                if (S1.find(5) == null) { S3 = (NodeSet)S1.Clone(); S3 = S1.Add_new(5); }
                else { S3=(NodeSet)S1.Clone();S3 = S1.Del_new(5); }
                S3.PRINT();
                if (S1!=S3) { Console.WriteLine("S1!=S3"); }
                Console.WriteLine("\n\n4)Создайте пустое множество S4. Проверьте его на пустоту.  Добавьте в S4 последовательно числа 5, 10, 15, 5.  Выведите S4 на экран.");
                NodeSet S4=new NodeSet();
                if (S4.is_empy()) { Console.WriteLine("S4 - empy"); }
                S4.Add(5); S4.Add(10); S4.Add(15); S4.Add(5);
                S4.PRINT();
                Console.WriteLine("\n\n5)Создайте пустое множество S5.  Инициализируйте его множеством S4.  Проверьте, что во множестве S5 есть элемент 15 и удалите его. Выведите получившееся множество на экран.");
                NodeSet S5 = S4;
                if (S5.find(15) != null) { S5.Del(15); }
                S5.PRINT();
                Console.WriteLine("\n\n6)Создайте список T, из 20 случайных чисел. Выведите T на экран. Создайте из T множество S6.  Выведите S6 на экран. Определите количество элементов в S6.");
                Nodelist T=new Nodelist(20,50);
                T.PRINT();
                NodeSet S6=new NodeSet();
                S6.toNodeSet(T);
                S6.PRINT();
                Console.WriteLine(S6.GetSize());
                Console.WriteLine("\n\n7)Найдите S7 – дополнение S6 до универсального. Найдите множество S8=S7∩S6.");//пересечение
                NodeSet S7=S6.complement();
                S7.PRINT();
                NodeSet S8 = S7.intersection_new(S6);
                S8.PRINT();
                Console.WriteLine("\n\n8)Создайте множество S9={1,3,5,7,9,11,13,15,17,19,21,23,25,27,29}.  Найдите V1 =S7 ∩ S9,  V2 = S7 ∪ S9,  V3 = S7 \\ S9.\r\n");
                NodeSet S9 = new NodeSet();
                for(int i=-1; i<29;) { S9.Add(i+2);i += 2; }
                S9.PRINT();
                NodeSet V1=S7.intersection_new(S9);
                NodeSet V2 = S7.unification_new(S9);
                NodeSet V3 = S7.difference_new(S9);
                V1.PRINT();
                V2.PRINT();
                V3.PRINT();
                Console.WriteLine("\n\n9)Измените V1, объединив его с V3. Сравните V1  с S7.");
                V1= (NodeSet)(V1.unification_new(V3)).Clone();
                V1.PRINT();
                if (V1 == S7) { Console.WriteLine("V1==S7"); }
                else { Console.WriteLine("V1!=S7"); }
                Console.WriteLine("\n\n10)Измените множество V2, заменив его разностью V2 и V3. Сравните V2  с  S9");
                V2= (NodeSet)(V2.difference_new(V3)).Clone();
                V2.PRINT();
                if (V1 == S7) { Console.WriteLine("V2==S9"); }
                else { Console.WriteLine("V2!=S9"); }
            }
        }   
    }

    public class NODE
    {
        protected int Data;
        protected NODE? Next;
        protected NODE? Prev;
        public NODE(int data, NODE? next, NODE? prev) { Data = data; Next = next; Prev = prev; }
        public NODE() { Data = default(int); Next = null; Prev = null; }
        public NODE(int data) { Data = data; Prev = null; Next = null; }
        public void Print() { Console.WriteLine(this.Data); }
        public int GetData() { return Data; }
        public NODE? GetNext() { return Next; }
        public NODE? GetPrev() { return Prev; }
        public void InerData(int a)
        {
            Data = a;
        }
        public void InerPrev(NODE? A)
        {
            Prev = A;
        }
        public void InerNext(NODE? A)
        {
            Next = A;
        }
    }
    class Nodelist
    {
        protected int n;
        protected NODE? Head;
        protected NODE? Tail;
        public Nodelist() { n = 0; Head = null;Tail = null; }
        public Nodelist(int size,int rang=1000) {
            Random rnd = new Random();
            for(int i=0;i<size; i++)
            {
                Push_back(rnd.Next()%rang);
            }
        }
        public Nodelist(Nodelist A)
        {
            Head = new NODE(A.Head.GetData());
            NODE? current = A.Head.GetNext();

            while (current != null)
            {
                Push_back(current.GetData());
                current = current.GetNext();
            }
        }
        public object Clone() {
            Nodelist ptr = new Nodelist();
            NODE? pt = Head;
            while(pt!=null) {
                ptr.Push_back(pt.GetData());
                pt = pt.GetNext();
            }
            return ptr;
        }
        public int GetSize()
        {
            return n;
        }
        public NODE Push_front(int data) // добавление в начало
        {
            NODE ptr = new NODE(data);
            ptr.InerNext(Head);
            if (Head != null) { Head.InerPrev(ptr); }
            if (Tail == null) { Tail = ptr; }
            Head = ptr;
            n++;
            return ptr;
        }
        public NODE Push_back(int data) //добавление в конец
        {
            NODE ptr = new NODE(data);
            ptr.InerPrev(Tail);
            if (Tail != null) { Tail.InerNext(ptr); }
            if (Head == null) { Head = ptr; }
            Tail = ptr;
            n++;
            return ptr;
        }
        public void Pop_front()
        { //удаление с головы
            if (Head == null) return;
            NODE? ptr = Head.GetNext();
            if (ptr != null) { ptr.InerPrev(null); }
            else Tail = ptr;
            n--;
            Head = ptr;
        }
        public void Pop_back() //удаление с конца
        {
            if (Tail == null) return;
            NODE? ptr = Tail.GetPrev();
            if (ptr != null) { ptr.InerNext(null); }
            else Head = ptr;
            n--;
            Tail = ptr;
        }
        public NODE getAt(int index) //поиск по позиции
        {
            NODE? ptr = Head;
            int n = 0;
            while (n != index)
            {
                if (ptr == null) return ptr;
                ptr = ptr.GetNext();
                n++;
            }
            return ptr;
        }
        public NODE insert(int index, int data)//добавить на позицию
        {
            NODE right = getAt(index);
            if (right == null) return Push_back(data);

            NODE? left = right.GetPrev();
            if (left == null) return Push_front(data);

            NODE ptr = new NODE(data);
            ptr.InerPrev(left);
            ptr.InerNext(right);
            left.InerNext(ptr);
            right.InerPrev(ptr);
            n++;
            return ptr;
        }
        public void earse(int index) // удаление по позиции
        {
            NODE ptr = getAt(index);
            if (ptr == null) return;
            if (ptr.GetPrev() == null) { Pop_front(); return; }
            if (ptr.GetNext() == null) { Pop_back(); return; }
            NODE left = ptr.GetPrev();
            NODE righ = ptr.GetNext();
            left.InerNext(righ);
            righ.InerPrev(left);
           // n--;
        }
        public NODE find(int data)// найти по ключу
        {
            NODE? ptr = Head;
            if (ptr == null) return ptr;
            while (ptr.GetData() != data)
            {
                ptr = ptr.GetNext();
                if (ptr == null) { return ptr; }
            }
            return ptr;
        }
        public NODE insert_key(int key, int data) //добавление после ключа
        {   
            NODE? right = find(key);
            right = right.GetNext();
            if (right == null) return Push_back(data);

            NODE? left = right.GetPrev();
            if (left == null) return Push_front(data);
            NODE ptr = new NODE(data);
            ptr.InerPrev(left);
            ptr.InerNext(right);
            left.InerNext(ptr);
            right.InerPrev(ptr);
            n++;
            return ptr;
        }
        public void earse_key(int data) // удаление по ключу
        {
            NODE ptr = find(data);
            if (ptr == null) return;
            if (ptr.GetPrev() == null) { Pop_front(); return; }
            if (ptr.GetNext() == null) { Pop_back(); return; }
            NODE left = ptr.GetPrev();
            NODE righ = ptr.GetNext();
            left.InerNext(righ);
            righ.InerPrev(left);
            n--;
        }
        public NODE Max() //максимум
        {
            NODE? ptr = Head;
            NODE? data = ptr;
            while (ptr != null)
            {
                if (System.Convert.ToChar(data.GetData()) < System.Convert.ToChar(ptr.GetData())) { data = ptr; }
                ptr = ptr.GetNext();
            }
            return data;
        }
        public NODE Min()
        {
            NODE? ptr = Head;
            NODE? data = ptr;
            while (ptr != null)
            {
                if (System.Convert.ToInt32(data.GetData()) > System.Convert.ToInt32(ptr.GetData())) { data = ptr; }
                ptr = ptr.GetNext();
            }
            return data;
        }//минимум
        public bool is_empy() { if (Head == null) return true; return false; } //проверка на пустоту
        public void clear() { while (Head != null) { Pop_back(); } }//очистка
        public static Nodelist operator +(Nodelist l1, Nodelist l2)
        {
            Nodelist list = new Nodelist();
            NODE? ptr1 = l1.Head;
            NODE? ptr2 = l2.Head;
            while (ptr1 != null) { list.Push_back(ptr1.GetData()); ptr1 = ptr1.GetNext(); }
            while (ptr2 != null) { list.Push_back(ptr2.GetData()); ptr2 = ptr2.GetNext(); }
            return list;
        } //перегрузка +
        public static bool operator == (Nodelist l1, Nodelist l2)
        {
            if (l1.n != l2.n) return false;
            if (l1.Head ==null || l2.Head == null) return false;
            NODE? current_A = l1.Head;
            NODE? current_B = l2.Head;

            for (int i = 0; i < l1.n; i++)
            {
                if (current_A.GetData() != current_B.GetData()) return false;
                current_B = current_B.GetNext();
                current_A = current_A.GetNext();
            }
            return true;
        } //перегрузка ==
        public static bool operator !=(Nodelist l1, Nodelist l2)
        {
            return !(l1 == l2);
        } //перегрузка !=
        public void PRINT()
        {
            NODE? ptr = Head;
            while (ptr != null) { Console.Write(ptr.GetData()); Console.Write(" "); ptr = ptr.GetNext(); }
            Console.WriteLine();
        }
        public void Input()
        {
            var a = int.Parse(Console.ReadLine());
            Push_back(a);
        }
        public NODE this[int index]
        {
            get
            {
                return getAt(index);
            }
        } //перегрузка []
        public void Sort()
        {
            if (this.Head != null)
            {
                int j = 0;
                int tmp = 0;
                for (int i = 0; i < n; i++)
                {
                    j = i;
                    for (int k = i; k < n; k++)
                    {
                        if (this[j].GetData() > this[k].GetData())
                        {
                            j = k;
                        }
                    }
                    tmp = this[i].GetData();
                    this[i].InerData(this[j].GetData());
                    this[j].InerData(tmp);
                }
            }
        }  //сортировка
    }
    class NodeSet : Nodelist {
       // protected Nodelist Nodelist;
        new public int GetSize()
        {
            return n;
        }
        public NodeSet() { n = 0; }
        public NodeSet(int size,int rang)
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                Add(rnd.Next() % rang);
            }
            Sort();
        }
        public void toNodeSet(Nodelist ptr)
        {
            for (int i = 0; i < ptr.GetSize(); i++)
            {
                Add(ptr[i].GetData());
            }
            Sort();
        }
        new public void Input()
        {
            var a = int.Parse(Console.ReadLine());
            Add(a);
            Sort();
        }
        new public object Clone()
        {
            NodeSet ptr = new NodeSet();
            NODE? pt = Head;
            while (pt != null)
            {
                ptr.Add(pt.GetData());
                pt = pt.GetNext();
            }
            ptr.Sort();
            return ptr;
        }
        public void unification(NodeSet other)
        {
            NODE? ptr = other.Head;
            while (ptr != null)
            {
                Add(ptr.GetData());
                ptr = ptr.GetNext();
            }
            Sort();
        } //	объединение двух множеств
        public NodeSet unification_new(NodeSet other)
        {
            NODE? ptr = Head;
            NODE? ptr2 = other.Head;
            NodeSet nodeSet= new NodeSet();
            while (ptr != null)
            {
                nodeSet.Add(ptr.GetData());
                ptr = ptr.GetNext();
            }
            while (ptr2 != null)
            {
                nodeSet.Add(ptr2.GetData());
                ptr2 = ptr2.GetNext();
            }
            nodeSet.Sort();
            return nodeSet;
        }
        public void Add(int data)
        {
            if (find(data) == null)
            {
                Push_back(data);
            }
            Sort();
        }//	добавление элемента к множеству 
        public NodeSet Add_new(int data)
        {
            NodeSet ptr = (NodeSet)this.Clone();
            if (find(data) == null)
            {
                ptr.Push_back(data);
            }
            ptr.Sort();
            return ptr;
        }
        public void Del(int data)
        {
            earse_key(data);
            Sort();
        }// 	удаление элемента 
        public NodeSet Del_new(int data)
        {
            NodeSet ptr = (NodeSet)this.Clone();
            ptr.Del(data);
            ptr.Sort();
            return ptr;
        }
        public NodeSet intersection_new(NodeSet other)
        {
            NODE? ptr= new NODE();
            NodeSet ptr2 = new NodeSet();
            ptr = Head;
            while(ptr != null ) {
                if (find(ptr.GetData()) != null && other.find(ptr.GetData())!=null) { 
                    ptr2.Add(ptr.GetData());
                    
                    if(ptr==null) { return ptr2; }
                }
                ptr = ptr.GetNext();
            }
            ptr2.Sort();
            return ptr2;
        } //	пересечение двух множеств 
        public void intersection(NodeSet other)
        {
            NODE? ptr = new NODE();
            ptr = Head;
            while(ptr != null ) {
                if(other.find(ptr.GetData())==null) { Del(ptr.GetData()); }
                ptr = ptr.GetNext();
            }
            Sort();
        }

        public void difference(NodeSet other)
        {
            NodeSet ptr=this.intersection_new(other);
            NODE? ptr2 = ptr.Head;
            while (ptr2!=null)
            {
                Del(ptr2.GetData());
                ptr2 = ptr2.GetNext();
            }
            Sort(); 

        } //	разность двух множеств 
        public NodeSet difference_new(NodeSet other)
        {
            NodeSet? ptr = this.intersection_new(other);
            NodeSet? nodeSet = this;
            NODE? ptr2 = ptr.Head;
            while (ptr2 != null)
            {
                nodeSet.Del(ptr2.GetData());
                ptr2 = ptr2.GetNext();
            }
            nodeSet.Sort();
            return nodeSet;
        }
        public NodeSet complement()
        {
            NodeSet ptr = new NodeSet();
            int max = Max().GetData();
            int min = Min().GetData();
            for (int i = min; i <= max; i++)
            {
                if (find(i) == null) { ptr.Add(i); }
                
            }
            ptr.Sort(); 
            return ptr;
        } //дополнение до идеального множества
    }
}