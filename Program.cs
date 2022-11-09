using System;

namespace single_linked_list
{
    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }

    class list
    {
        Node START;
        public list()
        {
            START = null;
        }

        public void addNote()/*method untuk menambahkan sebuah node kedalam list*/
        {
            int nim;
            string nm;
            Console.Write("\nMasukkan nomor Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;

            if (START == null || nim <= START.noMhs) /*Node ditambahkan sebagai node*/
            {
                if((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nNomor mahasiswa sama tidak diijinkan\n");
                    return;
                }
                nodeBaru.next = START;
                START = nodeBaru;
                return;
            }
        }  

    }
}