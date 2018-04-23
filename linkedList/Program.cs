using System;

namespace linkedList
{
    class Node
    {
        private int data;
        private Node nextNode;

        public Node(Node nextNode, int data)
        {
            this.data = data;
            this.nextNode= nextNode;
        }

        public int getData(){return this.data;}
        public Node getNode(){return this.nextNode;}

        public void setData(int data){this.data = data;}
        public void setNode(Node node){this.nextNode = node;}
    }

    class linkedList
    {
        Node root;
        public linkedList()
        {
            this.root = null;
        }

        public void insertStart(int data)
        {
            if(root==null)
            {
                Node newNode = null;
                root = new Node(newNode, data);
            }
            else
            {
                Node newNode = new Node(this.root, data);
                root = newNode;
            }
        }

        public void insertAt(int loc, int data)
        {
            if(root == null && loc > 0){Console.WriteLine("err: list empty");}
            if(loc == 0)
            {
                insertStart(data);
            }
            Node current = root;
            try
            {
                for(int i=0; i < loc-1; i++)
                {
                    Console.WriteLine("current Data {0}", current.getData());
                    current = current.getNode();
                }
                Node newNode = new Node(current.getNode(), data);
                current.setNode(newNode);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("err: location out of index");
                Console.WriteLine(e);
            }
            
        }

        public void insertEnd(int data)
        {
            if(root==null)
            {
                Node newNode = null;
                root = new Node(newNode, data);
            }
            else
            {
                Node current = this.root;
                while(current.getNode()!=null)
                {
                    current = current.getNode();
                }
                Node newNode = new Node(null, data);
                current.setNode(newNode);
            }
        }
    
        public void writeList()
        {
            if(this.root == null)
            {
                Console.WriteLine("List is empty");
            }

            Node current = this.root;
            Console.WriteLine(current.getData());
            while(current.getNode()!=null)
            {
                current = current.getNode();
                Console.WriteLine(current.getData());
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            linkedList list = new linkedList();
            list.insertStart(5);
            list.insertStart(4);
            list.insertStart(90);
            list.insertStart(2);
            list.insertEnd(12);
            list.writeList();
            Console.WriteLine("\n");
            list.insertAt(7, 15);
            list.writeList();
        }
    }
}
