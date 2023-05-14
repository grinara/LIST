using System;
using System.Drawing;
using System.Reflection;
using System.Security.Claims;

namespace Samogina_LAB3
{
    class LAB3
    {
        static void Main()
        {
            NodeSet l1 = new NodeSet();
            NodeSet l2 = new NodeSet();
            Random rnd = new Random();
            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l2.Add(5);
            l2.Add(1);
            l2.Add(3);
            l2.Add(8);
            NodeSet l3=l1.unification_new(l2);    
            l3.PRINT(); 
        }
    }

    class NODE
    {
        public int Data;
        public NODE? Next;
        public NODE? Prev;
        public NODE(int data, NODE? next, NODE? prev) { Data = data; Next = next; Prev = prev; }
        public NODE() { Data = default(int); Next = null; Prev = null; }
        public NODE(int data) { Data = data; Prev = null; Next = null; }
        public void Print() { Console.WriteLine(this.Data); }

    }

    class Nodelist
    {
        protected int n;
        protected NODE? Head;
        protected NODE? Tail;
      //  public Nodelist() { Head = new NODE(); }
        // private static bool Compare<int>(int a, int b) where int : NODE {return a.Data.ToString() != b.Data.ToString();}
        public NODE Push_front(int data) // добавление в начало
        {
            NODE ptr = new NODE(data);
            ptr.Next = Head;
            if (Head != null) { Head.Prev = ptr; }
            if (Tail == null) { Tail = ptr; }
            Head = ptr;
            n++;
            return ptr;
        }
        public NODE Push_back(int data) //добавление в конец
        {
            NODE ptr = new NODE(data);
            ptr.Prev = Tail;
            if (Tail != null) { Tail.Next = ptr; }
            if (Head == null) { Head = ptr; }
            Tail = ptr;
            n++;
            return ptr;
        }
        public void Pop_front()
        { //удаление с головы
            if (Head == null) return;
            NODE? ptr = Head.Next;
            if (ptr != null) { ptr.Prev = null; }
            else Tail = ptr;
            n--;
            Head = ptr;
        }
        public void Pop_back() //удаление с конца
        {
            if (Tail == null) return;
            NODE? ptr = Tail.Prev;
            if (ptr != null) { ptr.Next = null; }
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
                ptr = ptr.Next;
                n++;
            }
            return ptr;
        }
        public NODE insert(int index, int data)//добавить на позицию
        {
            NODE right = getAt(index);
            if (right == null) return Push_back(data);

            NODE? left = right.Prev;
            if (left == null) return Push_front(data);

            NODE ptr = new NODE(data);
            ptr.Prev = left;
            ptr.Next = right;
            left.Next = ptr;
            right.Prev = ptr;
            n++;
            return ptr;
        }
        public void earse(int index) // удаление по позиции
        {
            NODE ptr = getAt(index);
            if (ptr == null) return;
            if (ptr.Prev == null) { Pop_front(); return; }
            if (ptr.Next == null) { Pop_back(); return; }
            NODE left = ptr.Prev;
            NODE righ = ptr.Next;
            left.Next = righ;
            righ.Prev = left;
            n--;
        }
        public NODE find(int data)// найти по ключу
        {
            NODE? ptr = Head;
            if (ptr == null) return ptr;
            while (ptr.Data != data)
            {
                ptr = ptr.Next;
                if (ptr == null) { return ptr; }
            }
            return ptr;
        }
        public NODE insert_key(int key, int data) //добавление после ключа
        {
            NODE? right = find(key);
            right = right.Next;
            if (right == null) return Push_back(data);

            NODE? left = right.Prev;
            if (left == null) return Push_front(data);

            NODE ptr = new NODE(data);
            ptr.Prev = left;
            ptr.Next = right;
            left.Next = ptr;
            right.Prev = ptr;
            n++;
            return ptr;
        }
        public void earse_key(int data) // удаление по ключу
        {
            NODE ptr = find(data);
            if (ptr == null) return;
            if (ptr.Prev == null) { Pop_front(); return; }
            if (ptr.Next == null) { Pop_back(); return; }
            NODE left = ptr.Prev;
            NODE righ = ptr.Next;
            left.Next = righ;
            righ.Prev = left;
            n--;
        }
        public NODE Max() //максимум
        {
            NODE? ptr = Head;
            NODE? data = ptr;
            while (ptr != null)
            {
                if (System.Convert.ToChar(data.Data) < System.Convert.ToChar(ptr.Data)) { data = ptr; }
                ptr = ptr.Next;
            }
            return data;
        }
        public NODE Min()
        {
            NODE? ptr = Head;
            NODE? data = ptr;
            while (ptr != null)
            {
                if (System.Convert.ToInt32(data.Data) > System.Convert.ToInt32(ptr.Data)) { data = ptr; }
                ptr = ptr.Next;
            }
            return data;
        }//минимум
        public bool is_empy() { if (Head == null) return true; return false; }
        public void clear() { while (Head != null) { Pop_back(); } }
        public static Nodelist operator +(Nodelist l1, Nodelist l2)
        {
            Nodelist list = new Nodelist();
            NODE? ptr1 = l1.Head;
            NODE? ptr2 = l2.Head;
            while (ptr1 != null) { list.Push_back(ptr1.Data); ptr1 = ptr1.Next; }
            while (ptr2 != null) { list.Push_back(ptr2.Data); ptr2 = ptr2.Next; }
            return list;
        }
        public static bool operator == (Nodelist l1, Nodelist l2)
        {
            NODE? ptr = l1.Head;
            NODE? ptr2 = l2.Head;
            if (ptr != null && ptr2 != null) return false;
            while (ptr.Data == ptr2.Data) { ptr = ptr.Next; ptr2 = ptr2.Next; }
            if (ptr == null && ptr2 == null) return true;
            return false;
        }
        public static bool operator !=(Nodelist l1, Nodelist l2)
        {
            return !(l1 == l2);
        }
        public void PRINT()
        {
            NODE? ptr = Head;
            while (ptr != null) { Console.Write(ptr.Data); Console.Write(" "); ptr = ptr.Next; }
        }
        public void Input()
        {
            var a= int.Parse(Console.ReadLine());
            Push_back(a);
        }
        public NODE this[int index]
        {
            get
            {
                return getAt(index);
            }
        }
        public void Sort()
        {
            int j = 0;
            int tmp = 0;
            for (int i = 0; i < n; i++)
            {
                j = i;
                for (int k = i; k < n; k++)
                {
                    if (this[j].Data > this[k].Data)
                    {
                        j = k;
                    }
                }
                tmp = this[i].Data;
                this[i].Data = this[j].Data;
                this[j].Data = tmp;
            }
        }
    }
    class NodeSet : Nodelist {
       // protected Nodelist Nodelist;
        public NodeSet() { n = 0; }
        public void unification(NodeSet other)
        {
            NODE ptr = other.Head;
            while (ptr != null)
            {
                Add(ptr.Data);
                ptr = ptr.Next;
            }

        }
        public NodeSet unification_new(NodeSet other)
        {
            NODE ptr = Head;
            NODE ptr2 = other.Head;
            NodeSet nodeSet= new NodeSet();
            while (ptr != null)
            {
                nodeSet.Add(ptr.Data);
                ptr = ptr.Next;
            }
            while (ptr2 != null)
            {
                nodeSet.Add(ptr2.Data);
                ptr2 = ptr2.Next;
            }
            return nodeSet;
        }
        public void Add(int data)
        {
            if (find(data) == null)
            {
                Push_back(data);
            }
        }
        public NodeSet Add_new(int data)
        {
            NodeSet ptr = this;
            if (find(data) == null)
            {
                ptr.Push_back(data);
            }
            return ptr;
        }
        public void Del(int data)
        {
            earse_key(data);
        }
        public NodeSet Del_new(int data)
        {
            NodeSet ptr = this;
            ptr.Del(data);
            return ptr;
        }
        public NodeSet intersection_new(NodeSet other)
        {
            NODE ptr= new NODE();
            NodeSet ptr2 = new NodeSet();
            ptr = Head;
            while(ptr != null ) {
                if (find(ptr.Data) != null && other.find(ptr.Data)!=null) { 
                    ptr2.Add(ptr.Data);
                    
                    if(ptr==null) { return ptr2; }
                }
                ptr = ptr.Next;
            }
            return ptr2;
        }
        public void intersection(NodeSet other)
        {
            NODE ptr = new NODE();
            ptr = Head;
            while(ptr != null ) {
                if(other.find(ptr.Data)==null) { Del(ptr.Data); }
                ptr = ptr.Next;
            }
        }

        public void difference(NodeSet other)
        {
            NodeSet ptr=this.intersection_new(other);
            NODE ptr2 = ptr.Head;
            while (ptr2!=null)
            {
                Del(ptr2.Data);
                ptr2 = ptr2.Next;
            }

        }
        public NodeSet difference_new(NodeSet other)
        {
            NodeSet ptr = this.intersection_new(other);
            NodeSet nodeSet = this;
            NODE ptr2 = ptr.Head;
            while (ptr2 != null)
            {
                nodeSet.Del(ptr2.Data);
                ptr2 = ptr2.Next;
            }
            return nodeSet;
        }
        public NodeSet complement(NodeSet other)
        {
            return this.difference_new(other);
        }
    }
}