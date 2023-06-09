using System;
using System.Drawing;
using System.Xml.Linq;
//https://www.programiz.com/csharp-programming/online-compiler/
//https://rextester.com/
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
                Console.WriteLine();
                Console.WriteLine();
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
                int[] a = new int[6];
                Random rnd = new Random();
                for (int i=0; i<a.Length; i++) { a[i] = rnd.Next() % 20; }
                Nodelist S4 = new Nodelist(a);
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
                S5.Input();
                S5.PRINT();
                if (S5 == S4) { Console.WriteLine("S5==S4"); }
                else Console.WriteLine("S5!=S4");
                Console.WriteLine("\n\n10) Добавьте в хвост S5 список S4. Добавьте в голову S5 список S1.");
                S5 = S1 + S5 + S4;
                S5.PRINT();
            }
            else
            {
                Console.WriteLine("1)Создайте множество S1, из 10 случайных чисел. Выведите S1 на экран (используя функцию Print).");
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
                T.Sort();
                T.PRINT();
                //NodeSet S6=new NodeSet();
                NodeSet S6 = new NodeSet(T);
                S6.PRINT();
                Console.WriteLine(S6.size);
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
                V1= (NodeSet)(V1.unification_new(V3));
                V1.PRINT();
                if (V1==S7) { Console.WriteLine("V1==S7"); }
                else { Console.WriteLine("V1!=S7"); }
                Console.WriteLine("\n\n10)Измените множество V2, заменив его разностью V2 и V3. Сравните V2  с  S9");
                V2= (NodeSet)(V2.difference_new(V3));
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
        public NODE(int data, NODE? next=null, NODE? prev = null) { Data = data; Next = next; Prev = prev; }
        public NODE() { Data = default(int); Next = null; Prev = null; }
        public void Print() { 
            Console.Write("{0} {1}",this.Data,"");
        }
        public int data
        {
            get { return Data; }
            set { Data = value; }
        }
        public NODE prev
        {
            get { return Prev; }
            set { Prev = value; }
        }
        public NODE next
        {
            get { return Next; }
            set {Next = value;}
        }
    }
    class Nodelist
    {
        //protected int n;
        protected NODE? Head;
        protected NODE? Tail;
        public NODE head
        {
            get { return Head; }
            set { Head = value; }
        }
        public NODE tail
        {
            get { return Tail; }
            set { Tail = value; }
        }
        public Nodelist() { Head = null;Tail = null; }
        public Nodelist(int size,int rang=1000) {
            Random rnd = new Random();
            for(int i=0;i<size; i++)
            {
                Push_back(rnd.Next()%rang);
            }
            Sort();
        }
        public Nodelist(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Push_back(a[i]);
            }
            Sort();
        }
        public Nodelist(Nodelist A)
        {
            Head = null;
            Tail = null;
            for (int i = 0; A[i] != null;i++)
            {
                this.Push_back(A[i].data);
            }
            // Console.WriteLine();
            Sort();
        }
        public object Clone() {
            Nodelist ptr = new Nodelist();
            NODE? pt = Head;
            while(pt!=null) {
                ptr.Push_back(pt.data);
                pt = pt.next;
            }
            return ptr;
        }
        public NODE Push_front(int data) // добавление в начало
        {
            NODE ptr = new NODE(data);
            ptr.next = Head;
            if (Head != null) { Head.prev=ptr; }
            if (Tail == null) { Tail = ptr; }
            Head = ptr;
            return ptr;
        }
        public NODE Push_back(int data) //добавление в конец
        {
            NODE ptr = new NODE(data);
            ptr.prev=Tail;
            if (Tail != null) { Tail.next=ptr; }
            if (Head == null) { Head = ptr; }
            Tail = ptr;
            return ptr;
        }
        public void Pop_front()
        { 
            if (Head == null) return;
            NODE? ptr = Head.next;
            if (ptr != null) { ptr.prev=null; }
            else Tail = ptr;
            Head = ptr;
        }//удаление с головы
        public void Pop_back() //удаление с конца
        {
            if (Tail == null) return;
            NODE? ptr = Tail.prev;
            if (ptr != null) { ptr.next=(null); }
            else Head = ptr;
            Tail = ptr;
        }
        public NODE getAt(int index) //поиск по позиции
        {
            NODE? ptr = Head;
            int k = 0;
            while (k != index)
            {
                if (ptr == null) return ptr;
                ptr = ptr.next;
                k++;
            }
            return ptr;
        }
        public NODE insert(int index, int data)//добавить на позицию
        {
            NODE right = getAt(index);
            if (right == null) return Push_back(data);

            NODE? left = right.prev;
            if (left == null) return Push_front(data);

            NODE ptr = new NODE(data);
            ptr.prev=left;
            ptr.next=right;
            left.next=ptr;
            right.prev = ptr;
            return ptr;
        }
        public void earse(int index) // удаление по позиции
        {
            NODE ptr = getAt(index);
            if (ptr == null) return;
            if (ptr.prev == null) { Pop_front(); return; }
            if (ptr.next == null) { Pop_back(); return; }
            NODE left = ptr.prev;
            NODE righ = ptr.next;
            left.next=righ;
            righ.prev=left;
        }
        public NODE find(int data)// найти по ключу
        {
            NODE? ptr = Head;
            if (ptr == null) return ptr;
            while (ptr.data != data)
            {
                ptr = ptr.next;
                if (ptr == null) { return ptr; }
            }
            return ptr;
        }
        public NODE insert_key(int key, int data) //добавление после ключа
        {   
            NODE? right = find(key);
            right = right.next;
            if (right == null) return Push_back(data);

            NODE? left = right.prev;
            if (left == null) return Push_front(data);
            NODE ptr = new NODE(data);
            ptr.prev=left;
            ptr.next=right;
            left.next=ptr;
            right.prev=ptr;
            return ptr;
        }
        public void earse_key(int data) // удаление по ключу
        {
            NODE ptr = find(data);
            if (ptr == null) return;
            if (ptr.prev == null) { Pop_front(); return; }
            if (ptr.next == null) { Pop_back(); return; }
            NODE left = ptr.prev;
            NODE righ = ptr.next;
            left.next=righ;
            righ.prev = left;
        }
        public NODE Max() //максимум
        {
            NODE? ptr = Head;
            NODE? data = ptr;
            while (ptr != null)
            {
                if (System.Convert.ToChar(data.data) < System.Convert.ToChar(ptr.data)) { data = ptr; }
                ptr = ptr.next;
            }
            return data;
        }
        public NODE Min()
        {
            NODE? ptr = Head;
            NODE? data = ptr;
            while (ptr != null)
            {
                if (System.Convert.ToInt32(data.data) > System.Convert.ToInt32(ptr.data)) { data = ptr; }
                ptr = ptr.next;
            }
            return data;
        }//минимум
        public bool is_empy() { if (Head == null) return true; return false; } //проверка на пустоту
        public void clear() { Head = null;Tail = null; }//очистка
        public override bool Equals(object? obj)
        {
            if (Head == null || ((Nodelist)obj).Head == null) return false;
            NODE ptr = Head;
            NODE? ptr2 = ((Nodelist)obj).Head;
            while (ptr != null || ptr2 != null)
            {
                if (ptr.data != ptr2.data) return false;
                ptr = ptr.next;
                ptr2 = ptr2.next;
            }
            return true;
        }
        public static Nodelist operator +(Nodelist l1, Nodelist l2)
        {
            Nodelist list = new Nodelist();
            NODE? ptr1 = l1.Head;
            NODE? ptr2 = l2.Head;
            while (ptr1 != null) { list.Push_back(ptr1.data); ptr1 = ptr1.next; }
            while (ptr2 != null) { list.Push_back(ptr2.data); ptr2 = ptr2.next; }
            return list;
        } //перегрузка +
        public static bool operator == (Nodelist l1, Nodelist l2)
        {
            return l1.Equals(l2);
        } //перегрузка ==
        public static bool operator !=(Nodelist l1, Nodelist l2)
        {
            return !(l1==l2);
        } //перегрузка !=
        public void PRINT()
        {
            NODE? ptr = Head;
            while (ptr != null) { ptr.Print(); ptr = ptr.next; }
            Console.WriteLine();
        }
        public void Input()
        {
            var str = Console.ReadLine();
            if (str != null)
            {
                string[] words = str.Split(' ');
                foreach (string x in words)
                {
                    Push_back(int.Parse(x));
                }
            }
            Sort();
        }
        public NODE this[int index]
        {
            get
            {
                return getAt(index);
            }
            set
            {
                insert(index, value.data);
            }
        } //перегрузка []
        public void Sort()
        {
            Nodelist? ptr = (Nodelist)this.Clone();
            this.clear();
            while (!ptr.is_empy())
            {
                var a = ptr.Min().data;
                Push_back(a);
                ptr.earse_key(a);
            }
        }//сортировка
    }
    class NodeSet : Nodelist {
        protected int Size;
        public int size
        {
            get { return Size; }
            set { Size = value; }
        }
        public NodeSet() { Size = 0; }
        public NodeSet(int size,int rang):base(size,rang)
        {
            Random rnd = new Random();
            Size = size;
            for (var i = 0; i < Size; i++)
            {
                for (var j = 0; j < Size; j++)
                {
                    if (i != j)
                    {
                        if (this[i].data == this[j].data)
                        {
                            Del(this[i].data);
                        }
                    }
                }
            }
            while (Size < size) {
                Add(rnd.Next()%rang);
            }
        }
        public NodeSet(Nodelist l1):base(l1)
        {
            Size = 0;
            NODE ptr = Head;
            while (ptr != null)
            {
                Size++;
                ptr= ptr.next;
            }
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (i != j)
                    {
                        if (this[i].data == this[j].data)
                        {
                            Del(this[i].data);
                        }
                    }
                }
            }
        }
        public NodeSet(NodeSet A)
        {
            Head = null;
            Tail = null;
            for (int i = 0; i<Size; i++)
            {
                this.Add(A[i].data);
            }
           // Console.WriteLine();
        }
        new public void Input()
        {
            var str = Console.ReadLine();
            if (str != null)
            {
                string[] num = str.Split(' ');
                foreach (string x in num)
                {
                    Add(int.Parse(x));
                    Size++;
                }
            }
            //  Sort();
        }
        new public object Clone()
        {
            NodeSet ptr = new NodeSet();
            NODE? pt = Head;
            while (pt != null)
            {
                ptr.Add(pt.data);
                pt = pt.next;
            }
           // ptr.Sort();
            return ptr;
        }
        public void unification(NodeSet other)
        {
            NODE? ptr = other.Head;
            while (ptr != null)
            {
                Add(ptr.data);
                ptr = ptr.next;
            }
         //   Sort();
        } //	объединение двух множеств
        public NodeSet unification_new(NodeSet other)
        {
            NODE? ptr = Head;
            NODE? ptr2 = other.Head;
            NodeSet nodeSet= new NodeSet();
            while (ptr != null)
            {
                nodeSet.Add(ptr.data);
                ptr = ptr.next;
            }
            while (ptr2 != null)
            {
                nodeSet.Add(ptr2.data);
                ptr2 = ptr2.next;
            }
          //  nodeSet.Sort();
            return nodeSet;
        }
        public void Add(int data)
        {
            if (find(data) == null)
            {
                Push_back(data);
                Size++;
            }
          //  Sort();
        }//	добавление элемента к множеству 
        public NodeSet Add_new(int data)
        {
            NodeSet ptr = (NodeSet)this.Clone();
            if (find(data) == null)
            {
                ptr.Push_back(data);
                ptr.Size++;
            }
           // ptr.Sort();
            return ptr;
        }
        public void Del(int data)
        {
            earse_key(data);
            Size--;
           // Sort();
        }// 	удаление элемента 
        public NodeSet Del_new(int data)
        {
            NodeSet ptr = (NodeSet)this.Clone();
            ptr.Del(data);
            ptr.Size--;
          //  ptr.Sort();
            return ptr;
        }
        public NodeSet intersection_new(NodeSet other)
        {
            NODE? ptr= new NODE();
            NodeSet ptr2 = new NodeSet();
            ptr = Head;
            while(ptr != null ) {
                if (find(ptr.data) != null && other.find(ptr.data)!=null) { 
                    ptr2.Add(ptr.data);
                    
                    if(ptr==null) { return ptr2; }
                }
                ptr = ptr.next;
            }
         //   ptr2.Sort();
            return ptr2;
        } //пересечение двух множеств 
        public void intersection(NodeSet other)
        {
            NODE? ptr = new NODE();
            ptr = Head;
            while(ptr != null ) {
                if(other.find(ptr.data)==null) { Del(ptr.data); }
                ptr = ptr.next;
            }
        }
        public void difference(NodeSet other)
        {
            NodeSet ptr=this.intersection_new(other);
            NODE? ptr2 = ptr.Head;
            while (ptr2!=null)
            {
                Del(ptr2.data);
                ptr2 = ptr2.next;
            }

        } //	разность двух множеств 
        public NodeSet difference_new(NodeSet other)
        {
            NodeSet? ptr = this.intersection_new(other);
            NodeSet? nodeSet = this;
            NODE? ptr2 = ptr.Head;
            while (ptr2 != null)
            {
                nodeSet.Del(ptr2.data);
                ptr2 = ptr2.next;
            }
            return nodeSet;
        }
        public NodeSet complement()
        {
            NodeSet ptr = new NodeSet();
            int max = Max().data;
            for (int i = 0; i <= max; i++)
            {
                ptr.Add(i);
                
            }
            ptr.difference(this);
            return ptr;
        } //дополнение до идеального множества
        public override bool Equals(object? obj)
        {
            if (Size != ((NodeSet)obj).Size) return false;
            if (Head == null || ((NodeSet)obj).Head == null) return false;
            for (int i = 0; i < Size; i++)
            {
                if (find(((NodeSet)obj)[i].data) == null) return false;
            }
            return true;
        }
        public static bool operator == (NodeSet l1, NodeSet l2)
        {
            return l1.Equals(l2);
        } //перегрузка ==
        public static bool operator !=(NodeSet l1, NodeSet l2)
        {
            return !(l1==l2);
        } //перегрузка !=
    }
}
