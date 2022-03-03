using System;
using System.Collections.Generic;

namespace CShapInterfacesCasting {

    interface IStorable {
        void LoadDocument();
        void SaveDocument();
        Boolean NeedsSave {get; set;}
    }

    class Document : IStorable {

        private string name;

        public Document(string s) {
            name = s;
            Console.WriteLine("Creating new document with name '{0}'", name);
        }

        public void LoadDocument() {
            Console.WriteLine("Loading the document");
        }

        public void SaveDocument() {
            Console.WriteLine("Saving the document");
        }

        public Boolean NeedsSave {
            get;
            set;
        }

    } // End class Document

    class Program {

        static void Main(string[] args) {

            Document d = new Document("Test Document");
           
           if(d is IStorable) {
               d.SaveDocument();
           }

           IStorable istore = d as IStorable;
           if(istore != null) {
               d.LoadDocument();
           }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}